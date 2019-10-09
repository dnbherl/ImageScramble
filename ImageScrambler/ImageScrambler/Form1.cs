using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ImageScrambler
{
    public partial class frmMain : Form
    {

        public Bitmap thisImage = null;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();            
            if (dg.ShowDialog() == DialogResult.OK)
            {
                if (dg.OpenFile() != null)
                {
                    LoadImage(dg.FileName);
                }
            }
        }

        private void LoadImage(string filename)
        {
            thisImage = new Bitmap(filename);
            picMain.Width = 350;
            picMain.Height = 350;
            picMain.ImageLocation = filename;

            if (thisImage.Height > thisImage.Width)
            {
                picMain.Width = Convert.ToInt32(Convert.ToDecimal(thisImage.Width) / Convert.ToDecimal(thisImage.Height) * 350);
            }
            if (thisImage.Width > thisImage.Height)
            {
                picMain.Height = Convert.ToInt32(Convert.ToDecimal(thisImage.Height) / Convert.ToDecimal(thisImage.Width) * 350);
            }
        }
        

        private void SaveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thisImage == null) return;
            SaveFileDialog dg = new SaveFileDialog();
            dg.Filter = "PNG (*.png)|*.png";
            dg.DefaultExt = "png";
            dg.AddExtension = true;
            if (dg.ShowDialog() == DialogResult.OK)
            {
                if (dg.FileName != null)
                {
                    thisImage.Save(dg.FileName, ImageFormat.Png);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnScramble_Click(object sender, EventArgs e)
        {
            if (thisImage != null) ScrambleImage();
        }

        private void BtnUnscramble_Click(object sender, EventArgs e)
        {
            if (thisImage != null) UnscrambleImage();
        }

        private void ScrambleImage()
        {
            int tarX;
            int tarY;
            long cnt = 0;
            string hashval = CreateHashString(txtPassphrase.Text);
            Color newCol = new Color();
            Color newCol2 = new Color();
            progBar.Maximum = thisImage.Height * thisImage.Width * 2;
            progBar.Value = 0;
            this.Enabled = false;
            for (int y = 0; y < thisImage.Height; y++)
            {
                for(int x = 0; x< thisImage.Width; x++)
                {
                    cnt += 1;
                    progBar.Value += 1;
                    int hv = (int)hashval[(int)(cnt % (long)(hashval.Length))];
                    tarX = (int)((cnt*hv^23) % thisImage.Width);
                    tarY = (int)((cnt*hv^23) % thisImage.Height);
                    Color swapPixel = thisImage.GetPixel(tarX, tarY);
                    Color tmpPixel = thisImage.GetPixel(x, y);
                    switch (cnt % 3)
                    {
                        case 0:
                            newCol = Color.FromArgb(swapPixel.R, swapPixel.G, swapPixel.B);
                            newCol2 = Color.FromArgb(tmpPixel.R, tmpPixel.G, tmpPixel.B);
                            break;
                        case 1:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.R, swapPixel.G);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.R, tmpPixel.G);
                            break;
                        case 2:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.G, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.G, tmpPixel.R);
                            break;
                    }
                    thisImage.SetPixel(x, y, newCol);
                    thisImage.SetPixel(tarX, tarY, newCol2);
                }
            }
            cnt = 0;
            for (int x = 0; x < thisImage.Width; x++)
            {
                for (int y = 0; y < thisImage.Height; y++)
                {
                    cnt += 1;
                    progBar.Value += 1;
                    int hv = (int)hashval[(int)(cnt % (long)(hashval.Length))];
                    tarX = (int)((cnt * hv ^ 19) % thisImage.Width);
                    tarY = (int)((cnt * hv ^ 19) % thisImage.Height);
                    Color swapPixel = thisImage.GetPixel(tarX, tarY);
                    Color tmpPixel = thisImage.GetPixel(x, y);
                    switch (cnt % 3)
                    {
                        case 0:
                            newCol = Color.FromArgb(swapPixel.R, swapPixel.G, swapPixel.B);
                            newCol2 = Color.FromArgb(tmpPixel.R, tmpPixel.G, tmpPixel.B);
                            break;
                        case 1:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.R, swapPixel.G);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.R, tmpPixel.G);
                            break;
                        case 2:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.G, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.G, tmpPixel.R);
                            break;
                    }
                    thisImage.SetPixel(x, y, newCol);
                    thisImage.SetPixel(tarX, tarY, newCol2);
                }
            }
            picMain.Image = thisImage;
            progBar.Value = 0;
            this.Enabled = true;
        }

        private void UnscrambleImage()
        {
            int tarX;
            int tarY;
            Color newCol = new Color();
            Color newCol2 = new Color();
            long cnt = thisImage.Width * thisImage.Height;
            string hashval = CreateHashString(txtPassphrase.Text);
            progBar.Maximum = thisImage.Height * thisImage.Width * 2;
            progBar.Value = 0;
            this.Enabled = false;
            for (int x = thisImage.Width - 1; x >= 0; x--)
            {
                for (int y = thisImage.Height - 1; y >= 0; y--)
                {
                    progBar.Value += 1;
                    int hv = (int)hashval[(int)(cnt % (long)(hashval.Length))];
                    tarX = (int)((cnt * hv ^ 19) % thisImage.Width);
                    tarY = (int)((cnt * hv ^ 19) % thisImage.Height);
                    Color swapPixel = thisImage.GetPixel(tarX, tarY);
                    Color tmpPixel = thisImage.GetPixel(x, y);
                    switch (cnt % 3)
                    {
                        case 0:
                            newCol = Color.FromArgb(swapPixel.R, swapPixel.G, swapPixel.B);
                            newCol2 = Color.FromArgb(tmpPixel.R, tmpPixel.G, tmpPixel.B);
                            break;
                        case 1:
                            newCol = Color.FromArgb(swapPixel.G, swapPixel.B, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.G, tmpPixel.B, tmpPixel.R);
                            break;
                        case 2:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.G, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.G, tmpPixel.R);
                            break;
                    }
                    thisImage.SetPixel(x, y, newCol);
                    thisImage.SetPixel(tarX, tarY, newCol2);
                    cnt -= 1;
                }
            }
            cnt = thisImage.Width * thisImage.Height;
            for (int y = thisImage.Height - 1; y >= 0; y--)
            {
                for (int x = thisImage.Width - 1; x >= 0; x--)
                {
                    progBar.Value += 1;
                    int hv = (int)hashval[(int)(cnt % (long)(hashval.Length))];
                    tarX = (int)((cnt * hv ^ 23) % thisImage.Width);
                    tarY = (int)((cnt * hv ^ 23) % thisImage.Height);
                    Color swapPixel = thisImage.GetPixel(tarX, tarY);
                    Color tmpPixel = thisImage.GetPixel(x, y);
                    switch (cnt % 3)
                    {
                        case 0:
                            newCol = Color.FromArgb(swapPixel.R, swapPixel.G, swapPixel.B);
                            newCol2 = Color.FromArgb(tmpPixel.R, tmpPixel.G, tmpPixel.B);
                            break;
                        case 1:
                            newCol = Color.FromArgb(swapPixel.G, swapPixel.B, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.G, tmpPixel.B, tmpPixel.R);
                            break;
                        case 2:
                            newCol = Color.FromArgb(swapPixel.B, swapPixel.G, swapPixel.R);
                            newCol2 = Color.FromArgb(tmpPixel.B, tmpPixel.G, tmpPixel.R);
                            break;
                    }
                    thisImage.SetPixel(x, y, newCol);
                    thisImage.SetPixel(tarX, tarY, newCol2);
                    cnt -= 1;
                }
            }
            picMain.Image = thisImage;
            progBar.Value = 0;
            this.Enabled = true;
        }

        public static String CreateHashString(string value)
        {
            String ret = "";
            string h = sha256_hash(value);
            for (int i = 0; i < h.Length; i++)
            {
                ret += sha256_hash(h[i].ToString());
            }
            return ret;
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadImage(files[0]);
        }

    }
}
