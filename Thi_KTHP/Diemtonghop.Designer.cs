namespace Thi_KTHP
{
    partial class frmdiemtonghop
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
            this.dgvdiemth = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdiemth
            // 
            this.dgvdiemth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdiemth.Location = new System.Drawing.Point(0, 100);
            this.dgvdiemth.Name = "dgvdiemth";
            this.dgvdiemth.RowHeadersWidth = 51;
            this.dgvdiemth.RowTemplate.Height = 24;
            this.dgvdiemth.Size = new System.Drawing.Size(800, 350);
            this.dgvdiemth.TabIndex = 0;
            // 
            // frmdiemtonghop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvdiemth);
            this.Name = "frmdiemtonghop";
            this.Text = "Diemtonghop";
            this.Load += new System.EventHandler(this.frmdiemtonghop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdiemth;
    }
}