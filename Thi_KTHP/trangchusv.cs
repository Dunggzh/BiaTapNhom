using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_KTHP
{
    public partial class frmtrangchusv : Form
    {
        private string username;
        private string pass;
        public frmtrangchusv()
        {
            InitializeComponent();
        }
        public frmtrangchusv(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }

        private Form currentformchild;
        private void Openformchild(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlform.Controls.Add(childform);
            pnlform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                this.Hide();
                frmtrangchu frmtrangchu = new frmtrangchu(new frmdangnhap());
                frmtrangchu.ShowDialog();      
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtincanhan(this.username, this.pass));
        }

        private void mnuchinhsua_Click(object sender, EventArgs e)
        {
            frmsuathongtincanhan  thongtincanhan= new frmsuathongtincanhan(this.username, this.pass);
            thongtincanhan.ShowDialog();
        }

        private void mnudoimk_Click(object sender, EventArgs e)
        {
            frmdoimatkhau doimk = new frmdoimatkhau(this.username, this.pass);
            doimk.ShowDialog();
        }

        private void mnudiem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmdiemsv(this.username, this.pass));
        }

        private void mnuhocphan_Click(object sender, EventArgs e)
        {
            Openformchild(new frmhocphansv());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmdoimatkhau(this.username, this.pass));
        }

        private void điểmTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmdiemtonghop(this.username,this.pass));
        }

        private void mnutrangchuht_Click(object sender, EventArgs e)
        {
            Openformchild(new frmHotrosv());
        }
    }
}
