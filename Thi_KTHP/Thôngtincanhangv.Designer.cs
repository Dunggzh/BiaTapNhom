namespace Thi_KTHP
{
    partial class frmthongtingv
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
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttengv = new System.Windows.Forms.TextBox();
            this.txttrinhdo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvttcn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvttcn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã GV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trình độ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số đt:";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(672, 145);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(100, 22);
            this.txtmakhoa.TabIndex = 1;
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(193, 108);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(100, 22);
            this.txtmagv.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(193, 169);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 22);
            this.txtsdt.TabIndex = 1;
            // 
            // txttengv
            // 
            this.txttengv.Location = new System.Drawing.Point(193, 139);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(100, 22);
            this.txttengv.TabIndex = 1;
            // 
            // txttrinhdo
            // 
            this.txttrinhdo.Location = new System.Drawing.Point(672, 114);
            this.txttrinhdo.Name = "txttrinhdo";
            this.txttrinhdo.Size = new System.Drawing.Size(100, 22);
            this.txttrinhdo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khoa:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvttcn
            // 
            this.dgvttcn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvttcn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvttcn.Location = new System.Drawing.Point(0, 367);
            this.dgvttcn.Name = "dgvttcn";
            this.dgvttcn.RowHeadersWidth = 51;
            this.dgvttcn.RowTemplate.Height = 24;
            this.dgvttcn.Size = new System.Drawing.Size(989, 335);
            this.dgvttcn.TabIndex = 2;
            // 
            // frmthongtingv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 702);
            this.Controls.Add(this.dgvttcn);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttengv);
            this.Controls.Add(this.txttrinhdo);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmthongtingv";
            this.Text = "Thôngtincanhangv";
            this.Load += new System.EventHandler(this.frmthongtingv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvttcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttengv;
        private System.Windows.Forms.TextBox txttrinhdo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvttcn;
    }
}