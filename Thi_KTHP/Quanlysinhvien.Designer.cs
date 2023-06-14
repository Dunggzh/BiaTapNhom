namespace Thi_KTHP
{
    partial class frmquanlysinhvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnoisinh = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.cbbmasv = new System.Windows.Forms.ComboBox();
            this.cbbtenlop = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgvqlsv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quê quán";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nơi sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên lớp";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sinh viên";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnoisinh
            // 
            this.txtnoisinh.Location = new System.Drawing.Point(200, 325);
            this.txtnoisinh.Name = "txtnoisinh";
            this.txtnoisinh.Size = new System.Drawing.Size(100, 22);
            this.txtnoisinh.TabIndex = 1;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(200, 75);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(100, 22);
            this.txtmasv.TabIndex = 2;
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(200, 197);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(100, 22);
            this.txtquequan.TabIndex = 1;
            this.txtquequan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(200, 133);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 22);
            this.txthoten.TabIndex = 2;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(200, 389);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(100, 22);
            this.txtgioitinh.TabIndex = 1;
            // 
            // cbbmasv
            // 
            this.cbbmasv.FormattingEnabled = true;
            this.cbbmasv.Location = new System.Drawing.Point(897, 67);
            this.cbbmasv.Name = "cbbmasv";
            this.cbbmasv.Size = new System.Drawing.Size(121, 24);
            this.cbbmasv.TabIndex = 3;
            // 
            // cbbtenlop
            // 
            this.cbbtenlop.FormattingEnabled = true;
            this.cbbtenlop.Location = new System.Drawing.Point(609, 67);
            this.cbbtenlop.Name = "cbbtenlop";
            this.cbbtenlop.Size = new System.Drawing.Size(121, 24);
            this.cbbtenlop.TabIndex = 4;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(200, 261);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtpngaysinh.TabIndex = 5;
            // 
            // dgvqlsv
            // 
            this.dgvqlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlsv.Location = new System.Drawing.Point(551, 184);
            this.dgvqlsv.Name = "dgvqlsv";
            this.dgvqlsv.RowHeadersWidth = 51;
            this.dgvqlsv.RowTemplate.Height = 24;
            this.dgvqlsv.Size = new System.Drawing.Size(420, 270);
            this.dgvqlsv.TabIndex = 6;
            // 
            // frmquanlysinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 541);
            this.Controls.Add(this.dgvqlsv);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.cbbtenlop);
            this.Controls.Add(this.cbbmasv);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txtnoisinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmquanlysinhvien";
            this.Text = "Quanlysinhvien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnoisinh;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.ComboBox cbbmasv;
        private System.Windows.Forms.ComboBox cbbtenlop;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.DataGridView dgvqlsv;
    }
}