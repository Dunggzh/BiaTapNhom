using System.Windows.Forms;

namespace Thi_KTHP
{
    partial class frmtrangchugv
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtThoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlqlgv = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlqlgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýĐiểmSinhToolStripMenuItem,
            this.thôngTinHọcToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Image = global::Thi_KTHP.Properties.Resources.Trangchu;
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(123, 57);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýSinhViênToolStripMenuItem.Image = global::Thi_KTHP.Properties.Resources.quản_lý_sinh_viên;
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 57);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click_1);
            // 
            // quảnLýĐiểmSinhToolStripMenuItem
            // 
            this.quảnLýĐiểmSinhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýĐiểmSinhToolStripMenuItem.Image = global::Thi_KTHP.Properties.Resources.quản_lý_sinh_viên;
            this.quảnLýĐiểmSinhToolStripMenuItem.Name = "quảnLýĐiểmSinhToolStripMenuItem";
            this.quảnLýĐiểmSinhToolStripMenuItem.Size = new System.Drawing.Size(193, 57);
            this.quảnLýĐiểmSinhToolStripMenuItem.Text = "Quản lý điểm sinh ";
            this.quảnLýĐiểmSinhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐiểmSinhToolStripMenuItem_Click);
            // 
            // thôngTinHọcToolStripMenuItem
            // 
            this.thôngTinHọcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinHọcToolStripMenuItem.Image = global::Thi_KTHP.Properties.Resources.Thống_kê;
            this.thôngTinHọcToolStripMenuItem.Name = "thôngTinHọcToolStripMenuItem";
            this.thôngTinHọcToolStripMenuItem.Size = new System.Drawing.Size(160, 57);
            this.thôngTinHọcToolStripMenuItem.Text = "Thông tin học ";
            this.thôngTinHọcToolStripMenuItem.Click += new System.EventHandler(this.thôngTinHọcToolStripMenuItem_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.sửaThôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtThoátToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngườiDùngToolStripMenuItem.Image = global::Thi_KTHP.Properties.Resources.người_dùng;
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(142, 57);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(273, 28);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // sửaThôngTinCáNhânToolStripMenuItem
            // 
            this.sửaThôngTinCáNhânToolStripMenuItem.Name = "sửaThôngTinCáNhânToolStripMenuItem";
            this.sửaThôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.sửaThôngTinCáNhânToolStripMenuItem.Text = "Sửa Thông tin cá nhân";
            this.sửaThôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtThoátToolStripMenuItem
            // 
            this.đăngXuấtThoátToolStripMenuItem.Name = "đăngXuấtThoátToolStripMenuItem";
            this.đăngXuấtThoátToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.đăngXuấtThoátToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtThoátToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtThoátToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pnlqlgv
            // 
            this.pnlqlgv.Controls.Add(this.pictureBox1);
            this.pnlqlgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlqlgv.Location = new System.Drawing.Point(0, 61);
            this.pnlqlgv.Name = "pnlqlgv";
            this.pnlqlgv.Size = new System.Drawing.Size(878, 389);
            this.pnlqlgv.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Thi_KTHP.Properties.Resources.Trang_chủ;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmtrangchugv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.pnlqlgv);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmtrangchugv";
            this.Text = "Trang Chủ Giảng Viên";
            this.Load += new System.EventHandler(this.frmtrangchugv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlqlgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmSinhToolStripMenuItem;
        private ToolStripMenuItem thôngTinHọcToolStripMenuItem;
        private Panel pnlqlgv;
        private ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private ToolStripMenuItem sửaThôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtThoátToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}