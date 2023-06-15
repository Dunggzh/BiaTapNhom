namespace Thi_KTHP
{
    partial class frmqtdoimk
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
            this.grbdoimk = new System.Windows.Forms.GroupBox();
            this.chkshowpass = new System.Windows.Forms.CheckBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbdoimk.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdoimk
            // 
            this.grbdoimk.Controls.Add(this.txtusername);
            this.grbdoimk.Controls.Add(this.label3);
            this.grbdoimk.Controls.Add(this.btnxacnhan);
            this.grbdoimk.Controls.Add(this.chkshowpass);
            this.grbdoimk.Controls.Add(this.txtmkmoi);
            this.grbdoimk.Controls.Add(this.txtmkcu);
            this.grbdoimk.Controls.Add(this.label2);
            this.grbdoimk.Controls.Add(this.label1);
            this.grbdoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdoimk.Location = new System.Drawing.Point(105, 66);
            this.grbdoimk.Name = "grbdoimk";
            this.grbdoimk.Size = new System.Drawing.Size(573, 254);
            this.grbdoimk.TabIndex = 1;
            this.grbdoimk.TabStop = false;
            this.grbdoimk.Text = "Thông tin";
            // 
            // chkshowpass
            // 
            this.chkshowpass.AutoSize = true;
            this.chkshowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpass.Location = new System.Drawing.Point(461, 142);
            this.chkshowpass.Name = "chkshowpass";
            this.chkshowpass.Size = new System.Drawing.Size(96, 33);
            this.chkshowpass.TabIndex = 1;
            this.chkshowpass.Text = "Show";
            this.chkshowpass.UseVisualStyleBackColor = true;
            this.chkshowpass.CheckedChanged += new System.EventHandler(this.chkshowpass_CheckedChanged);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(208, 140);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(247, 34);
            this.txtmkmoi.TabIndex = 3;
            this.txtmkmoi.UseSystemPasswordChar = true;
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(208, 92);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(247, 34);
            this.txtmkcu.TabIndex = 2;
            this.txtmkcu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ:";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(208, 197);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(214, 43);
            this.btnxacnhan.TabIndex = 2;
            this.btnxacnhan.Text = "Xác Nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(208, 44);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(247, 34);
            this.txtusername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Người Dùng:";
            // 
            // frmqtdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbdoimk);
            this.Name = "frmqtdoimk";
            this.Text = "Đổi mật khẩu";
            this.grbdoimk.ResumeLayout(false);
            this.grbdoimk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdoimk;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.CheckBox chkshowpass;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
    }
}