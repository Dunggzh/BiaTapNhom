namespace QLtrangchugv
{
    partial class frmtthp
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
            dgvqlhp = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttenhp = new TextBox();
            txtsotiet = new TextBox();
            txtsotc = new TextBox();
            txtmahp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvqlhp).BeginInit();
            SuspendLayout();
            // 
            // dgvqlhp
            // 
            dgvqlhp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvqlhp.Location = new Point(343, 12);
            dgvqlhp.Name = "dgvqlhp";
            dgvqlhp.RowHeadersWidth = 51;
            dgvqlhp.RowTemplate.Height = 29;
            dgvqlhp.Size = new Size(734, 387);
            dgvqlhp.TabIndex = 0;
            dgvqlhp.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Số TC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "Số tiết";
            // 
            // txttenhp
            // 
            txttenhp.Location = new Point(105, 40);
            txttenhp.Name = "txttenhp";
            txttenhp.Size = new Size(125, 27);
            txttenhp.TabIndex = 5;
            // 
            // txtsotiet
            // 
            txtsotiet.Location = new Point(105, 161);
            txtsotiet.Name = "txtsotiet";
            txtsotiet.Size = new Size(125, 27);
            txtsotiet.TabIndex = 6;
            // 
            // txtsotc
            // 
            txtsotc.Location = new Point(105, 120);
            txtsotc.Name = "txtsotc";
            txtsotc.Size = new Size(125, 27);
            txtsotc.TabIndex = 7;
            // 
            // txtmahp
            // 
            txtmahp.Location = new Point(105, 80);
            txtmahp.Name = "txtmahp";
            txtmahp.Size = new Size(125, 27);
            txtmahp.TabIndex = 8;
            // 
            // frmtthp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 411);
            Controls.Add(txtmahp);
            Controls.Add(txtsotc);
            Controls.Add(txtsotiet);
            Controls.Add(txttenhp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvqlhp);
            Name = "frmtthp";
            Text = "Form4";
            Load += frmtthp_Load;
            ((System.ComponentModel.ISupportInitialize)dgvqlhp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvqlhp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttenhp;
        private TextBox txtsotiet;
        private TextBox txtsotc;
        private TextBox txtmahp;
    }
}