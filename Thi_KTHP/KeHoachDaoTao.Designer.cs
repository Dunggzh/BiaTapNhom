namespace Thi_KTHP
{
    partial class frmqtkhdt
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
            this.pnlqtcsdl = new System.Windows.Forms.Panel();
            this.dgvqtkhdt = new System.Windows.Forms.DataGridView();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.txtqtmakhdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemkhdt = new System.Windows.Forms.Button();
            this.btnqtsuakhdt = new System.Windows.Forms.Button();
            this.btnqtxoakhdt = new System.Windows.Forms.Button();
            this.btnqtghikhdt = new System.Windows.Forms.Button();
            this.btnqthuykhdt = new System.Windows.Forms.Button();
            this.cboqttenlop = new System.Windows.Forms.ComboBox();
            this.cboqtmakhoahoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtkhdt)).BeginInit();
            this.pnlqttruong.SuspendLayout();
            this.floqtnut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlqtcsdl.Controls.Add(this.dgvqtkhdt);
            this.pnlqtcsdl.Location = new System.Drawing.Point(168, 154);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(615, 347);
            this.pnlqtcsdl.TabIndex = 8;
            // 
            // dgvqtkhdt
            // 
            this.dgvqtkhdt.AllowUserToAddRows = false;
            this.dgvqtkhdt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtkhdt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtkhdt.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtkhdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtkhdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtkhdt.Location = new System.Drawing.Point(3, 60);
            this.dgvqtkhdt.Name = "dgvqtkhdt";
            this.dgvqtkhdt.RowHeadersWidth = 51;
            this.dgvqtkhdt.RowTemplate.Height = 24;
            this.dgvqtkhdt.Size = new System.Drawing.Size(609, 284);
            this.dgvqtkhdt.TabIndex = 4;
            this.dgvqtkhdt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtkhdt_CellClick);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.cboqtmakhoahoc);
            this.pnlqttruong.Controls.Add(this.cboqttenlop);
            this.pnlqttruong.Controls.Add(this.txtqtmakhdt);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Location = new System.Drawing.Point(168, 1);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(615, 147);
            this.pnlqttruong.TabIndex = 7;
            // 
            // txtqtmakhdt
            // 
            this.txtqtmakhdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmakhdt.Location = new System.Drawing.Point(25, 26);
            this.txtqtmakhdt.Name = "txtqtmakhdt";
            this.txtqtmakhdt.Size = new System.Drawing.Size(208, 27);
            this.txtqtmakhdt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã KHDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Lớp:";
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemkhdt);
            this.floqtnut.Controls.Add(this.btnqtsuakhdt);
            this.floqtnut.Controls.Add(this.btnqtxoakhdt);
            this.floqtnut.Controls.Add(this.btnqtghikhdt);
            this.floqtnut.Controls.Add(this.btnqthuykhdt);
            this.floqtnut.Location = new System.Drawing.Point(-1, 1);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 497);
            this.floqtnut.TabIndex = 6;
            // 
            // btnqtthemkhdt
            // 
            this.btnqtthemkhdt.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemkhdt.Name = "btnqtthemkhdt";
            this.btnqtthemkhdt.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemkhdt.TabIndex = 0;
            this.btnqtthemkhdt.Text = "Thêm";
            this.btnqtthemkhdt.UseVisualStyleBackColor = true;
            this.btnqtthemkhdt.Click += new System.EventHandler(this.btnqtthemkhdt_Click);
            // 
            // btnqtsuakhdt
            // 
            this.btnqtsuakhdt.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuakhdt.Name = "btnqtsuakhdt";
            this.btnqtsuakhdt.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuakhdt.TabIndex = 1;
            this.btnqtsuakhdt.Text = "Sửa";
            this.btnqtsuakhdt.UseVisualStyleBackColor = true;
            this.btnqtsuakhdt.Click += new System.EventHandler(this.btnqtsuakhdt_Click);
            // 
            // btnqtxoakhdt
            // 
            this.btnqtxoakhdt.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoakhdt.Name = "btnqtxoakhdt";
            this.btnqtxoakhdt.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoakhdt.TabIndex = 2;
            this.btnqtxoakhdt.Text = "Xóa";
            this.btnqtxoakhdt.UseVisualStyleBackColor = true;
            this.btnqtxoakhdt.Click += new System.EventHandler(this.btnqtxoakhdt_Click);
            // 
            // btnqtghikhdt
            // 
            this.btnqtghikhdt.Location = new System.Drawing.Point(3, 228);
            this.btnqtghikhdt.Name = "btnqtghikhdt";
            this.btnqtghikhdt.Size = new System.Drawing.Size(144, 69);
            this.btnqtghikhdt.TabIndex = 3;
            this.btnqtghikhdt.Text = "Ghi";
            this.btnqtghikhdt.UseVisualStyleBackColor = true;
            this.btnqtghikhdt.Click += new System.EventHandler(this.btnqtghikhdt_Click);
            // 
            // btnqthuykhdt
            // 
            this.btnqthuykhdt.Location = new System.Drawing.Point(3, 303);
            this.btnqthuykhdt.Name = "btnqthuykhdt";
            this.btnqthuykhdt.Size = new System.Drawing.Size(144, 69);
            this.btnqthuykhdt.TabIndex = 4;
            this.btnqthuykhdt.Text = "Hủy";
            this.btnqthuykhdt.UseVisualStyleBackColor = true;
            this.btnqthuykhdt.Click += new System.EventHandler(this.btnqthuykhdt_Click);
            // 
            // cboqttenlop
            // 
            this.cboqttenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqttenlop.FormattingEnabled = true;
            this.cboqttenlop.Location = new System.Drawing.Point(25, 101);
            this.cboqttenlop.Name = "cboqttenlop";
            this.cboqttenlop.Size = new System.Drawing.Size(208, 28);
            this.cboqttenlop.TabIndex = 8;
            // 
            // cboqtmakhoahoc
            // 
            this.cboqtmakhoahoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmakhoahoc.FormattingEnabled = true;
            this.cboqtmakhoahoc.Location = new System.Drawing.Point(299, 101);
            this.cboqtmakhoahoc.Name = "cboqtmakhoahoc";
            this.cboqtmakhoahoc.Size = new System.Drawing.Size(283, 28);
            this.cboqtmakhoahoc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Khóa Học:";
            // 
            // frmqtkhdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.pnlqttruong);
            this.Controls.Add(this.floqtnut);
            this.Name = "frmqtkhdt";
            this.Text = "Kế hoạch đào tạo";
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtkhdt)).EndInit();
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.floqtnut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqtkhdt;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.TextBox txtqtmakhdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemkhdt;
        private System.Windows.Forms.Button btnqtsuakhdt;
        private System.Windows.Forms.Button btnqtxoakhdt;
        private System.Windows.Forms.Button btnqtghikhdt;
        private System.Windows.Forms.Button btnqthuykhdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboqtmakhoahoc;
        private System.Windows.Forms.ComboBox cboqttenlop;
    }
}