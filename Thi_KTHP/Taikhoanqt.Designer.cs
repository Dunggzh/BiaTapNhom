﻿namespace Thi_KTHP
{
    partial class frmqttaikhoan
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
            this.dgvqttaikhoan = new System.Windows.Forms.DataGridView();
            this.floqtnut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqtthemtk = new System.Windows.Forms.Button();
            this.btnqtsuatk = new System.Windows.Forms.Button();
            this.btnqtxoatk = new System.Windows.Forms.Button();
            this.btnqtghitk = new System.Windows.Forms.Button();
            this.btnqthuytk = new System.Windows.Forms.Button();
            this.pnlqttruong = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqtpass = new System.Windows.Forms.TextBox();
            this.txtqtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtquyen = new System.Windows.Forms.TextBox();
            this.pnlqtcsdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqttaikhoan)).BeginInit();
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
            this.pnlqtcsdl.Controls.Add(this.dgvqttaikhoan);
            this.pnlqtcsdl.Location = new System.Drawing.Point(172, 159);
            this.pnlqtcsdl.Name = "pnlqtcsdl";
            this.pnlqtcsdl.Size = new System.Drawing.Size(609, 315);
            this.pnlqtcsdl.TabIndex = 8;
            // 
            // dgvqttaikhoan
            // 
            this.dgvqttaikhoan.AllowUserToAddRows = false;
            this.dgvqttaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvqttaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqttaikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvqttaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvqttaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqttaikhoan.Location = new System.Drawing.Point(3, 60);
            this.dgvqttaikhoan.Name = "dgvqttaikhoan";
            this.dgvqttaikhoan.RowHeadersWidth = 51;
            this.dgvqttaikhoan.RowTemplate.Height = 24;
            this.dgvqttaikhoan.Size = new System.Drawing.Size(603, 252);
            this.dgvqttaikhoan.TabIndex = 4;
            this.dgvqttaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqttaikhoan_CellClick);
            // 
            // floqtnut
            // 
            this.floqtnut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.floqtnut.Controls.Add(this.btnqtthemtk);
            this.floqtnut.Controls.Add(this.btnqtsuatk);
            this.floqtnut.Controls.Add(this.btnqtxoatk);
            this.floqtnut.Controls.Add(this.btnqtghitk);
            this.floqtnut.Controls.Add(this.btnqthuytk);
            this.floqtnut.Location = new System.Drawing.Point(3, 1);
            this.floqtnut.Name = "floqtnut";
            this.floqtnut.Size = new System.Drawing.Size(163, 470);
            this.floqtnut.TabIndex = 6;
            // 
            // btnqtthemtk
            // 
            this.btnqtthemtk.Location = new System.Drawing.Point(3, 3);
            this.btnqtthemtk.Name = "btnqtthemtk";
            this.btnqtthemtk.Size = new System.Drawing.Size(144, 69);
            this.btnqtthemtk.TabIndex = 0;
            this.btnqtthemtk.Text = "Thêm";
            this.btnqtthemtk.UseVisualStyleBackColor = true;
            this.btnqtthemtk.Click += new System.EventHandler(this.btnqtthemtk_Click);
            // 
            // btnqtsuatk
            // 
            this.btnqtsuatk.Location = new System.Drawing.Point(3, 78);
            this.btnqtsuatk.Name = "btnqtsuatk";
            this.btnqtsuatk.Size = new System.Drawing.Size(144, 69);
            this.btnqtsuatk.TabIndex = 1;
            this.btnqtsuatk.Text = "Sửa";
            this.btnqtsuatk.UseVisualStyleBackColor = true;
            this.btnqtsuatk.Click += new System.EventHandler(this.btnqtsuatk_Click);
            // 
            // btnqtxoatk
            // 
            this.btnqtxoatk.Location = new System.Drawing.Point(3, 153);
            this.btnqtxoatk.Name = "btnqtxoatk";
            this.btnqtxoatk.Size = new System.Drawing.Size(144, 69);
            this.btnqtxoatk.TabIndex = 2;
            this.btnqtxoatk.Text = "Xóa";
            this.btnqtxoatk.UseVisualStyleBackColor = true;
            this.btnqtxoatk.Click += new System.EventHandler(this.btnqtxoatk_Click);
            // 
            // btnqtghitk
            // 
            this.btnqtghitk.Location = new System.Drawing.Point(3, 228);
            this.btnqtghitk.Name = "btnqtghitk";
            this.btnqtghitk.Size = new System.Drawing.Size(144, 69);
            this.btnqtghitk.TabIndex = 3;
            this.btnqtghitk.Text = "Ghi";
            this.btnqtghitk.UseVisualStyleBackColor = true;
            this.btnqtghitk.Click += new System.EventHandler(this.btnqtghitk_Click);
            // 
            // btnqthuytk
            // 
            this.btnqthuytk.Location = new System.Drawing.Point(3, 303);
            this.btnqthuytk.Name = "btnqthuytk";
            this.btnqthuytk.Size = new System.Drawing.Size(144, 69);
            this.btnqthuytk.TabIndex = 4;
            this.btnqthuytk.Text = "Hủy";
            this.btnqthuytk.UseVisualStyleBackColor = true;
            this.btnqthuytk.Click += new System.EventHandler(this.btnqthuytk_Click);
            // 
            // pnlqttruong
            // 
            this.pnlqttruong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlqttruong.Controls.Add(this.txtqtquyen);
            this.pnlqttruong.Controls.Add(this.label3);
            this.pnlqttruong.Controls.Add(this.label1);
            this.pnlqttruong.Controls.Add(this.txtqtpass);
            this.pnlqttruong.Controls.Add(this.txtqtusername);
            this.pnlqttruong.Controls.Add(this.label2);
            this.pnlqttruong.Location = new System.Drawing.Point(172, 1);
            this.pnlqttruong.Name = "pnlqttruong";
            this.pnlqttruong.Size = new System.Drawing.Size(609, 152);
            this.pnlqttruong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quyền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng:";
            // 
            // txtqtpass
            // 
            this.txtqtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtpass.Location = new System.Drawing.Point(335, 38);
            this.txtqtpass.Name = "txtqtpass";
            this.txtqtpass.Size = new System.Drawing.Size(208, 27);
            this.txtqtpass.TabIndex = 3;
            // 
            // txtqtusername
            // 
            this.txtqtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtusername.Location = new System.Drawing.Point(25, 38);
            this.txtqtusername.Name = "txtqtusername";
            this.txtqtusername.Size = new System.Drawing.Size(208, 27);
            this.txtqtusername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtqtquyen
            // 
            this.txtqtquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtquyen.Location = new System.Drawing.Point(25, 111);
            this.txtqtquyen.Name = "txtqtquyen";
            this.txtqtquyen.Size = new System.Drawing.Size(208, 27);
            this.txtqtquyen.TabIndex = 5;
            // 
            // frmqttaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.pnlqtcsdl);
            this.Controls.Add(this.floqtnut);
            this.Controls.Add(this.pnlqttruong);
            this.Name = "frmqttaikhoan";
            this.Text = "Quản lý tài khoản";
            this.pnlqtcsdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqttaikhoan)).EndInit();
            this.floqtnut.ResumeLayout(false);
            this.pnlqttruong.ResumeLayout(false);
            this.pnlqttruong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlqtcsdl;
        private System.Windows.Forms.DataGridView dgvqttaikhoan;
        private System.Windows.Forms.FlowLayoutPanel floqtnut;
        private System.Windows.Forms.Button btnqtthemtk;
        private System.Windows.Forms.Button btnqtsuatk;
        private System.Windows.Forms.Button btnqtxoatk;
        private System.Windows.Forms.Button btnqtghitk;
        private System.Windows.Forms.Button btnqthuytk;
        private System.Windows.Forms.Panel pnlqttruong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtqtpass;
        private System.Windows.Forms.TextBox txtqtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqtquyen;
    }
}