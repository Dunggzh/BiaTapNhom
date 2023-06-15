namespace Thi_KTHP
{
    partial class frmqtgv
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
            this.components = new System.ComponentModel.Container();
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemgv = new System.Windows.Forms.Button();
            this.btnqtsuagv = new System.Windows.Forms.Button();
            this.btnqtxoagv = new System.Windows.Forms.Button();
            this.btnqtghigv = new System.Windows.Forms.Button();
            this.btnqthuygv = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.cboqttrinhdogv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtsodtgv = new System.Windows.Forms.TextBox();
            this.cboqtmakhoa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqttengv = new System.Windows.Forms.TextBox();
            this.txtqtmagv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlqtcsdl = new System.Windows.Forms.Panel();
            this.dgvqtgv = new System.Windows.Forms.DataGridView();
            this.txtqttenkhoa = new System.Windows.Forms.TextBox();
            this.txtqttkgv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnqtxuatexcell = new System.Windows.Forms.Button();
            this.btnqttkgv = new System.Windows.Forms.Button();
            this.errorbatloi = new System.Windows.Forms.ErrorProvider(this.components);
            this.floqtnut.SuspendLayout();
            this.pnlqttruong.SuspendLayout();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).BeginInit();
            this.SuspendLayout();
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemgv);
            this.floqtnut.Controls.Add(this.btnqtsuagv);
            this.floqtnut.Controls.Add(this.btnqtxoagv);
            this.floqtnut.Controls.Add(this.btnqtghigv);
            this.floqtnut.Controls.Add(this.btnqthuygv);
            this.floqtnut.Controls.Add(this.btnqtxuatexcell);
            this.floqtnut.Controls.Add(this.btnqttkgv);
            this.floqtnut.Location = new System.Drawing.Point(1, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 547);
            this.floqtnut.TabIndex = 4;
            // 
            // btnqtthemgv
            // 
            this.btnqtthemgv.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemgv.Name = "btnqtthemgv";
            this.btnqtthemgv.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemgv.TabIndex = 0;
            this.btnqtthemgv.Text = "Thêm";
            this.btnqtthemgv.UseVisualStyleBackColor = true;
            this.btnqtthemgv.Click += new System.EventHandler(this.btnqtthemgv_Click);
            // 
            // btnqtsuagv
            // 
            this.btnqtsuagv.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuagv.Name = "btnqtsuagv";
            this.btnqtsuagv.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuagv.TabIndex = 1;
            this.btnqtsuagv.Text = "Sửa";
            this.btnqtsuagv.UseVisualStyleBackColor = true;
            this.btnqtsuagv.Click += new System.EventHandler(this.btnqtsuagv_Click);
            // 
            // btnqtxoagv
            // 
            this.btnqtxoagv.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoagv.Name = "btnqtxoagv";
            this.btnqtxoagv.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoagv.TabIndex = 2;
            this.btnqtxoagv.Text = "Xóa";
            this.btnqtxoagv.UseVisualStyleBackColor = true;
            this.btnqtxoagv.Click += new System.EventHandler(this.btnqtxoagv_Click);
            // 
            // btnqtghigv
            // 
            this.btnqtghigv.Location = new System.Drawing.Point(3, 228);
            this.btnqtghigv.Name = "btnqtghigv";
            this.btnqtghigv.Size = new System.Drawing.Size(144, 69);
            this.btnqtghigv.TabIndex = 3;
            this.btnqtghigv.Text = "Ghi";
            this.btnqtghigv.UseVisualStyleBackColor = true;
            this.btnqtghigv.Click += new System.EventHandler(this.btnqtghigv_Click);
            // 
            // btnqthuygv
            // 
            this.btnqthuygv.Location = new System.Drawing.Point(3, 303);
            this.btnqthuygv.Name = "btnqthuygv";
            this.btnqthuygv.Size = new System.Drawing.Size(144, 69);
            this.btnqthuygv.TabIndex = 4;
            this.btnqthuygv.Text = "Hủy";
            this.btnqthuygv.UseVisualStyleBackColor = true;
            this.btnqthuygv.Click += new System.EventHandler(this.btnqthuygv_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.txtqttkgv);
            this.pnlqttruong.Controls.Add(this.label6);
            this.pnlqttruong.Controls.Add(this.txtqttenkhoa);
            this.pnlqttruong.Controls.Add(this.cboqttrinhdogv);
            this.pnlqttruong.Controls.Add(this.label5);
            this.pnlqttruong.Controls.Add(this.txtqtsodtgv);
            this.pnlqttruong.Controls.Add(this.cboqtmakhoa);
            this.pnlqttruong.Controls.Add(this.label4);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqttengv);
            this.pnlqttruong.Controls.Add(this.txtqtmagv);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(170, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(612, 239);
            this.pnlqttruong.TabIndex = 5;
            // 
            // cboqttrinhdogv
            // 
            this.cboqttrinhdogv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqttrinhdogv.FormattingEnabled = true;
            this.cboqttrinhdogv.Items.AddRange(new object[] {
            "Thạc sĩ",
            "Tiến sĩ",
            "Giáo sư",
            "Khác"});
            this.cboqttrinhdogv.Location = new System.Drawing.Point(366, 194);
            this.cboqttrinhdogv.Name = "cboqttrinhdogv";
            this.cboqttrinhdogv.Size = new System.Drawing.Size(113, 28);
            this.cboqttrinhdogv.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trình độ:";
            // 
            // txtqtsodtgv
            // 
            this.txtqtsodtgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtsodtgv.Location = new System.Drawing.Point(35, 137);
            this.txtqtsodtgv.Name = "txtqtsodtgv";
            this.txtqtsodtgv.Size = new System.Drawing.Size(208, 27);
            this.txtqtsodtgv.TabIndex = 7;
            // 
            // cboqtmakhoa
            // 
            this.cboqtmakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmakhoa.FormattingEnabled = true;
            this.cboqtmakhoa.Location = new System.Drawing.Point(304, 29);
            this.cboqtmakhoa.Name = "cboqtmakhoa";
            this.cboqtmakhoa.Size = new System.Drawing.Size(208, 28);
            this.cboqtmakhoa.TabIndex = 6;
            this.cboqtmakhoa.SelectedIndexChanged += new System.EventHandler(this.cboqtmakhoa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khoa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giảng viên:";
            // 
            // txtqttengv
            // 
            this.txtqttengv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttengv.Location = new System.Drawing.Point(361, 132);
            this.txtqttengv.Name = "txtqttengv";
            this.txtqttengv.Size = new System.Drawing.Size(208, 27);
            this.txtqttengv.TabIndex = 3;
            // 
            // txtqtmagv
            // 
            this.txtqtmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmagv.Location = new System.Drawing.Point(31, 33);
            this.txtqtmagv.Name = "txtqtmagv";
            this.txtqtmagv.Size = new System.Drawing.Size(208, 27);
            this.txtqtmagv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên giảng viên:";
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlqtcsdl.Controls.Add(this.dgvqtgv);
            this.pnlqtcsdl.Location = new System.Drawing.Point(170, 248);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(615, 308);
            this.pnlqtcsdl.TabIndex = 6;
            // 
            // dgvqtgv
            // 
            this.dgvqtgv.AllowUserToAddRows = false;
            this.dgvqtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtgv.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtgv.Location = new System.Drawing.Point(3, 60);
            this.dgvqtgv.Name = "dgvqtgv";
            this.dgvqtgv.RowHeadersWidth = 51;
            this.dgvqtgv.RowTemplate.Height = 24;
            this.dgvqtgv.Size = new System.Drawing.Size(609, 245);
            this.dgvqtgv.TabIndex = 4;
            this.dgvqtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtgv_CellClick);
            // 
            // txtqttenkhoa
            // 
            this.txtqttenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttenkhoa.Location = new System.Drawing.Point(304, 63);
            this.txtqttenkhoa.Name = "txtqttenkhoa";
            this.txtqttenkhoa.ReadOnly = true;
            this.txtqttenkhoa.Size = new System.Drawing.Size(275, 27);
            this.txtqttenkhoa.TabIndex = 10;
            // 
            // txtqttkgv
            // 
            this.txtqttkgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttkgv.Location = new System.Drawing.Point(37, 195);
            this.txtqttkgv.Name = "txtqttkgv";
            this.txtqttkgv.Size = new System.Drawing.Size(314, 27);
            this.txtqttkgv.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm Kiếm:";
            // 
            // btnqtxuatexcell
            // 
            this.btnqtxuatexcell.Location = new System.Drawing.Point(3, 378);
            this.btnqtxuatexcell.Name = "btnqtxuatexcell";
            this.btnqtxuatexcell.Size = new System.Drawing.Size(144, 69);
            this.btnqtxuatexcell.TabIndex = 9;
            this.btnqtxuatexcell.Text = "Export Excell";
            this.btnqtxuatexcell.UseVisualStyleBackColor = true;
            this.btnqtxuatexcell.Click += new System.EventHandler(this.btnqtxuatexcell_Click);
            // 
            // btnqttkgv
            // 
            this.btnqttkgv.Location = new System.Drawing.Point(3, 453);
            this.btnqttkgv.Name = "btnqttkgv";
            this.btnqttkgv.Size = new System.Drawing.Size(144, 69);
            this.btnqttkgv.TabIndex = 10;
            this.btnqttkgv.Text = "Tìm Kiếm";
            this.btnqttkgv.UseVisualStyleBackColor = true;
            this.btnqttkgv.Click += new System.EventHandler(this.btnqttkgv_Click);
            // 
            // errorbatloi
            // 
            this.errorbatloi.ContainerControl = this;
            // 
            // frmqtgv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.pnlqttruong);
            this.Controls.Add(this.floqtnut);
            this.Name = "frmqtgv";
            this.Text = "Giangvien";
            this.Load += new System.EventHandler(this.frmqtgv_Load);
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemgv;
        private System.Windows.Forms.Button btnqtsuagv;
        private System.Windows.Forms.Button btnqtxoagv;
        private System.Windows.Forms.Button btnqtghigv;
        private System.Windows.Forms.Button btnqthuygv;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.ComboBox cboqtmakhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqttengv;
        private System.Windows.Forms.TextBox txtqtmagv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqtgv;
        private System.Windows.Forms.ComboBox cboqttrinhdogv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtsodtgv;
        private System.Windows.Forms.TextBox txtqttenkhoa;
        private System.Windows.Forms.TextBox txtqttkgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnqtxuatexcell;
        private System.Windows.Forms.Button btnqttkgv;
        private System.Windows.Forms.ErrorProvider errorbatloi;
    }
}