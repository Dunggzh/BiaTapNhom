namespace Thi_KTHP
{
    partial class frmqtkhoa
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
            this.dgvqtkhoa = new System.Windows.Forms.DataGridView();
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemkhoa = new System.Windows.Forms.Button();
            this.btnqtsuakhoa = new System.Windows.Forms.Button();
            this.btnqtxoakhoa = new System.Windows.Forms.Button();
            this.btnqtghikhoa = new System.Windows.Forms.Button();
            this.btnqthuykhoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtmakhoa = new System.Windows.Forms.TextBox();
            this.txtqttenkhoa = new System.Windows.Forms.TextBox();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.txtqtsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqtghichu = new System.Windows.Forms.TextBox();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtkhoa)).BeginInit();
            this.floqtnut.SuspendLayout();
            this.pnlqttruong.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlqtcsdl.Controls.Add(this.dgvqtkhoa);
            this.pnlqtcsdl.Location = new System.Drawing.Point(167, 177);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(615, 326);
            this.pnlqtcsdl.TabIndex = 1;
            // 
            // dgvqtkhoa
            // 
            this.dgvqtkhoa.AllowUserToAddRows = false;
            this.dgvqtkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtkhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtkhoa.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtkhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtkhoa.Location = new System.Drawing.Point(3, 60);
            this.dgvqtkhoa.Name = "dgvqtkhoa";
            this.dgvqtkhoa.RowHeadersWidth = 51;
            this.dgvqtkhoa.RowTemplate.Height = 24;
            this.dgvqtkhoa.Size = new System.Drawing.Size(609, 263);
            this.dgvqtkhoa.TabIndex = 4;
            this.dgvqtkhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtkhoa_CellClick);
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemkhoa);
            this.floqtnut.Controls.Add(this.btnqtsuakhoa);
            this.floqtnut.Controls.Add(this.btnqtxoakhoa);
            this.floqtnut.Controls.Add(this.btnqtghikhoa);
            this.floqtnut.Controls.Add(this.btnqthuykhoa);
            this.floqtnut.Location = new System.Drawing.Point(-2, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 497);
            this.floqtnut.TabIndex = 2;
            // 
            // btnqtthemkhoa
            // 
            this.btnqtthemkhoa.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemkhoa.Name = "btnqtthemkhoa";
            this.btnqtthemkhoa.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemkhoa.TabIndex = 0;
            this.btnqtthemkhoa.Text = "Thêm";
            this.btnqtthemkhoa.UseVisualStyleBackColor = true;
            this.btnqtthemkhoa.Click += new System.EventHandler(this.btnqtthemkhoa_Click);
            // 
            // btnqtsuakhoa
            // 
            this.btnqtsuakhoa.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuakhoa.Name = "btnqtsuakhoa";
            this.btnqtsuakhoa.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuakhoa.TabIndex = 1;
            this.btnqtsuakhoa.Text = "Sửa";
            this.btnqtsuakhoa.UseVisualStyleBackColor = true;
            this.btnqtsuakhoa.Click += new System.EventHandler(this.btnqtsuakhoa_Click);
            // 
            // btnqtxoakhoa
            // 
            this.btnqtxoakhoa.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoakhoa.Name = "btnqtxoakhoa";
            this.btnqtxoakhoa.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoakhoa.TabIndex = 2;
            this.btnqtxoakhoa.Text = "Xóa";
            this.btnqtxoakhoa.UseVisualStyleBackColor = true;
            this.btnqtxoakhoa.Click += new System.EventHandler(this.btnqtxoakhoa_Click);
            // 
            // btnqtghikhoa
            // 
            this.btnqtghikhoa.Location = new System.Drawing.Point(3, 228);
            this.btnqtghikhoa.Name = "btnqtghikhoa";
            this.btnqtghikhoa.Size = new System.Drawing.Size(144, 69);
            this.btnqtghikhoa.TabIndex = 3;
            this.btnqtghikhoa.Text = "Ghi";
            this.btnqtghikhoa.UseVisualStyleBackColor = true;
            this.btnqtghikhoa.Click += new System.EventHandler(this.btnqtghikhoa_Click);
            // 
            // btnqthuykhoa
            // 
            this.btnqthuykhoa.Location = new System.Drawing.Point(3, 303);
            this.btnqthuykhoa.Name = "btnqthuykhoa";
            this.btnqthuykhoa.Size = new System.Drawing.Size(144, 69);
            this.btnqthuykhoa.TabIndex = 4;
            this.btnqthuykhoa.Text = "Hủy";
            this.btnqthuykhoa.UseVisualStyleBackColor = true;
            this.btnqthuykhoa.Click += new System.EventHandler(this.btnqthuykhoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa:";
            // 
            // txtqtmakhoa
            // 
            this.txtqtmakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmakhoa.Location = new System.Drawing.Point(25, 38);
            this.txtqtmakhoa.Name = "txtqtmakhoa";
            this.txtqtmakhoa.Size = new System.Drawing.Size(208, 27);
            this.txtqtmakhoa.TabIndex = 2;
            // 
            // txtqttenkhoa
            // 
            this.txtqttenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttenkhoa.Location = new System.Drawing.Point(335, 38);
            this.txtqttenkhoa.Name = "txtqttenkhoa";
            this.txtqttenkhoa.Size = new System.Drawing.Size(208, 27);
            this.txtqttenkhoa.TabIndex = 3;
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.txtqtghichu);
            this.pnlqttruong.Controls.Add(this.label4);
            this.pnlqttruong.Controls.Add(this.txtqtsdt);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqttenkhoa);
            this.pnlqttruong.Controls.Add(this.txtqtmakhoa);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(167, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(615, 168);
            this.pnlqttruong.TabIndex = 3;
            // 
            // txtqtsdt
            // 
            this.txtqtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtsdt.Location = new System.Drawing.Point(25, 120);
            this.txtqtsdt.Name = "txtqtsdt";
            this.txtqtsdt.Size = new System.Drawing.Size(208, 27);
            this.txtqtsdt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú:";
            // 
            // txtqtghichu
            // 
            this.txtqtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtghichu.Location = new System.Drawing.Point(335, 120);
            this.txtqtghichu.Name = "txtqtghichu";
            this.txtqtghichu.Size = new System.Drawing.Size(208, 27);
            this.txtqtghichu.TabIndex = 7;
            // 
            // frmqtkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnlqttruong);
            this.Controls.Add(this.floqtnut);
            this.Controls.Add(this.pnlqtcsdl);
            this.Name = "frmqtkhoa";
            this.Text = "Khoa";
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtkhoa)).EndInit();
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemkhoa;
        private System.Windows.Forms.Button btnqtsuakhoa;
        private System.Windows.Forms.Button btnqtxoakhoa;
        private System.Windows.Forms.Button btnqtghikhoa;
        private System.Windows.Forms.Button btnqthuykhoa;
        private System.Windows.Forms.DataGridView dgvqtkhoa;
        private System.Windows.Forms.TextBox txtqttenkhoa;
        private System.Windows.Forms.TextBox txtqtmakhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.TextBox txtqtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtqtghichu;
        private System.Windows.Forms.Label label4;
    }
}