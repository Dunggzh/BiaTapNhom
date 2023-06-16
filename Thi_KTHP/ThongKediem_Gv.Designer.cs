namespace Thi_KTHP
{
    partial class ThongKediem_Gv
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
            this.btnthongke = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbohocki = new System.Windows.Forms.ComboBox();
            this.cbolop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvthongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(616, 131);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(101, 41);
            this.btnthongke.TabIndex = 19;
            this.btnthongke.Text = "Thông kê";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Học Kỳ";
            // 
            // cbohocki
            // 
            this.cbohocki.FormattingEnabled = true;
            this.cbohocki.Items.AddRange(new object[] {
            "--"});
            this.cbohocki.Location = new System.Drawing.Point(553, 80);
            this.cbohocki.Name = "cbohocki";
            this.cbohocki.Size = new System.Drawing.Size(121, 24);
            this.cbohocki.TabIndex = 17;
            // 
            // cbolop
            // 
            this.cbolop.FormattingEnabled = true;
            this.cbolop.Items.AddRange(new object[] {
            "--"});
            this.cbolop.Location = new System.Drawing.Point(171, 80);
            this.cbolop.Name = "cbolop";
            this.cbolop.Size = new System.Drawing.Size(121, 24);
            this.cbolop.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lớp";
            // 
            // dgvthongke
            // 
            this.dgvthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongke.Location = new System.Drawing.Point(68, 178);
            this.dgvthongke.Name = "dgvthongke";
            this.dgvthongke.RowHeadersWidth = 51;
            this.dgvthongke.RowTemplate.Height = 24;
            this.dgvthongke.Size = new System.Drawing.Size(668, 241);
            this.dgvthongke.TabIndex = 10;
            // 
            // ThongKediem_Gv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbohocki);
            this.Controls.Add(this.cbolop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvthongke);
            this.Name = "ThongKediem_Gv";
            this.Text = "ThongKediem_Gv";
            this.Load += new System.EventHandler(this.ThongKediem_Gv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbohocki;
        private System.Windows.Forms.ComboBox cbolop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvthongke;
    }
}