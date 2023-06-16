namespace Thi_KTHP
{
    partial class frmtrangchu
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
            this.pnltrangchu = new System.Windows.Forms.Panel();
            this.mnu1 = new System.Windows.Forms.MenuStrip();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnutrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.pnltrangchu.SuspendLayout();
            this.mnu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltrangchu
            // 
            this.pnltrangchu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnltrangchu.Controls.Add(this.pictureBox1);
            this.pnltrangchu.Location = new System.Drawing.Point(0, 76);
            this.pnltrangchu.Name = "pnltrangchu";
            this.pnltrangchu.Size = new System.Drawing.Size(800, 423);
            this.pnltrangchu.TabIndex = 1;
            // 
            // mnu1
            // 
            this.mnu1.AutoSize = false;
            this.mnu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutrangchu,
            this.mnudangnhap,
            this.mnuthoat});
            this.mnu1.Location = new System.Drawing.Point(0, 0);
            this.mnu1.Name = "mnu1";
            this.mnu1.Size = new System.Drawing.Size(800, 73);
            this.mnu1.TabIndex = 2;
            this.mnu1.Text = "menuStrip1";
            // 
            // mnuthoat
            // 
            this.mnuthoat.Image = global::Thi_KTHP.Properties.Resources.thoat;
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(81, 69);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Thi_KTHP.Properties.Resources.Trang_chủ;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mnutrangchu
            // 
            this.mnutrangchu.Image = global::Thi_KTHP.Properties.Resources.Trangchu;
            this.mnutrangchu.Name = "mnutrangchu";
            this.mnutrangchu.Size = new System.Drawing.Size(107, 69);
            this.mnutrangchu.Text = "Trang chủ";
            this.mnutrangchu.Click += new System.EventHandler(this.mnutrangchu_Click);
            // 
            // mnudangnhap
            // 
            this.mnudangnhap.Image = global::Thi_KTHP.Properties.Resources.Đăng_nhập;
            this.mnudangnhap.Name = "mnudangnhap";
            this.mnudangnhap.Size = new System.Drawing.Size(119, 69);
            this.mnudangnhap.Text = "Đăng Nhập";
            this.mnudangnhap.Click += new System.EventHandler(this.mnudangnhap_Click);
            // 
            // frmtrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.pnltrangchu);
            this.Controls.Add(this.mnu1);
            this.Name = "frmtrangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.frmtrangchu_Load);
            this.pnltrangchu.ResumeLayout(false);
            this.mnu1.ResumeLayout(false);
            this.mnu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnltrangchu;
        private System.Windows.Forms.MenuStrip mnu1;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnudangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}