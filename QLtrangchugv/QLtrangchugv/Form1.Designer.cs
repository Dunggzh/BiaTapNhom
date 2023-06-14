namespace QLtrangchugv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSinhViênToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐiểmSinhViênToolStripMenuItem = new ToolStripMenuItem();
            thôngTinKhoáHọcToolStripMenuItem = new ToolStripMenuItem();
            mnsttcn = new ToolStripMenuItem();
            pnlqlgv = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, quảnLýSinhViênToolStripMenuItem, quảnLýĐiểmSinhViênToolStripMenuItem, thôngTinKhoáHọcToolStripMenuItem, mnsttcn });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1095, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            quảnLýSinhViênToolStripMenuItem.Size = new Size(134, 24);
            quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            quảnLýSinhViênToolStripMenuItem.Click += quảnLýSinhViênToolStripMenuItem_Click;
            // 
            // quảnLýĐiểmSinhViênToolStripMenuItem
            // 
            quảnLýĐiểmSinhViênToolStripMenuItem.Name = "quảnLýĐiểmSinhViênToolStripMenuItem";
            quảnLýĐiểmSinhViênToolStripMenuItem.Size = new Size(172, 24);
            quảnLýĐiểmSinhViênToolStripMenuItem.Text = "Quản lý điểm sinh viên";
            // 
            // thôngTinKhoáHọcToolStripMenuItem
            // 
            thôngTinKhoáHọcToolStripMenuItem.Name = "thôngTinKhoáHọcToolStripMenuItem";
            thôngTinKhoáHọcToolStripMenuItem.Size = new Size(151, 24);
            thôngTinKhoáHọcToolStripMenuItem.Text = "Thông tin học phần";
            thôngTinKhoáHọcToolStripMenuItem.Click += thôngTinKhoáHọcToolStripMenuItem_Click;
            // 
            // mnsttcn
            // 
            mnsttcn.Name = "mnsttcn";
            mnsttcn.Size = new Size(141, 24);
            mnsttcn.Text = "Thông tin cá nhân";
            mnsttcn.Click += mnsttcn_Click;
            // 
            // pnlqlgv
            // 
            pnlqlgv.Location = new Point(12, 31);
            pnlqlgv.Name = "pnlqlgv";
            pnlqlgv.Size = new Size(1071, 458);
            pnlqlgv.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 501);
            Controls.Add(pnlqlgv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmSinhViênToolStripMenuItem;
        private ToolStripMenuItem thôngTinKhoáHọcToolStripMenuItem;
        private ToolStripMenuItem mnsttcn;
        private Panel pnlqlgv;
    }
}