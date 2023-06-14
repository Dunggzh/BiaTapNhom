using System.Windows.Forms;

namespace Thi_KTHP
{
    partial class frmtrangchugv
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlqlgv = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýĐiểmSinhToolStripMenuItem,
            this.thôngTinHọcToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // quảnLýĐiểmSinhToolStripMenuItem
            // 
            this.quảnLýĐiểmSinhToolStripMenuItem.Name = "quảnLýĐiểmSinhToolStripMenuItem";
            this.quảnLýĐiểmSinhToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.quảnLýĐiểmSinhToolStripMenuItem.Text = "Quản lý điểm sinh ";
            // 
            // thôngTinHọcToolStripMenuItem
            // 
            this.thôngTinHọcToolStripMenuItem.Name = "thôngTinHọcToolStripMenuItem";
            this.thôngTinHọcToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.thôngTinHọcToolStripMenuItem.Text = "Thông tin học ";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // pnlqlgv
            // 
            this.pnlqlgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlqlgv.Location = new System.Drawing.Point(0, 28);
            this.pnlqlgv.Name = "pnlqlgv";
            this.pnlqlgv.Size = new System.Drawing.Size(800, 422);
            this.pnlqlgv.TabIndex = 1;
            // 
            // frmtrangchugv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlqlgv);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmtrangchugv";
            this.Text = "trangchuhv";
            this.Load += new System.EventHandler(this.frmtrangchugv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐiểmSinhToolStripMenuItem;
        private ToolStripMenuItem thôngTinHọcToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private Panel pnlqlgv;
    }
}