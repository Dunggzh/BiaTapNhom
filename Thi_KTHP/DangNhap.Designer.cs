namespace Thi_KTHP
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.mnu2 = new System.Windows.Forms.MenuStrip();
            this.mnutrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.errpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errusername = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnu2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errusername)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu2
            // 
            this.mnu2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutrangchu,
            this.mnuthoat});
            this.mnu2.Location = new System.Drawing.Point(0, 0);
            this.mnu2.Name = "mnu2";
            this.mnu2.Size = new System.Drawing.Size(800, 28);
            this.mnu2.TabIndex = 0;
            this.mnu2.Text = "menuStrip1";
            // 
            // mnutrangchu
            // 
            this.mnutrangchu.Name = "mnutrangchu";
            this.mnutrangchu.Size = new System.Drawing.Size(87, 24);
            this.mnutrangchu.Text = "Trang chủ";
            this.mnutrangchu.Click += new System.EventHandler(this.mnutrangchu_Click);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(61, 24);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 349);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ĐĂNG NHẬP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btndangnhap);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtpass);
            this.panel4.Controls.Add(this.txtusername);
            this.panel4.Location = new System.Drawing.Point(262, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 118);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndangnhap.Location = new System.Drawing.Point(68, 87);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(104, 28);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pass";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.Location = new System.Drawing.Point(109, 45);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(139, 22);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.Location = new System.Drawing.Point(109, 14);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 22);
            this.txtusername.TabIndex = 3;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // errpass
            // 
            this.errpass.ContainerControl = this;
            // 
            // errusername
            // 
            this.errusername.ContainerControl = this;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mnu2);
            this.MainMenuStrip = this.mnu2;
            this.Name = "frmdangnhap";
            this.Text = "DangNhap";
            this.mnu2.ResumeLayout(false);
            this.mnu2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errusername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu2;
        private System.Windows.Forms.ToolStripMenuItem mnutrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ErrorProvider errpass;
        private System.Windows.Forms.ErrorProvider errusername;
    }
}