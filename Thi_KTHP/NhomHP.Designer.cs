﻿namespace Thi_KTHP
{
    partial class frmqtnhomhp
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
            this.dgvqtnhp = new System.Windows.Forms.DataGridView();
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemnhp = new System.Windows.Forms.Button();
            this.btnqtsuanhp = new System.Windows.Forms.Button();
            this.btnqtxoanhp = new System.Windows.Forms.Button();
            this.btnqtghinhp = new System.Windows.Forms.Button();
            this.btnqthuynhp = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.cboqtmakhdt = new System.Windows.Forms.ComboBox();
            this.cboqtmagv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboqtmahp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqttennhp = new System.Windows.Forms.TextBox();
            this.txtqtmanhp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtnhp)).BeginInit();
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
            this.pnlqtcsdl.Controls.Add(this.dgvqtnhp);
            this.pnlqtcsdl.Location = new System.Drawing.Point(172, 231);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(608, 269);
            this.pnlqtcsdl.TabIndex = 8;
            // 
            // dgvqtnhp
            // 
            this.dgvqtnhp.AllowUserToAddRows = false;
            this.dgvqtnhp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqtnhp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqtnhp.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqtnhp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqtnhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqtnhp.Location = new System.Drawing.Point(3, 60);
            this.dgvqtnhp.Name = "dgvqtnhp";
            this.dgvqtnhp.RowHeadersWidth = 51;
            this.dgvqtnhp.RowTemplate.Height = 24;
            this.dgvqtnhp.Size = new System.Drawing.Size(602, 206);
            this.dgvqtnhp.TabIndex = 4;
            this.dgvqtnhp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqtnhp_CellClick);
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemnhp);
            this.floqtnut.Controls.Add(this.btnqtsuanhp);
            this.floqtnut.Controls.Add(this.btnqtxoanhp);
            this.floqtnut.Controls.Add(this.btnqtghinhp);
            this.floqtnut.Controls.Add(this.btnqthuynhp);
            this.floqtnut.Location = new System.Drawing.Point(3, 3);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 497);
            this.floqtnut.TabIndex = 6;
            // 
            // btnqtthemnhp
            // 
            this.btnqtthemnhp.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemnhp.Name = "btnqtthemnhp";
            this.btnqtthemnhp.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemnhp.TabIndex = 0;
            this.btnqtthemnhp.Text = "Thêm";
            this.btnqtthemnhp.UseVisualStyleBackColor = true;
            this.btnqtthemnhp.Click += new System.EventHandler(this.btnqtthemnhp_Click);
            // 
            // btnqtsuanhp
            // 
            this.btnqtsuanhp.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuanhp.Name = "btnqtsuanhp";
            this.btnqtsuanhp.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuanhp.TabIndex = 1;
            this.btnqtsuanhp.Text = "Sửa";
            this.btnqtsuanhp.UseVisualStyleBackColor = true;
            this.btnqtsuanhp.Click += new System.EventHandler(this.btnqtsuanhp_Click);
            // 
            // btnqtxoanhp
            // 
            this.btnqtxoanhp.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoanhp.Name = "btnqtxoanhp";
            this.btnqtxoanhp.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoanhp.TabIndex = 2;
            this.btnqtxoanhp.Text = "Xóa";
            this.btnqtxoanhp.UseVisualStyleBackColor = true;
            this.btnqtxoanhp.Click += new System.EventHandler(this.btnqtxoanhp_Click);
            // 
            // btnqtghinhp
            // 
            this.btnqtghinhp.Location = new System.Drawing.Point(3, 228);
            this.btnqtghinhp.Name = "btnqtghinhp";
            this.btnqtghinhp.Size = new System.Drawing.Size(144, 69);
            this.btnqtghinhp.TabIndex = 3;
            this.btnqtghinhp.Text = "Ghi";
            this.btnqtghinhp.UseVisualStyleBackColor = true;
            this.btnqtghinhp.Click += new System.EventHandler(this.btnqtghinhp_Click);
            // 
            // btnqthuynhp
            // 
            this.btnqthuynhp.Location = new System.Drawing.Point(3, 303);
            this.btnqthuynhp.Name = "btnqthuynhp";
            this.btnqthuynhp.Size = new System.Drawing.Size(144, 69);
            this.btnqthuynhp.TabIndex = 4;
            this.btnqthuynhp.Text = "Hủy";
            this.btnqthuynhp.UseVisualStyleBackColor = true;
            this.btnqthuynhp.Click += new System.EventHandler(this.btnqthuynhp_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.cboqtmakhdt);
            this.pnlqttruong.Controls.Add(this.cboqtmagv);
            this.pnlqttruong.Controls.Add(this.label5);
            this.pnlqttruong.Controls.Add(this.label4);
            this.pnlqttruong.Controls.Add(this.cboqtmahp);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqttennhp);
            this.pnlqttruong.Controls.Add(this.txtqtmanhp);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(172, 3);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(608, 222);
            this.pnlqttruong.TabIndex = 7;
            // 
            // cboqtmakhdt
            // 
            this.cboqtmakhdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmakhdt.FormattingEnabled = true;
            this.cboqtmakhdt.Location = new System.Drawing.Point(335, 176);
            this.cboqtmakhdt.Name = "cboqtmakhdt";
            this.cboqtmakhdt.Size = new System.Drawing.Size(263, 28);
            this.cboqtmakhdt.TabIndex = 9;
            // 
            // cboqtmagv
            // 
            this.cboqtmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmagv.FormattingEnabled = true;
            this.cboqtmagv.Location = new System.Drawing.Point(335, 119);
            this.cboqtmagv.Name = "cboqtmagv";
            this.cboqtmagv.Size = new System.Drawing.Size(208, 28);
            this.cboqtmagv.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã KHDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã giảng viên:";
            // 
            // cboqtmahp
            // 
            this.cboqtmahp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboqtmahp.FormattingEnabled = true;
            this.cboqtmahp.Location = new System.Drawing.Point(25, 120);
            this.cboqtmahp.Name = "cboqtmahp";
            this.cboqtmahp.Size = new System.Drawing.Size(208, 28);
            this.cboqtmahp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã học phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm HP:";
            // 
            // txtqttennhp
            // 
            this.txtqttennhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqttennhp.Location = new System.Drawing.Point(335, 38);
            this.txtqttennhp.Name = "txtqttennhp";
            this.txtqttennhp.Size = new System.Drawing.Size(208, 27);
            this.txtqttennhp.TabIndex = 3;
            // 
            // txtqtmanhp
            // 
            this.txtqtmanhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtmanhp.Location = new System.Drawing.Point(25, 38);
            this.txtqtmanhp.Name = "txtqtmanhp";
            this.txtqtmanhp.Size = new System.Drawing.Size(208, 27);
            this.txtqtmanhp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm HP:";
            // 
            // frmqtnhomhp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.floqtnut);
            this.Controls.Add(this.pnlqttruong);
            this.Name = "frmqtnhomhp";
            this.Text = "NhomHP";
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqtnhp)).EndInit();
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqtnhp;
        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemnhp;
        private System.Windows.Forms.Button btnqtsuanhp;
        private System.Windows.Forms.Button btnqtxoanhp;
        private System.Windows.Forms.Button btnqtghinhp;
        private System.Windows.Forms.Button btnqthuynhp;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.ComboBox cboqtmahp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqttennhp;
        private System.Windows.Forms.TextBox txtqtmanhp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboqtmakhdt;
        private System.Windows.Forms.ComboBox cboqtmagv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}