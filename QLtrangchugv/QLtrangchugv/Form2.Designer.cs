namespace QLtrangchugv
{
    partial class frmttcn
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
            label1 = new Label();
            dgvttcn = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtmagv = new TextBox();
            txttengv = new TextBox();
            txtsdt = new TextBox();
            txttrinhdo = new TextBox();
            txtmakhoa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvttcn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(374, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            label1.Click += label1_Click;
            // 
            // dgvttcn
            // 
            dgvttcn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvttcn.Location = new Point(1, 194);
            dgvttcn.Margin = new Padding(3, 2, 3, 2);
            dgvttcn.Name = "dgvttcn";
            dgvttcn.RowHeadersWidth = 51;
            dgvttcn.RowTemplate.Height = 29;
            dgvttcn.Size = new Size(910, 105);
            dgvttcn.TabIndex = 1;
            dgvttcn.CellContentClick += dgvttcn_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã gv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 96);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên giảng viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 133);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Số đt:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 59);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 5;
            label5.Text = "Trình độ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 96);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 6;
            label6.Text = "Mã khoa:";
            // 
            // txtmagv
            // 
            txtmagv.Location = new Point(198, 57);
            txtmagv.Margin = new Padding(3, 2, 3, 2);
            txtmagv.Name = "txtmagv";
            txtmagv.Size = new Size(110, 23);
            txtmagv.TabIndex = 7;
            // 
            // txttengv
            // 
            txttengv.Location = new Point(198, 96);
            txttengv.Margin = new Padding(3, 2, 3, 2);
            txttengv.Name = "txttengv";
            txttengv.Size = new Size(110, 23);
            txttengv.TabIndex = 8;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(198, 130);
            txtsdt.Margin = new Padding(3, 2, 3, 2);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(110, 23);
            txtsdt.TabIndex = 9;
            // 
            // txttrinhdo
            // 
            txttrinhdo.Location = new Point(555, 57);
            txttrinhdo.Margin = new Padding(3, 2, 3, 2);
            txttrinhdo.Name = "txttrinhdo";
            txttrinhdo.Size = new Size(110, 23);
            txttrinhdo.TabIndex = 10;
            // 
            // txtmakhoa
            // 
            txtmakhoa.Location = new Point(555, 96);
            txtmakhoa.Margin = new Padding(3, 2, 3, 2);
            txtmakhoa.Name = "txtmakhoa";
            txtmakhoa.Size = new Size(110, 23);
            txtmakhoa.TabIndex = 11;
            // 
            // frmttcn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 308);
            Controls.Add(txtmakhoa);
            Controls.Add(txttrinhdo);
            Controls.Add(txtsdt);
            Controls.Add(txttengv);
            Controls.Add(txtmagv);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvttcn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmttcn";
            Text = "Form2";
            Load += frmttcn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvttcn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvttcn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtmagv;
        private TextBox txttengv;
        private TextBox txtsdt;
        private TextBox txttrinhdo;
        private TextBox txtmakhoa;
    }
}