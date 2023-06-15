namespace Thi_KTHP
{
    partial class frmtrangchuqt
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
            this.pnlform = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mnuquantri = new System.Windows.Forms.MenuStrip();
            this.mnutc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqldiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlgv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlhp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlkhdt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlkhoahoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqllop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqln = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlnhomhp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqltaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuht = new System.Windows.Forms.ToolStripMenuItem();
            this.mnund = new System.Windows.Forms.ToolStripMenuItem();
            this.mnundtk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunddx = new System.Windows.Forms.ToolStripMenuItem();
            this.mnundthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunddoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.mnuquantri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlform
            // 
            this.pnlform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlform.BackColor = System.Drawing.SystemColors.Control;
            this.pnlform.Location = new System.Drawing.Point(0, 121);
            this.pnlform.Name = "pnlform";
            this.pnlform.Size = new System.Drawing.Size(819, 460);
            this.pnlform.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mnuquantri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 115);
            this.panel3.TabIndex = 1;
            // 
            // mnuquantri
            // 
            this.mnuquantri.AutoSize = false;
            this.mnuquantri.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuquantri.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuquantri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutc,
            this.mnuql,
            this.mnutk,
            this.mnuht,
            this.mnund});
            this.mnuquantri.Location = new System.Drawing.Point(0, 0);
            this.mnuquantri.Name = "mnuquantri";
            this.mnuquantri.Size = new System.Drawing.Size(819, 115);
            this.mnuquantri.TabIndex = 0;
            this.mnuquantri.Text = "menuStrip1";
            // 
            // mnutc
            // 
            this.mnutc.Name = "mnutc";
            this.mnutc.Size = new System.Drawing.Size(87, 111);
            this.mnutc.Text = "Trang chủ";
            this.mnutc.Click += new System.EventHandler(this.mnutc_Click);
            // 
            // mnuql
            // 
            this.mnuql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuqldiem,
            this.mnuqlgv,
            this.mnuqlhp,
            this.mnuqlkhdt,
            this.mnuqlk,
            this.mnuqlkhoahoc,
            this.mnuqllop,
            this.mnuqln,
            this.mnuqlnhomhp,
            this.mnuqlsv,
            this.mnuqltaikhoan});
            this.mnuql.Name = "mnuql";
            this.mnuql.Size = new System.Drawing.Size(73, 111);
            this.mnuql.Text = "Quản lý";
            // 
            // mnuqldiem
            // 
            this.mnuqldiem.Name = "mnuqldiem";
            this.mnuqldiem.Size = new System.Drawing.Size(224, 26);
            this.mnuqldiem.Text = "Điểm";
            this.mnuqldiem.Click += new System.EventHandler(this.mnuqldiem_Click);
            // 
            // mnuqlgv
            // 
            this.mnuqlgv.Name = "mnuqlgv";
            this.mnuqlgv.Size = new System.Drawing.Size(224, 26);
            this.mnuqlgv.Text = "Giảng viên";
            this.mnuqlgv.Click += new System.EventHandler(this.mnuqlgv_Click);
            // 
            // mnuqlhp
            // 
            this.mnuqlhp.Name = "mnuqlhp";
            this.mnuqlhp.Size = new System.Drawing.Size(224, 26);
            this.mnuqlhp.Text = "Học phần";
            this.mnuqlhp.Click += new System.EventHandler(this.mnuqlhp_Click);
            // 
            // mnuqlkhdt
            // 
            this.mnuqlkhdt.Name = "mnuqlkhdt";
            this.mnuqlkhdt.Size = new System.Drawing.Size(224, 26);
            this.mnuqlkhdt.Text = "Kế hoạch đào tạo";
            this.mnuqlkhdt.Click += new System.EventHandler(this.mnuqlkhdt_Click);
            // 
            // mnuqlk
            // 
            this.mnuqlk.Name = "mnuqlk";
            this.mnuqlk.Size = new System.Drawing.Size(224, 26);
            this.mnuqlk.Text = "Khoa";
            this.mnuqlk.Click += new System.EventHandler(this.mnuqlk_Click);
            // 
            // mnuqlkhoahoc
            // 
            this.mnuqlkhoahoc.Name = "mnuqlkhoahoc";
            this.mnuqlkhoahoc.Size = new System.Drawing.Size(224, 26);
            this.mnuqlkhoahoc.Text = "Khóa học";
            this.mnuqlkhoahoc.Click += new System.EventHandler(this.mnuqlkhoahoc_Click);
            // 
            // mnuqllop
            // 
            this.mnuqllop.Name = "mnuqllop";
            this.mnuqllop.Size = new System.Drawing.Size(224, 26);
            this.mnuqllop.Text = "Lớp";
            this.mnuqllop.Click += new System.EventHandler(this.mnuqllop_Click);
            // 
            // mnuqln
            // 
            this.mnuqln.Name = "mnuqln";
            this.mnuqln.Size = new System.Drawing.Size(224, 26);
            this.mnuqln.Text = "Ngành";
            this.mnuqln.Click += new System.EventHandler(this.mnuqln_Click);
            // 
            // mnuqlnhomhp
            // 
            this.mnuqlnhomhp.Name = "mnuqlnhomhp";
            this.mnuqlnhomhp.Size = new System.Drawing.Size(224, 26);
            this.mnuqlnhomhp.Text = "Nhóm hoc phần";
            this.mnuqlnhomhp.Click += new System.EventHandler(this.mnuqlnhomhp_Click);
            // 
            // mnuqlsv
            // 
            this.mnuqlsv.Name = "mnuqlsv";
            this.mnuqlsv.Size = new System.Drawing.Size(224, 26);
            this.mnuqlsv.Text = "Sinh viên";
            this.mnuqlsv.Click += new System.EventHandler(this.mnuqlsv_Click);
            // 
            // mnuqltaikhoan
            // 
            this.mnuqltaikhoan.Name = "mnuqltaikhoan";
            this.mnuqltaikhoan.Size = new System.Drawing.Size(224, 26);
            this.mnuqltaikhoan.Text = "Tài khoản";
            this.mnuqltaikhoan.Click += new System.EventHandler(this.mnuqltaikhoan_Click);
            // 
            // mnutk
            // 
            this.mnutk.Name = "mnutk";
            this.mnutk.Size = new System.Drawing.Size(84, 111);
            this.mnutk.Text = "Thống kê";
            // 
            // mnuht
            // 
            this.mnuht.Name = "mnuht";
            this.mnuht.Size = new System.Drawing.Size(66, 111);
            this.mnuht.Text = "Hỗ trợ";
            this.mnuht.Click += new System.EventHandler(this.mnuht_Click);
            // 
            // mnund
            // 
            this.mnund.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnundtk,
            this.mnunddoimk,
            this.mnunddx,
            this.mnundthoat});
            this.mnund.Name = "mnund";
            this.mnund.Size = new System.Drawing.Size(103, 111);
            this.mnund.Text = "Người dùng";
            // 
            // mnundtk
            // 
            this.mnundtk.Name = "mnundtk";
            this.mnundtk.Size = new System.Drawing.Size(224, 26);
            this.mnundtk.Text = "Tài khoản";
            this.mnundtk.Click += new System.EventHandler(this.mnundtk_Click);
            // 
            // mnunddx
            // 
            this.mnunddx.Name = "mnunddx";
            this.mnunddx.Size = new System.Drawing.Size(224, 26);
            this.mnunddx.Text = "Đăng xuất";
            this.mnunddx.Click += new System.EventHandler(this.mnunddx_Click);
            // 
            // mnundthoat
            // 
            this.mnundthoat.Name = "mnundthoat";
            this.mnundthoat.Size = new System.Drawing.Size(224, 26);
            this.mnundthoat.Text = "Thoát";
            this.mnundthoat.Click += new System.EventHandler(this.mnundthoat_Click);
            // 
            // mnunddoimk
            // 
            this.mnunddoimk.Name = "mnunddoimk";
            this.mnunddoimk.Size = new System.Drawing.Size(224, 26);
            this.mnunddoimk.Text = "Đổi mật khẩu";
            this.mnunddoimk.Click += new System.EventHandler(this.mnunddoimk_Click);
            // 
            // frmtrangchuqt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlform);
            this.Name = "frmtrangchuqt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chu Quan Tri";
            this.panel3.ResumeLayout(false);
            this.mnuquantri.ResumeLayout(false);
            this.mnuquantri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlform;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip mnuquantri;
        private System.Windows.Forms.ToolStripMenuItem mnuql;
        private System.Windows.Forms.ToolStripMenuItem mnutk;
        private System.Windows.Forms.ToolStripMenuItem mnuht;
        private System.Windows.Forms.ToolStripMenuItem mnuqlk;
        private System.Windows.Forms.ToolStripMenuItem mnuqln;
        private System.Windows.Forms.ToolStripMenuItem mnuqlhp;
        private System.Windows.Forms.ToolStripMenuItem mnuqllop;
        private System.Windows.Forms.ToolStripMenuItem mnuqlkhoahoc;
        private System.Windows.Forms.ToolStripMenuItem mnuqlgv;
        private System.Windows.Forms.ToolStripMenuItem mnuqlsv;
        private System.Windows.Forms.ToolStripMenuItem mnuqldiem;
        private System.Windows.Forms.ToolStripMenuItem mnutc;
        private System.Windows.Forms.ToolStripMenuItem mnuqltaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnund;
        private System.Windows.Forms.ToolStripMenuItem mnundtk;
        private System.Windows.Forms.ToolStripMenuItem mnunddx;
        private System.Windows.Forms.ToolStripMenuItem mnuqlkhdt;
        private System.Windows.Forms.ToolStripMenuItem mnuqlnhomhp;
        private System.Windows.Forms.ToolStripMenuItem mnundthoat;
        private System.Windows.Forms.ToolStripMenuItem mnunddoimk;
    }
}

