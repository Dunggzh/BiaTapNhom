namespace Thi_KTHP
{
    partial class frmdoimatkhau
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
            this.btndoimk = new System.Windows.Forms.Button();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loimkcu = new System.Windows.Forms.ErrorProvider(this.components);
            this.loimkmoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhaplaimk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loinhaplaimk = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loimkcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loimkmoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loinhaplaimk)).BeginInit();
            this.SuspendLayout();
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(205, 212);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(96, 48);
            this.btndoimk.TabIndex = 4;
            this.btndoimk.Text = "Đổi";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(317, 114);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(100, 30);
            this.txtmkmoi.TabIndex = 3;
            this.txtmkmoi.TextChanged += new System.EventHandler(this.txtmkmoi_TextChanged);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(317, 69);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(100, 30);
            this.txtmkcu.TabIndex = 2;
            this.txtmkcu.TextChanged += new System.EventHandler(this.txtmkcu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // loimkcu
            // 
            this.loimkcu.ContainerControl = this;
            // 
            // loimkmoi
            // 
            this.loimkmoi.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnhaplaimk);
            this.groupBox1.Controls.Add(this.btndoimk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmkmoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmkcu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản Mật Khẩu";
            // 
            // txtnhaplaimk
            // 
            this.txtnhaplaimk.Location = new System.Drawing.Point(317, 160);
            this.txtnhaplaimk.Name = "txtnhaplaimk";
            this.txtnhaplaimk.Size = new System.Drawing.Size(100, 30);
            this.txtnhaplaimk.TabIndex = 5;
            this.txtnhaplaimk.TextChanged += new System.EventHandler(this.txtnhaplaimk_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập Lại mật khẩu mới:";
            // 
            // loinhaplaimk
            // 
            this.loinhaplaimk.ContainerControl = this;
            // 
            // frmdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmdoimatkhau";
            this.Text = "Doimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.loimkcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loimkmoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loinhaplaimk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider loimkcu;
        private System.Windows.Forms.ErrorProvider loimkmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider loinhaplaimk;
        private System.Windows.Forms.TextBox txtnhaplaimk;
    }
}