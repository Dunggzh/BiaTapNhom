namespace Thi_KTHP
{
    partial class QuanLyDiem_gv
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
            this.txtgiuaki_qldsv = new System.Windows.Forms.TextBox();
            this.txtchuyencan_qldcsv = new System.Windows.Forms.TextBox();
            this.cbbkyhoc_qldsv = new System.Windows.Forms.ComboBox();
            this.lblmasv_qldsv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbluachon_qldsv = new System.Windows.Forms.ComboBox();
            this.txtthiketthuc_qldsv = new System.Windows.Forms.TextBox();
            this.txtthaoluan_qldsv = new System.Windows.Forms.TextBox();
            this.txtthuchanh_qldsv = new System.Windows.Forms.TextBox();
            this.cbbmasv_qldsv = new System.Windows.Forms.ComboBox();
            this.cbblop_qldsv = new System.Windows.Forms.ComboBox();
            this.btnluu_qldsv = new System.Windows.Forms.Button();
            this.btnsua_qldsv = new System.Windows.Forms.Button();
            this.lbldiemchu_qldsv = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltongketHP_qldsv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_qldsv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanhomhp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qldsv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgiuaki_qldsv
            // 
            this.txtgiuaki_qldsv.Enabled = false;
            this.txtgiuaki_qldsv.Location = new System.Drawing.Point(128, 171);
            this.txtgiuaki_qldsv.Name = "txtgiuaki_qldsv";
            this.txtgiuaki_qldsv.Size = new System.Drawing.Size(100, 22);
            this.txtgiuaki_qldsv.TabIndex = 30;
            // 
            // txtchuyencan_qldcsv
            // 
            this.txtchuyencan_qldcsv.Enabled = false;
            this.txtchuyencan_qldcsv.Location = new System.Drawing.Point(125, 120);
            this.txtchuyencan_qldcsv.Name = "txtchuyencan_qldcsv";
            this.txtchuyencan_qldcsv.Size = new System.Drawing.Size(100, 22);
            this.txtchuyencan_qldcsv.TabIndex = 29;
            // 
            // cbbkyhoc_qldsv
            // 
            this.cbbkyhoc_qldsv.FormattingEnabled = true;
            this.cbbkyhoc_qldsv.Location = new System.Drawing.Point(82, 19);
            this.cbbkyhoc_qldsv.Name = "cbbkyhoc_qldsv";
            this.cbbkyhoc_qldsv.Size = new System.Drawing.Size(121, 24);
            this.cbbkyhoc_qldsv.TabIndex = 28;
            this.cbbkyhoc_qldsv.SelectedIndexChanged += new System.EventHandler(this.cbbkyhoc_qldsv_SelectedIndexChanged);
            // 
            // lblmasv_qldsv
            // 
            this.lblmasv_qldsv.AutoSize = true;
            this.lblmasv_qldsv.Location = new System.Drawing.Point(125, 78);
            this.lblmasv_qldsv.Name = "lblmasv_qldsv";
            this.lblmasv_qldsv.Size = new System.Drawing.Size(16, 16);
            this.lblmasv_qldsv.TabIndex = 27;
            this.lblmasv_qldsv.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "KT giữa kì:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chuyên cần:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kỳ học:";
            // 
            // cbbluachon_qldsv
            // 
            this.cbbluachon_qldsv.Enabled = false;
            this.cbbluachon_qldsv.FormattingEnabled = true;
            this.cbbluachon_qldsv.Items.AddRange(new object[] {
            "(---)",
            "Thực hành",
            "Thảo luận"});
            this.cbbluachon_qldsv.Location = new System.Drawing.Point(434, 78);
            this.cbbluachon_qldsv.Name = "cbbluachon_qldsv";
            this.cbbluachon_qldsv.Size = new System.Drawing.Size(121, 24);
            this.cbbluachon_qldsv.TabIndex = 47;
            this.cbbluachon_qldsv.SelectedIndexChanged += new System.EventHandler(this.cbbluachon_qldsv_SelectedIndexChanged);
            // 
            // txtthiketthuc_qldsv
            // 
            this.txtthiketthuc_qldsv.Enabled = false;
            this.txtthiketthuc_qldsv.Location = new System.Drawing.Point(682, 78);
            this.txtthiketthuc_qldsv.Name = "txtthiketthuc_qldsv";
            this.txtthiketthuc_qldsv.Size = new System.Drawing.Size(100, 22);
            this.txtthiketthuc_qldsv.TabIndex = 46;
            // 
            // txtthaoluan_qldsv
            // 
            this.txtthaoluan_qldsv.Enabled = false;
            this.txtthaoluan_qldsv.Location = new System.Drawing.Point(434, 171);
            this.txtthaoluan_qldsv.Name = "txtthaoluan_qldsv";
            this.txtthaoluan_qldsv.Size = new System.Drawing.Size(100, 22);
            this.txtthaoluan_qldsv.TabIndex = 45;
            // 
            // txtthuchanh_qldsv
            // 
            this.txtthuchanh_qldsv.Enabled = false;
            this.txtthuchanh_qldsv.Location = new System.Drawing.Point(436, 123);
            this.txtthuchanh_qldsv.Name = "txtthuchanh_qldsv";
            this.txtthuchanh_qldsv.Size = new System.Drawing.Size(100, 22);
            this.txtthuchanh_qldsv.TabIndex = 44;
            // 
            // cbbmasv_qldsv
            // 
            this.cbbmasv_qldsv.FormattingEnabled = true;
            this.cbbmasv_qldsv.Location = new System.Drawing.Point(719, 22);
            this.cbbmasv_qldsv.Name = "cbbmasv_qldsv";
            this.cbbmasv_qldsv.Size = new System.Drawing.Size(121, 24);
            this.cbbmasv_qldsv.TabIndex = 43;
            this.cbbmasv_qldsv.SelectedIndexChanged += new System.EventHandler(this.cbbmasv_qldsv_SelectedIndexChanged);
            // 
            // cbblop_qldsv
            // 
            this.cbblop_qldsv.FormattingEnabled = true;
            this.cbblop_qldsv.Location = new System.Drawing.Point(376, 22);
            this.cbblop_qldsv.Name = "cbblop_qldsv";
            this.cbblop_qldsv.Size = new System.Drawing.Size(121, 24);
            this.cbblop_qldsv.TabIndex = 42;
            this.cbblop_qldsv.SelectedIndexChanged += new System.EventHandler(this.cbblop_qldsv_SelectedIndexChanged);
            // 
            // btnluu_qldsv
            // 
            this.btnluu_qldsv.Enabled = false;
            this.btnluu_qldsv.Location = new System.Drawing.Point(917, 167);
            this.btnluu_qldsv.Name = "btnluu_qldsv";
            this.btnluu_qldsv.Size = new System.Drawing.Size(75, 23);
            this.btnluu_qldsv.TabIndex = 41;
            this.btnluu_qldsv.Text = "Lưu";
            this.btnluu_qldsv.UseVisualStyleBackColor = true;
            this.btnluu_qldsv.Click += new System.EventHandler(this.btnluu_qldsv_Click);
            // 
            // btnsua_qldsv
            // 
            this.btnsua_qldsv.Location = new System.Drawing.Point(917, 119);
            this.btnsua_qldsv.Name = "btnsua_qldsv";
            this.btnsua_qldsv.Size = new System.Drawing.Size(75, 23);
            this.btnsua_qldsv.TabIndex = 40;
            this.btnsua_qldsv.Text = "Sửa";
            this.btnsua_qldsv.UseVisualStyleBackColor = true;
            this.btnsua_qldsv.Click += new System.EventHandler(this.btnsua_qldsv_Click);
            // 
            // lbldiemchu_qldsv
            // 
            this.lbldiemchu_qldsv.AutoSize = true;
            this.lbldiemchu_qldsv.Location = new System.Drawing.Point(690, 174);
            this.lbldiemchu_qldsv.Name = "lbldiemchu_qldsv";
            this.lbldiemchu_qldsv.Size = new System.Drawing.Size(16, 16);
            this.lbldiemchu_qldsv.TabIndex = 39;
            this.lbldiemchu_qldsv.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(599, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Điểm chữ:";
            // 
            // lbltongketHP_qldsv
            // 
            this.lbltongketHP_qldsv.AutoSize = true;
            this.lbltongketHP_qldsv.Location = new System.Drawing.Point(690, 129);
            this.lbltongketHP_qldsv.Name = "lbltongketHP_qldsv";
            this.lbltongketHP_qldsv.Size = new System.Drawing.Size(16, 16);
            this.lbltongketHP_qldsv.TabIndex = 37;
            this.lbltongketHP_qldsv.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(599, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tổng kết HP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Thi kêt thúc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã sinh viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Thảo luận:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Thực hành:";
            // 
            // dgv_qldsv
            // 
            this.dgv_qldsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_qldsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qldsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qldsv.Location = new System.Drawing.Point(12, 274);
            this.dgv_qldsv.Name = "dgv_qldsv";
            this.dgv_qldsv.RowHeadersWidth = 51;
            this.dgv_qldsv.RowTemplate.Height = 24;
            this.dgv_qldsv.Size = new System.Drawing.Size(1018, 189);
            this.dgv_qldsv.TabIndex = 48;
            this.dgv_qldsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qldsv_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Mã Nhóm HP";
            // 
            // txtmanhomhp
            // 
            this.txtmanhomhp.Enabled = false;
            this.txtmanhomhp.Location = new System.Drawing.Point(128, 208);
            this.txtmanhomhp.Name = "txtmanhomhp";
            this.txtmanhomhp.Size = new System.Drawing.Size(100, 22);
            this.txtmanhomhp.TabIndex = 30;
            // 
            // QuanLyDiem_gv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1042, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_qldsv);
            this.Controls.Add(this.cbbluachon_qldsv);
            this.Controls.Add(this.txtthiketthuc_qldsv);
            this.Controls.Add(this.txtthaoluan_qldsv);
            this.Controls.Add(this.txtthuchanh_qldsv);
            this.Controls.Add(this.cbbmasv_qldsv);
            this.Controls.Add(this.cbblop_qldsv);
            this.Controls.Add(this.btnluu_qldsv);
            this.Controls.Add(this.btnsua_qldsv);
            this.Controls.Add(this.lbldiemchu_qldsv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbltongketHP_qldsv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmanhomhp);
            this.Controls.Add(this.txtgiuaki_qldsv);
            this.Controls.Add(this.txtchuyencan_qldcsv);
            this.Controls.Add(this.cbbkyhoc_qldsv);
            this.Controls.Add(this.lblmasv_qldsv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDiem_gv";
            this.Text = "QuanLyDiem_gv";
            this.Load += new System.EventHandler(this.QuanLyDiem_gv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qldsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgiuaki_qldsv;
        private System.Windows.Forms.TextBox txtchuyencan_qldcsv;
        private System.Windows.Forms.ComboBox cbbkyhoc_qldsv;
        private System.Windows.Forms.Label lblmasv_qldsv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbluachon_qldsv;
        private System.Windows.Forms.TextBox txtthiketthuc_qldsv;
        private System.Windows.Forms.TextBox txtthaoluan_qldsv;
        private System.Windows.Forms.TextBox txtthuchanh_qldsv;
        private System.Windows.Forms.ComboBox cbbmasv_qldsv;
        private System.Windows.Forms.ComboBox cbblop_qldsv;
        private System.Windows.Forms.Button btnluu_qldsv;
        private System.Windows.Forms.Button btnsua_qldsv;
        private System.Windows.Forms.Label lbldiemchu_qldsv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltongketHP_qldsv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_qldsv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanhomhp;
    }
}