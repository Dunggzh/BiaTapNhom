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
    public partial class frmtrangchuqt : Form
    {
        public frmtrangchuqt()
        {
            InitializeComponent();
        }
        private string username;
        private string pass;
        public frmtrangchuqt(string username, string pass)
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

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkhoa());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
        }

        private void ngànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtnganh());
        }

        private void họcPhẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqthocphan());
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtlop());
        }

        private void khóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkhoahoc());
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtgv());
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtsv());
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtdiem());
        }

        private void kỳHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkyhoc());
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
    }
}
