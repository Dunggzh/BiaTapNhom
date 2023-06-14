namespace Thi_KTHP
{
    partial class frmthongtinhp
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
            this.dgvqlhp = new System.Windows.Forms.DataGridView();
            this.txttenhp = new System.Windows.Forms.TextBox();
            this.txtmahp = new System.Windows.Forms.TextBox();
            this.txtsotc = new System.Windows.Forms.TextBox();
            this.txtsotiet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlhp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Tiết";
            // 
            // dgvqlhp
            // 
            this.dgvqlhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlhp.Location = new System.Drawing.Point(333, 65);
            this.dgvqlhp.Name = "dgvqlhp";
            this.dgvqlhp.RowHeadersWidth = 51;
            this.dgvqlhp.RowTemplate.Height = 24;
            this.dgvqlhp.Size = new System.Drawing.Size(434, 322);
            this.dgvqlhp.TabIndex = 1;
            // 
            // txttenhp
            // 
            this.txttenhp.Location = new System.Drawing.Point(193, 102);
            this.txttenhp.Name = "txttenhp";
            this.txttenhp.Size = new System.Drawing.Size(100, 22);
            this.txttenhp.TabIndex = 2;
            // 
            // txtmahp
            // 
            this.txtmahp.Location = new System.Drawing.Point(193, 157);
            this.txtmahp.Name = "txtmahp";
            this.txtmahp.Size = new System.Drawing.Size(100, 22);
            this.txtmahp.TabIndex = 3;
            // 
            // txtsotc
            // 
            this.txtsotc.Location = new System.Drawing.Point(193, 240);
            this.txtsotc.Name = "txtsotc";
            this.txtsotc.Size = new System.Drawing.Size(100, 22);
            this.txtsotc.TabIndex = 4;
            // 
            // txtsotiet
            // 
            this.txtsotiet.Location = new System.Drawing.Point(193, 325);
            this.txtsotiet.Name = "txtsotiet";
            this.txtsotiet.Size = new System.Drawing.Size(100, 22);
            this.txtsotiet.TabIndex = 5;
            // 
            // frmthongtinhp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsotiet);
            this.Controls.Add(this.txtsotc);
            this.Controls.Add(this.txtmahp);
            this.Controls.Add(this.txttenhp);
            this.Controls.Add(this.dgvqlhp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmthongtinhp";
            this.Text = "thongtinhocphan";
            this.Load += new System.EventHandler(this.frmthongtinhp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlhp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvqlhp;
        private System.Windows.Forms.TextBox txttenhp;
        private System.Windows.Forms.TextBox txtmahp;
        private System.Windows.Forms.TextBox txtsotc;
        private System.Windows.Forms.TextBox txtsotiet;
    }
}