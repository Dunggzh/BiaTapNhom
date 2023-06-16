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
    public partial class frmtrangchugv : Form
    {
        public frmtrangchugv()
        {
            InitializeComponent();
        }
        private string username;
        private string pass;
        public frmtrangchugv(string username, string pass)
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
            pnlqlgv.Controls.Add(childform);
            pnlqlgv.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
 

        private void frmtrangchugv_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Openformchild(new frmquanlysinhvien(this.username, this.pass));
        }

        private void quảnLýĐiểmSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new QuanLyDiem_gv(this.username, this.pass));
        }

        private void thôngTinHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtinhp(this.username, this.pass));
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtin_gv(this.username,this.pass));
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtin_gv(this.username, this.pass));
        }

        private void sửaThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmsuathongtincanhan_gv(this.username, this.pass));
        }

        private void đăngXuấtThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                this.Hide();
                frmtrangchu frmtrangchu = new frmtrangchu(new frmdangnhap());
                frmtrangchu.ShowDialog();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Khỏi Hệ Thống?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new ThongKediem_Gv(this.username, this.pass));
        }
    }
}
