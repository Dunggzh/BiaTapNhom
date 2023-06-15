namespace Thi_KTHP
{
    partial class frmthongtintk
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
            this.grbthongtintk = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.chkshowpass = new System.Windows.Forms.CheckBox();
            this.grbthongtintk.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbthongtintk
            // 
            this.grbthongtintk.Controls.Add(this.chkshowpass);
            this.grbthongtintk.Controls.Add(this.txtpass);
            this.grbthongtintk.Controls.Add(this.txtusername);
            this.grbthongtintk.Controls.Add(this.label2);
            this.grbthongtintk.Controls.Add(this.label1);
            this.grbthongtintk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtintk.Location = new System.Drawing.Point(127, 131);
            this.grbthongtintk.Name = "grbthongtintk";
            this.grbthongtintk.Size = new System.Drawing.Size(573, 135);
            this.grbthongtintk.TabIndex = 0;
            this.grbthongtintk.TabStop = false;
            this.grbthongtintk.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Người Dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(208, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(247, 34);
            this.txtusername.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(208, 83);
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = true;
            this.txtpass.Size = new System.Drawing.Size(247, 34);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // chkshowpass
            // 
            this.chkshowpass.AutoSize = true;
            this.chkshowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpass.Location = new System.Drawing.Point(461, 84);
            this.chkshowpass.Name = "chkshowpass";
            this.chkshowpass.Size = new System.Drawing.Size(96, 33);
            this.chkshowpass.TabIndex = 1;
            this.chkshowpass.Text = "Show";
            this.chkshowpass.UseVisualStyleBackColor = true;
            this.chkshowpass.CheckedChanged += new System.EventHandler(this.chkshowpass_CheckedChanged);
            // 
            // frmthongtintk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbthongtintk);
            this.Name = "frmthongtintk";
            this.Text = "Tài Khoản";
            this.grbthongtintk.ResumeLayout(false);
            this.grbthongtintk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtintk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkshowpass;
    }
}