namespace Thi_KTHP
{
    partial class frmqthocphan
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
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemhp = new System.Windows.Forms.Button();
            this.btnqtsuahp = new System.Windows.Forms.Button();
            this.btnqtxoahp = new System.Windows.Forms.Button();
            this.btnqtghihp = new System.Windows.Forms.Button();
            this.btnqthuyhp = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboqtsotinchi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqttenhp = new System.Windows.Forms.TextBox();
            this.txtqtmahp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlqtcsdl = new System.Windows.Forms.Panel();
            this.dgvqthp = new System.Windows.Forms.DataGridView();
            this.txtqtsotiet = new System.Windows.Forms.TextBox();
            this.floqtnut.SuspendLayout();
            this.pnlqttruong.SuspendLayout();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqthp)).BeginInit();
            this.SuspendLayout();
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemhp);
            this.floqtnut.Controls.Add(this.btnqtsuahp);
            this.floqtnut.Controls.Add(this.btnqtxoahp);
            this.floqtnut.Controls.Add(this.btnqtghihp);
            this.floqtnut.Controls.Add(this.btnqthuyhp);
            this.floqtnut.Location = new System.Drawing.Point(2, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 497);
            this.floqtnut.TabIndex = 3;
            // 
            // btnqtthemhp
            // 
            this.btnqtthemhp.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemhp.Name = "btnqtthemhp";
            this.btnqtthemhp.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemhp.TabIndex = 0;
            this.btnqtthemhp.Text = "Thêm";
            this.btnqtthemhp.UseVisualStyleBackColor = true;
            this.btnqtthemhp.Click += new System.EventHandler(this.btnqtthemhp_Click);
            // 
            // btnqtsuahp
            // 
            this.btnqtsuahp.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuahp.Name = "btnqtsuahp";
            this.btnqtsuahp.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuahp.TabIndex = 1;
            this.btnqtsuahp.Text = "Sửa";
            this.btnqtsuahp.UseVisualStyleBackColor = true;
            this.btnqtsuahp.Click += new System.EventHandler(this.btnqtsuahp_Click);
            // 
            // btnqtxoahp
            // 
            this.btnqtxoahp.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoahp.Name = "btnqtxoahp";
            this.btnqtxoahp.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoahp.TabIndex = 2;
            this.btnqtxoahp.Text = "Xóa";
            this.btnqtxoahp.UseVisualStyleBackColor = true;
            this.btnqtxoahp.Click += new System.EventHandler(this.btnqtxoahp_Click);
            // 
            // btnqtghihp
            // 
            this.btnqtghihp.Location = new System.Drawing.Point(3, 228);
            this.btnqtghihp.Name = "btnqtghihp";
            this.btnqtghihp.Size = new System.Drawing.Size(144, 69);
            this.btnqtghihp.TabIndex = 3;
            this.btnqtghihp.Text = "Ghi";
            this.btnqtghihp.UseVisualStyleBackColor = true;
            this.btnqtghihp.Click += new System.EventHandler(this.btnqtghihp_Click);
            // 
            // btnqthuyhp
            // 
            this.btnqthuyhp.Location = new System.Drawing.Point(3, 303);
            this.btnqthuyhp.Name = "btnqthuyhp";
            this.btnqthuyhp.Size = new System.Drawing.Size(144, 69);
            this.btnqthuyhp.TabIndex = 4;
            this.btnqthuyhp.Text = "Hủy";
            this.btnqthuyhp.UseVisualStyleBackColor = true;
            this.btnqthuyhp.Click += new System.EventHandler(this.btnqthuyhp_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.txtqtsotiet);
            this.pnlqttruong.Controls.Add(this.label5);
            this.pnlqttruong.Controls.Add(this.cboqtsotinchi);
            this.pnlqttruong.Controls.Add(this.label4);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqttenhp);
            this.pnlqttruong.Controls.Add(this.txtqtmahp);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(171, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(612, 147);
            this.pnlqttruong.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tiết:";
            // 
            // cboqtsotinchi
            // 
            this.cboqtsotinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtsotinchi.FormattingEnabled = true;
            this.cboqtsotinchi.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cboqtsotinchi.Location = new System.Drawing.Point(25, 101);
            this.cboqtsotinchi.Name = "cboqtsotinchi";
            this.cboqtsotinchi.Size = new System.Drawing.Size(111, 28);
            this.cboqtsotinchi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tín chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần:";
            // 
            // txtqttenhp
            // 
            this.txtqttenhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttenhp.Location = new System.Drawing.Point(247, 38);
            this.txtqttenhp.Name = "txtqttenhp";
            this.txtqttenhp.Size = new System.Drawing.Size(352, 27);
            this.txtqttenhp.TabIndex = 3;
            // 
            // txtqtmahp
            // 
            this.txtqtmahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmahp.Location = new System.Drawing.Point(25, 38);
            this.txtqtmahp.Name = "txtqtmahp";
            this.txtqtmahp.Size = new System.Drawing.Size(208, 27);
            this.txtqtmahp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần:";
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlqtcsdl.Controls.Add(this.dgvqthp);
            this.pnlqtcsdl.Location = new System.Drawing.Point(171, 156);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(615, 350);
            this.pnlqtcsdl.TabIndex = 5;
            // 
            // dgvqthp
            // 
            this.dgvqthp.AllowUserToAddRows = false;
            this.dgvqthp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqthp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqthp.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqthp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqthp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqthp.Location = new System.Drawing.Point(3, 60);
            this.dgvqthp.Name = "dgvqthp";
            this.dgvqthp.RowHeadersWidth = 51;
            this.dgvqthp.RowTemplate.Height = 24;
            this.dgvqthp.Size = new System.Drawing.Size(609, 287);
            this.dgvqthp.TabIndex = 4;
            this.dgvqthp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqthp_CellClick);
            // 
            // txtqtsotiet
            // 
            this.txtqtsotiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtsotiet.Location = new System.Drawing.Point(247, 98);
            this.txtqtsotiet.Name = "txtqtsotiet";
            this.txtqtsotiet.Size = new System.Drawing.Size(111, 27);
            this.txtqtsotiet.TabIndex = 12;
            // 
            // frmqthocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.pnlqttruong);
            this.Controls.Add(this.floqtnut);
            this.Name = "frmqthocphan";
            this.Text = "Hocphan";
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqthp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemhp;
        private System.Windows.Forms.Button btnqtsuahp;
        private System.Windows.Forms.Button btnqtxoahp;
        private System.Windows.Forms.Button btnqtghihp;
        private System.Windows.Forms.Button btnqthuyhp;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqttenhp;
        private System.Windows.Forms.TextBox txtqtmahp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqthp;
        private System.Windows.Forms.ComboBox cboqtsotinchi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtsotiet;
    }
}