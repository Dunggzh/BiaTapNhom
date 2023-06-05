namespace Thi_KTHP
{
    partial class frmtrangchusv
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
            this.mnusinhvien = new System.Windows.Forms.MenuStrip();
            this.mnutrangchusv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrangchuql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhocphan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrangchutk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrangchuht = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutrangchund = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlform = new System.Windows.Forms.Panel();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudoimk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuchinhsua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusinhvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusinhvien
            // 
            this.mnusinhvien.AutoSize = false;
            this.mnusinhvien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnusinhvien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnusinhvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutrangchusv,
            this.mnutrangchuql,
            this.mnutrangchutk,
            this.mnutrangchuht,
            this.mnutrangchund});
            this.mnusinhvien.Location = new System.Drawing.Point(0, 0);
            this.mnusinhvien.Name = "mnusinhvien";
            this.mnusinhvien.Size = new System.Drawing.Size(819, 87);
            this.mnusinhvien.TabIndex = 1;
            this.mnusinhvien.Text = "menuStrip1";
            // 
            // mnutrangchusv
            // 
            this.mnutrangchusv.Name = "mnutrangchusv";
            this.mnutrangchusv.Size = new System.Drawing.Size(87, 83);
            this.mnutrangchusv.Text = "Trang chủ";
            // 
            // mnutrangchuql
            // 
            this.mnutrangchuql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhocphan,
            this.mnudiem});
            this.mnutrangchuql.Name = "mnutrangchuql";
            this.mnutrangchuql.Size = new System.Drawing.Size(73, 83);
            this.mnutrangchuql.Text = "Quản lý";
            // 
            // mnuhocphan
            // 
            this.mnuhocphan.Name = "mnuhocphan";
            this.mnuhocphan.Size = new System.Drawing.Size(224, 26);
            this.mnuhocphan.Text = "Học phần";
            this.mnuhocphan.Click += new System.EventHandler(this.mnuhocphan_Click);
            // 
            // mnutrangchutk
            // 
            this.mnutrangchutk.Name = "mnutrangchutk";
            this.mnutrangchutk.Size = new System.Drawing.Size(84, 83);
            this.mnutrangchutk.Text = "Thống kê";
            // 
            // mnutrangchuht
            // 
            this.mnutrangchuht.Name = "mnutrangchuht";
            this.mnutrangchuht.Size = new System.Drawing.Size(66, 83);
            this.mnutrangchuht.Text = "Hỗ trợ";
            // 
            // mnutrangchund
            // 
            this.mnutrangchund.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuthongtin,
            this.mnudangxuat,
            this.mnuthoat});
            this.mnutrangchund.Name = "mnutrangchund";
            this.mnutrangchund.Size = new System.Drawing.Size(103, 83);
            this.mnutrangchund.Text = "Người dùng";
            // 
            // mnuthongtin
            // 
            this.mnuthongtin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuchinhsua});
            this.mnuthongtin.Name = "mnuthongtin";
            this.mnuthongtin.Size = new System.Drawing.Size(224, 26);
            this.mnuthongtin.Text = "Thông tin cá nhân";
            this.mnuthongtin.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // mnudangxuat
            // 
            this.mnudangxuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudoimk});
            this.mnudangxuat.Name = "mnudangxuat";
            this.mnudangxuat.Size = new System.Drawing.Size(224, 26);
            this.mnudangxuat.Text = "Đăng xuất";
            this.mnudangxuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // pnlform
            // 
            this.pnlform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlform.BackColor = System.Drawing.SystemColors.Control;
            this.pnlform.Location = new System.Drawing.Point(0, 164);
            this.pnlform.Name = "pnlform";
            this.pnlform.Size = new System.Drawing.Size(819, 417);
            this.pnlform.TabIndex = 2;
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(224, 26);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mnudoimk
            // 
            this.mnudoimk.Name = "mnudoimk";
            this.mnudoimk.Size = new System.Drawing.Size(224, 26);
            this.mnudoimk.Text = "Đổi mật khẩu";
            this.mnudoimk.Click += new System.EventHandler(this.mnudoimk_Click);
            // 
            // mnuchinhsua
            // 
            this.mnuchinhsua.Name = "mnuchinhsua";
            this.mnuchinhsua.Size = new System.Drawing.Size(224, 26);
            this.mnuchinhsua.Text = "Chỉnh sửa";
            this.mnuchinhsua.Click += new System.EventHandler(this.mnuchinhsua_Click);
            // 
            // mnudiem
            // 
            this.mnudiem.Name = "mnudiem";
            this.mnudiem.Size = new System.Drawing.Size(224, 26);
            this.mnudiem.Text = "Điểm";
            this.mnudiem.Click += new System.EventHandler(this.mnudiem_Click);
            // 
            // frmtrangchusv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 581);
            this.Controls.Add(this.pnlform);
            this.Controls.Add(this.mnusinhvien);
            this.Name = "frmtrangchusv";
            this.Text = "Phần mềm quản lý điểm";
            this.mnusinhvien.ResumeLayout(false);
            this.mnusinhvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusinhvien;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchusv;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchuql;
        private System.Windows.Forms.ToolStripMenuItem mnuhocphan;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchutk;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchuht;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchund;
        private System.Windows.Forms.ToolStripMenuItem mnuthongtin;
        private System.Windows.Forms.ToolStripMenuItem mnudangxuat;
        private System.Windows.Forms.Panel pnlform;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.ToolStripMenuItem mnudoimk;
        private System.Windows.Forms.ToolStripMenuItem mnuchinhsua;
        private System.Windows.Forms.ToolStripMenuItem mnudiem;
    }
}