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
            this.mnutrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltrangchu
            // 
            this.pnltrangchu.Location = new System.Drawing.Point(0, 63);
            this.pnltrangchu.Name = "pnltrangchu";
            this.pnltrangchu.Size = new System.Drawing.Size(800, 436);
            this.pnltrangchu.TabIndex = 1;
            // 
            // mnu1
            // 
            this.mnu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutrangchu,
            this.mnudangnhap,
            this.mnuthoat});
            this.mnu1.Location = new System.Drawing.Point(0, 0);
            this.mnu1.Name = "mnu1";
            this.mnu1.Size = new System.Drawing.Size(800, 28);
            this.mnu1.TabIndex = 2;
            this.mnu1.Text = "menuStrip1";
            // 
            // mnutrangchu
            // 
            this.mnutrangchu.Name = "mnutrangchu";
            this.mnutrangchu.Size = new System.Drawing.Size(87, 24);
            this.mnutrangchu.Text = "Trang chủ";
            // 
            // mnudangnhap
            // 
            this.mnudangnhap.Name = "mnudangnhap";
            this.mnudangnhap.Size = new System.Drawing.Size(99, 24);
            this.mnudangnhap.Text = "Đăng Nhập";
            this.mnudangnhap.Click += new System.EventHandler(this.mnudangnhap_Click);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(61, 24);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // frmtrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.pnltrangchu);
            this.Controls.Add(this.mnu1);
            this.Name = "frmtrangchu";
            this.Text = "Trang Chủ";
            this.mnu1.ResumeLayout(false);
            this.mnu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnltrangchu;
        private System.Windows.Forms.MenuStrip mnu1;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnudangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
    }
}