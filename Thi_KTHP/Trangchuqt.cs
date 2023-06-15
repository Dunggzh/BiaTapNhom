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

        private void mnutc_Click(object sender, EventArgs e)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
        }

        private void mnunddx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmtrangchu frmtrangchu = new frmtrangchu(new frmdangnhap());
                frmtrangchu.ShowDialog();
            }
        }

        private void mnuqlk_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkhoa());
        }

        private void mnuqln_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtnganh());
        }

        private void mnuqlkhoahoc_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkhoahoc());
        }
        private void mnuqlhp_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqthocphan());
        }

        private void mnuqllop_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtlop());
        }

        private void mnuqlgv_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtgv());
        }

        private void mnuqlsv_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtsv());
        }

        private void mnuqldiem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtdiem());
        }

        private void mnuqlkhdt_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtkhdt());
        }

        private void mnuqlnhomhp_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtnhomhp());
        }

        private void mnundthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Khỏi Hệ Thống?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnunddoimk_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqtdoimk(username, pass));
        }

        private void mnuht_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqthotro());
            
        }

        private void mnuqltaikhoan_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqttaikhoan(username, pass));
        }

        private void mnundtk_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtintk(username, pass));
        }
    }
}
