namespace Thi_KTHP
{
    partial class frmhocphansv
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
            this.dgvmainqlhp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbonganh = new System.Windows.Forms.ComboBox();
            this.cbokhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmainqlhp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvmainqlhp
            // 
            this.dgvmainqlhp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmainqlhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmainqlhp.Location = new System.Drawing.Point(0, 182);
            this.dgvmainqlhp.Name = "dgvmainqlhp";
            this.dgvmainqlhp.RowHeadersVisible = false;
            this.dgvmainqlhp.RowHeadersWidth = 51;
            this.dgvmainqlhp.RowTemplate.Height = 24;
            this.dgvmainqlhp.Size = new System.Drawing.Size(800, 268);
            this.dgvmainqlhp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbonganh);
            this.panel1.Controls.Add(this.cbokhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 125);
            this.panel1.TabIndex = 2;
            // 
            // cbonganh
            // 
            this.cbonganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonganh.FormattingEnabled = true;
            this.cbonganh.Location = new System.Drawing.Point(155, 69);
            this.cbonganh.Name = "cbonganh";
            this.cbonganh.Size = new System.Drawing.Size(121, 24);
            this.cbonganh.TabIndex = 3;
            this.cbonganh.SelectedIndexChanged += new System.EventHandler(this.cbonganh_SelectedIndexChanged);
            // 
            // cbokhoa
            // 
            this.cbokhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbokhoa.FormattingEnabled = true;
            this.cbokhoa.Items.AddRange(new object[] {
            "--"});
            this.cbokhoa.Location = new System.Drawing.Point(155, 22);
            this.cbokhoa.Name = "cbokhoa";
            this.cbokhoa.Size = new System.Drawing.Size(121, 24);
            this.cbokhoa.TabIndex = 2;
            this.cbokhoa.SelectedIndexChanged += new System.EventHandler(this.cbokhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // frmhocphansv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvmainqlhp);
            this.Name = "frmhocphansv";
            this.Text = "Hocphansv";
            this.Load += new System.EventHandler(this.Hocphansv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmainqlhp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmainqlhp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbonganh;
        private System.Windows.Forms.ComboBox cbokhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}