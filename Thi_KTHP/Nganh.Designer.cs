﻿namespace Thi_KTHP
{
    partial class frmqtnganh
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
            this.btnqtthemnganh = new System.Windows.Forms.Button();
            this.btnqtsuanganh = new System.Windows.Forms.Button();
            this.btnqtxoanganh = new System.Windows.Forms.Button();
            this.btnqtghinganh = new System.Windows.Forms.Button();
            this.btnqthuynganh = new System.Windows.Forms.Button();
            this.btnqtxuatexcell = new System.Windows.Forms.Button();
            this.btnqttknganh = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.txtqttknganh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboqtmakhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqttennganh = new System.Windows.Forms.TextBox();
            this.txtqtmanganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlqtcsdl = new System.Windows.Forms.Panel();
            this.dgvqtnganh = new System.Windows.Forms.DataGridView();
            this.errorbatloi = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.floqtnut.SuspendLayout();
            this.pnlqttruong.SuspendLayout();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtnganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).BeginInit();
            this.SuspendLayout();
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.BackColor = System.Drawing.Color.LightBlue;
            this.floqtnut.Controls.Add(this.btnqtthemnganh);
            this.floqtnut.Controls.Add(this.btnqtsuanganh);
            this.floqtnut.Controls.Add(this.btnqtxoanganh);
            this.floqtnut.Controls.Add(this.btnqtghinganh);
            this.floqtnut.Controls.Add(this.btnqthuynganh);
            this.floqtnut.Controls.Add(this.btnqtxuatexcell);
            this.floqtnut.Controls.Add(this.btnqttknganh);
            this.floqtnut.Location = new System.Drawing.Point(2, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 554);
            this.floqtnut.TabIndex = 3;
            // 
            // btnqtthemnganh
            // 
            this.btnqtthemnganh.Image = global::Thi_KTHP.Properties.Resources.Them;
            this.btnqtthemnganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtthemnganh.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemnganh.Name = "btnqtthemnganh";
            this.btnqtthemnganh.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemnganh.TabIndex = 0;
            this.btnqtthemnganh.Text = "Thêm";
            this.btnqtthemnganh.UseVisualStyleBackColor = true;
            this.btnqtthemnganh.Click += new System.EventHandler(this.btnqtthemnganh_Click);
            // 
            // btnqtsuanganh
            // 
            this.btnqtsuanganh.Image = global::Thi_KTHP.Properties.Resources.sửa;
            this.btnqtsuanganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtsuanganh.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuanganh.Name = "btnqtsuanganh";
            this.btnqtsuanganh.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuanganh.TabIndex = 1;
            this.btnqtsuanganh.Text = "Sửa";
            this.btnqtsuanganh.UseVisualStyleBackColor = true;
            this.btnqtsuanganh.Click += new System.EventHandler(this.btnqtsuanganh_Click);
            // 
            // btnqtxoanganh
            // 
            this.btnqtxoanganh.Image = global::Thi_KTHP.Properties.Resources.xoa;
            this.btnqtxoanganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtxoanganh.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoanganh.Name = "btnqtxoanganh";
            this.btnqtxoanganh.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoanganh.TabIndex = 2;
            this.btnqtxoanganh.Text = "Xóa";
            this.btnqtxoanganh.UseVisualStyleBackColor = true;
            this.btnqtxoanganh.Click += new System.EventHandler(this.btnqtxoanganh_Click);
            // 
            // btnqtghinganh
            // 
            this.btnqtghinganh.Image = global::Thi_KTHP.Properties.Resources.ghi;
            this.btnqtghinganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtghinganh.Location = new System.Drawing.Point(3, 228);
            this.btnqtghinganh.Name = "btnqtghinganh";
            this.btnqtghinganh.Size = new System.Drawing.Size(144, 69);
            this.btnqtghinganh.TabIndex = 3;
            this.btnqtghinganh.Text = "Ghi";
            this.btnqtghinganh.UseVisualStyleBackColor = true;
            this.btnqtghinganh.Click += new System.EventHandler(this.btnqtghinganh_Click);
            // 
            // btnqthuynganh
            // 
            this.btnqthuynganh.Image = global::Thi_KTHP.Properties.Resources.huy;
            this.btnqthuynganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqthuynganh.Location = new System.Drawing.Point(3, 303);
            this.btnqthuynganh.Name = "btnqthuynganh";
            this.btnqthuynganh.Size = new System.Drawing.Size(144, 69);
            this.btnqthuynganh.TabIndex = 4;
            this.btnqthuynganh.Text = "Hủy";
            this.btnqthuynganh.UseVisualStyleBackColor = true;
            this.btnqthuynganh.Click += new System.EventHandler(this.btnqthuynganh_Click);
            // 
            // btnqtxuatexcell
            // 
            this.btnqtxuatexcell.Image = global::Thi_KTHP.Properties.Resources.excel;
            this.btnqtxuatexcell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqtxuatexcell.Location = new System.Drawing.Point(3, 378);
            this.btnqtxuatexcell.Name = "btnqtxuatexcell";
            this.btnqtxuatexcell.Size = new System.Drawing.Size(144, 69);
            this.btnqtxuatexcell.TabIndex = 8;
            this.btnqtxuatexcell.Text = "Excell";
            this.btnqtxuatexcell.UseVisualStyleBackColor = true;
            this.btnqtxuatexcell.Click += new System.EventHandler(this.btnqtxuatexcell_Click);
            // 
            // btnqttknganh
            // 
            this.btnqttknganh.Image = global::Thi_KTHP.Properties.Resources.timkiem;
            this.btnqttknganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqttknganh.Location = new System.Drawing.Point(3, 453);
            this.btnqttknganh.Name = "btnqttknganh";
            this.btnqttknganh.Size = new System.Drawing.Size(144, 69);
            this.btnqttknganh.TabIndex = 9;
            this.btnqttknganh.Text = "Tìm Kiếm";
            this.btnqttknganh.UseVisualStyleBackColor = true;
            this.btnqttknganh.Click += new System.EventHandler(this.btnqttknganh_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.BackColor = System.Drawing.Color.LightBlue;
            this.pnlqttruong.Controls.Add(this.label4);
            this.pnlqttruong.Controls.Add(this.txtqttknganh);
            this.pnlqttruong.Controls.Add(this.label5);
            this.pnlqttruong.Controls.Add(this.cboqtmakhoa);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqttennganh);
            this.pnlqttruong.Controls.Add(this.txtqtmanganh);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(171, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(608, 205);
            this.pnlqttruong.TabIndex = 4;
            // 
            // txtqttknganh
            // 
            this.txtqttknganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttknganh.Location = new System.Drawing.Point(248, 169);
            this.txtqttknganh.Name = "txtqttknganh";
            this.txtqttknganh.Size = new System.Drawing.Size(314, 27);
            this.txtqttknganh.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tìm Kiếm:";
            // 
            // cboqtmakhoa
            // 
            this.cboqtmakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmakhoa.FormattingEnabled = true;
            this.cboqtmakhoa.Location = new System.Drawing.Point(15, 169);
            this.cboqtmakhoa.Name = "cboqtmakhoa";
            this.cboqtmakhoa.Size = new System.Drawing.Size(208, 28);
            this.cboqtmakhoa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Khoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ngành:";
            // 
            // txtqttennganh
            // 
            this.txtqttennganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttennganh.Location = new System.Drawing.Point(248, 87);
            this.txtqttennganh.Name = "txtqttennganh";
            this.txtqttennganh.Size = new System.Drawing.Size(208, 27);
            this.txtqttennganh.TabIndex = 3;
            // 
            // txtqtmanganh
            // 
            this.txtqtmanganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmanganh.Location = new System.Drawing.Point(15, 87);
            this.txtqtmanganh.Name = "txtqtmanganh";
            this.txtqtmanganh.Size = new System.Drawing.Size(208, 27);
            this.txtqtmanganh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên ngành:";
            // 
            // pnlqtcsdl
            // 
            this.pnlqtcsdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqtcsdl.BackColor = System.Drawing.Color.LightBlue;
            this.pnlqtcsdl.Controls.Add(this.dgvqtnganh);
            this.pnlqtcsdl.Location = new System.Drawing.Point(171, 214);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(608, 343);
            this.pnlqtcsdl.TabIndex = 5;
            // 
            // dgvqtnganh
            // 
            this.dgvqtnganh.AllowUserToAddRows = false;
            this.dgvqtnganh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtnganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtnganh.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtnganh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtnganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtnganh.Location = new System.Drawing.Point(3, 3);
            this.dgvqtnganh.Name = "dgvqtnganh";
            this.dgvqtnganh.RowHeadersWidth = 51;
            this.dgvqtnganh.RowTemplate.Height = 24;
            this.dgvqtnganh.Size = new System.Drawing.Size(602, 280);
            this.dgvqtnganh.TabIndex = 4;
            this.dgvqtnganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtnganh_CellClick);
            // 
            // errorbatloi
            // 
            this.errorbatloi.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thông tin ngành";
            // 
            // frmqtnganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 560);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.floqtnut);
            this.Controls.Add(this.pnlqttruong);
            this.Name = "frmqtnganh";
            this.Text = "Nganh";
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtnganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorbatloi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemnganh;
        private System.Windows.Forms.Button btnqtsuanganh;
        private System.Windows.Forms.Button btnqtxoanganh;
        private System.Windows.Forms.Button btnqtghinganh;
        private System.Windows.Forms.Button btnqthuynganh;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqttennganh;
        private System.Windows.Forms.TextBox txtqtmanganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboqtmakhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqtnganh;
        private System.Windows.Forms.Button btnqtxuatexcell;
        private System.Windows.Forms.Button btnqttknganh;
        private System.Windows.Forms.TextBox txtqttknganh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorbatloi;
        private System.Windows.Forms.Label label4;
    }
}