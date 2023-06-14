namespace QLtrangchugv
{
    partial class frmqlsinhvien
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
            dgvqlsv = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtmasv = new TextBox();
            txthoten = new TextBox();
            txtquenquan = new TextBox();
            txtnoisinh = new TextBox();
            txtgioitinh = new TextBox();
            dtpngaysinh = new DateTimePicker();
            cbbtenlop = new ComboBox();
            cbbmasv = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvqlsv).BeginInit();
            SuspendLayout();
            // 
            // dgvqlsv
            // 
            dgvqlsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvqlsv.Location = new Point(347, 75);
            dgvqlsv.Margin = new Padding(3, 2, 3, 2);
            dgvqlsv.Name = "dgvqlsv";
            dgvqlsv.RowHeadersWidth = 51;
            dgvqlsv.RowTemplate.Height = 29;
            dgvqlsv.Size = new Size(595, 224);
            dgvqlsv.TabIndex = 0;
            dgvqlsv.CellContentClick += dgvqlsv_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Quên quán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 140);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 4;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 188);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Nơi sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 238);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 6;
            label6.Text = "GIới tính:";
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(108, 21);
            txtmasv.Margin = new Padding(3, 2, 3, 2);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(110, 23);
            txtmasv.TabIndex = 8;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(108, 58);
            txthoten.Margin = new Padding(3, 2, 3, 2);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(110, 23);
            txthoten.TabIndex = 9;
            // 
            // txtquenquan
            // 
            txtquenquan.Location = new Point(108, 100);
            txtquenquan.Margin = new Padding(3, 2, 3, 2);
            txtquenquan.Name = "txtquenquan";
            txtquenquan.Size = new Size(110, 23);
            txtquenquan.TabIndex = 10;
            // 
            // txtnoisinh
            // 
            txtnoisinh.Location = new Point(108, 185);
            txtnoisinh.Margin = new Padding(3, 2, 3, 2);
            txtnoisinh.Name = "txtnoisinh";
            txtnoisinh.Size = new Size(110, 23);
            txtnoisinh.TabIndex = 11;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(108, 232);
            txtgioitinh.Margin = new Padding(3, 2, 3, 2);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(110, 23);
            txtgioitinh.TabIndex = 12;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(108, 140);
            dtpngaysinh.Margin = new Padding(3, 2, 3, 2);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(219, 23);
            dtpngaysinh.TabIndex = 15;
            // 
            // cbbtenlop
            // 
            cbbtenlop.FormattingEnabled = true;
            cbbtenlop.Location = new Point(435, 20);
            cbbtenlop.Margin = new Padding(3, 2, 3, 2);
            cbbtenlop.Name = "cbbtenlop";
            cbbtenlop.Size = new Size(133, 23);
            cbbtenlop.TabIndex = 16;
            cbbtenlop.SelectedIndexChanged += cbbtenlop_SelectedIndexChanged;
            // 
            // cbbmasv
            // 
            cbbmasv.FormattingEnabled = true;
            cbbmasv.Location = new Point(732, 21);
            cbbmasv.Margin = new Padding(3, 2, 3, 2);
            cbbmasv.Name = "cbbmasv";
            cbbmasv.Size = new Size(133, 23);
            cbbmasv.TabIndex = 17;
            cbbmasv.SelectedIndexChanged += cbbmasv_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 23);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 18;
            label7.Text = "Tên lớp:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(645, 22);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 19;
            label8.Text = "Mã sinh viên:";
            // 
            // frmqlsinhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 308);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbbmasv);
            Controls.Add(cbbtenlop);
            Controls.Add(dtpngaysinh);
            Controls.Add(txtgioitinh);
            Controls.Add(txtnoisinh);
            Controls.Add(txtquenquan);
            Controls.Add(txthoten);
            Controls.Add(txtmasv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvqlsv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmqlsinhvien";
            Text = "Form3";
            Load += frmqlsinhvien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvqlsv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvqlsv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmasv;
        private TextBox txthoten;
        private TextBox txtquenquan;
        private TextBox txtnoisinh;
        private TextBox txtgioitinh;
        private DateTimePicker dtpngaysinh;
        private ComboBox cbbtenlop;
        private ComboBox cbbmasv;
        private Label label7;
        private Label label8;
    }
}