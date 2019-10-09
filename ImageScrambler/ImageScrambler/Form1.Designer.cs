using System.Windows.Forms;

namespace ImageScrambler
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnScramble = new System.Windows.Forms.Button();
            this.btnUnscramble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.SaveImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // picMain
            // 
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMain.Location = new System.Drawing.Point(12, 36);
            this.picMain.MaximumSize = new System.Drawing.Size(350, 350);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(350, 350);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            this.picMain.WaitOnLoad = true;
            // 
            // btnScramble
            // 
            this.btnScramble.Location = new System.Drawing.Point(372, 81);
            this.btnScramble.Name = "btnScramble";
            this.btnScramble.Size = new System.Drawing.Size(75, 23);
            this.btnScramble.TabIndex = 2;
            this.btnScramble.Text = "Scramble";
            this.btnScramble.UseVisualStyleBackColor = true;
            this.btnScramble.Click += new System.EventHandler(this.BtnScramble_Click);
            // 
            // btnUnscramble
            // 
            this.btnUnscramble.Location = new System.Drawing.Point(453, 81);
            this.btnUnscramble.Name = "btnUnscramble";
            this.btnUnscramble.Size = new System.Drawing.Size(75, 23);
            this.btnUnscramble.TabIndex = 3;
            this.btnUnscramble.Text = "Unscramble";
            this.btnUnscramble.UseVisualStyleBackColor = true;
            this.btnUnscramble.Click += new System.EventHandler(this.BtnUnscramble_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Passphrase:";
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(372, 55);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(156, 20);
            this.txtPassphrase.TabIndex = 6;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(368, 363);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(160, 23);
            this.progBar.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.txtPassphrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnscramble);
            this.Controls.Add(this.btnScramble);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageScramble v1.0";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnScramble;
        private System.Windows.Forms.Button btnUnscramble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassphrase;
        private System.Windows.Forms.ProgressBar progBar;
    }
}

