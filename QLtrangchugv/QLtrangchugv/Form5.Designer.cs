namespace QLtrangchugv
{
    partial class frmqldiemsv
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
            dgvdiem = new DataGridView();
            cbbkhoahoc = new ComboBox();
            cbblop = new ComboBox();
            cbbmasv = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtchuyencan = new TextBox();
            txtthaoluan = new TextBox();
            txtketthuc = new TextBox();
            txtthuchanh = new TextBox();
            txtgiuaki = new TextBox();
            btnsua = new Button();
            btnluu = new Button();
            lblmasv = new Label();
            lbltongket = new Label();
            lbldiemchu = new Label();
            cbbluachon = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvdiem).BeginInit();
            SuspendLayout();
            // 
            // dgvdiem
            // 
            dgvdiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdiem.Location = new Point(10, 164);
            dgvdiem.Margin = new Padding(3, 2, 3, 2);
            dgvdiem.Name = "dgvdiem";
            dgvdiem.RowHeadersWidth = 51;
            dgvdiem.RowTemplate.Height = 29;
            dgvdiem.Size = new Size(932, 136);
            dgvdiem.TabIndex = 0;
            dgvdiem.CellContentClick += dgvdiem_CellContentClick;
            // 
            // cbbkhoahoc
            // 
            cbbkhoahoc.FormattingEnabled = true;
            cbbkhoahoc.Location = new Point(66, 9);
            cbbkhoahoc.Margin = new Padding(3, 2, 3, 2);
            cbbkhoahoc.Name = "cbbkhoahoc";
            cbbkhoahoc.Size = new Size(133, 23);
            cbbkhoahoc.TabIndex = 1;
            cbbkhoahoc.SelectedIndexChanged += cbbkhoahoc_SelectedIndexChanged;
            // 
            // cbblop
            // 
            cbblop.FormattingEnabled = true;
            cbblop.Location = new Point(292, 9);
            cbblop.Margin = new Padding(3, 2, 3, 2);
            cbblop.Name = "cbblop";
            cbblop.Size = new Size(133, 23);
            cbblop.TabIndex = 2;
            cbblop.SelectedIndexChanged += cbblop_SelectedIndexChanged;
            // 
            // cbbmasv
            // 
            cbbmasv.FormattingEnabled = true;
            cbbmasv.Location = new Point(555, 9);
            cbbmasv.Margin = new Padding(3, 2, 3, 2);
            cbbmasv.Name = "cbbmasv";
            cbbmasv.Size = new Size(133, 23);
            cbbmasv.TabIndex = 3;
            cbbmasv.SelectedIndexChanged += cbbmasv_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Kỳ Học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 11);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 11);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 63);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Mã sinh viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 92);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Chuyên cần";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 125);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 9;
            label6.Text = "KT giữa kì";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 92);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 10;
            label7.Text = "Thực hành";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 63);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 11;
            label8.Text = "Thi kết thúc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 125);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 12;
            label9.Text = "Thảo luận";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(487, 92);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 13;
            label10.Text = "Tổng kết HP:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(487, 125);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 14;
            label11.Text = "Điểm chữ:";
            // 
            // txtchuyencan
            // 
            txtchuyencan.Enabled = false;
            txtchuyencan.Location = new Point(89, 89);
            txtchuyencan.Margin = new Padding(3, 2, 3, 2);
            txtchuyencan.Name = "txtchuyencan";
            txtchuyencan.Size = new Size(110, 23);
            txtchuyencan.TabIndex = 17;
            // 
            // txtthaoluan
            // 
            txtthaoluan.Enabled = false;
            txtthaoluan.Location = new Point(324, 122);
            txtthaoluan.Margin = new Padding(3, 2, 3, 2);
            txtthaoluan.Name = "txtthaoluan";
            txtthaoluan.Size = new Size(110, 23);
            txtthaoluan.TabIndex = 18;
            // 
            // txtketthuc
            // 
            txtketthuc.Enabled = false;
            txtketthuc.Location = new Point(562, 60);
            txtketthuc.Margin = new Padding(3, 2, 3, 2);
            txtketthuc.Name = "txtketthuc";
            txtketthuc.Size = new Size(110, 23);
            txtketthuc.TabIndex = 19;
            // 
            // txtthuchanh
            // 
            txtthuchanh.Enabled = false;
            txtthuchanh.Location = new Point(324, 89);
            txtthuchanh.Margin = new Padding(3, 2, 3, 2);
            txtthuchanh.Name = "txtthuchanh";
            txtthuchanh.Size = new Size(110, 23);
            txtthuchanh.TabIndex = 22;
            // 
            // txtgiuaki
            // 
            txtgiuaki.Enabled = false;
            txtgiuaki.Location = new Point(89, 123);
            txtgiuaki.Margin = new Padding(3, 2, 3, 2);
            txtgiuaki.Name = "txtgiuaki";
            txtgiuaki.Size = new Size(110, 23);
            txtgiuaki.TabIndex = 23;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(766, 63);
            btnsua.Margin = new Padding(3, 2, 3, 2);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(82, 22);
            btnsua.TabIndex = 25;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnluu
            // 
            btnluu.Enabled = false;
            btnluu.Location = new Point(766, 108);
            btnluu.Margin = new Padding(3, 2, 3, 2);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(82, 22);
            btnluu.TabIndex = 26;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // lblmasv
            // 
            lblmasv.AutoSize = true;
            lblmasv.Location = new Point(89, 63);
            lblmasv.Name = "lblmasv";
            lblmasv.Size = new Size(16, 15);
            lblmasv.TabIndex = 27;
            lblmasv.Text = "...";
            // 
            // lbltongket
            // 
            lbltongket.AutoSize = true;
            lbltongket.Location = new Point(568, 92);
            lbltongket.Name = "lbltongket";
            lbltongket.Size = new Size(16, 15);
            lbltongket.TabIndex = 28;
            lbltongket.Text = "...";
            // 
            // lbldiemchu
            // 
            lbldiemchu.AutoSize = true;
            lbldiemchu.Location = new Point(568, 126);
            lbldiemchu.Name = "lbldiemchu";
            lbldiemchu.Size = new Size(16, 15);
            lbldiemchu.TabIndex = 29;
            lbldiemchu.Text = "...";
            // 
            // cbbluachon
            // 
            cbbluachon.Enabled = false;
            cbbluachon.FormattingEnabled = true;
            cbbluachon.Items.AddRange(new object[] { "(--)", "Thực hành", "Thảo luận" });
            cbbluachon.Location = new Point(313, 60);
            cbbluachon.Name = "cbbluachon";
            cbbluachon.Size = new Size(121, 23);
            cbbluachon.TabIndex = 30;
            cbbluachon.SelectedIndexChanged += cbbluachon_SelectedIndexChanged;
            // 
            // frmqldiemsv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 308);
            Controls.Add(cbbluachon);
            Controls.Add(lbldiemchu);
            Controls.Add(lbltongket);
            Controls.Add(lblmasv);
            Controls.Add(btnluu);
            Controls.Add(btnsua);
            Controls.Add(txtgiuaki);
            Controls.Add(txtthuchanh);
            Controls.Add(txtketthuc);
            Controls.Add(txtthaoluan);
            Controls.Add(txtchuyencan);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbmasv);
            Controls.Add(cbblop);
            Controls.Add(cbbkhoahoc);
            Controls.Add(dgvdiem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmqldiemsv";
            Text = "Form5";
            Load += frmqldiemsv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdiem;
        private ComboBox cbbkhoahoc;
        private ComboBox cbblop;
        private ComboBox cbbmasv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtchuyencan;
        private TextBox txtthaoluan;
        private TextBox txtketthuc;
        private TextBox txtthuchanh;
        private TextBox txtgiuaki;
        private Button btnsua;
        private Button btnluu;
        private Label lblmasv;
        private Label lbltongket;
        private Label lbldiemchu;
        private ComboBox cbbluachon;
    }
}