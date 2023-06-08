using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_KTHP
{
    public partial class frmtrangchu : Form
    {
        public frmtrangchu()
        {
            InitializeComponent();
        }
        public frmtrangchu(frmdangnhap dangnhap)
        {
            InitializeComponent();
            mnudangnhap.Visible = false;
            frmdangnhap dn = new frmdangnhap();
            dn.truyenchocha = new frmdangnhap.truyendl(nhandl);
            openformchild(dn);
        }
        public Form currentformchild;
        public void openformchild(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnltrangchu.Controls.Add(childform);
            pnltrangchu.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void mnudangnhap_Click(object sender, EventArgs e)
        {
            mnudangnhap.Visible = false;
            frmdangnhap dn=new frmdangnhap();
            dn.truyenchocha = new frmdangnhap.truyendl(nhandl);
            openformchild(dn);
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Chương Trình", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnutrangchu_Click(object sender, EventArgs e)
        {
            if(currentformchild != null)
            {
                currentformchild.Hide();
            }
            
            mnudangnhap.Visible=true;
        }
   private void nhandl()
        {
            this.Hide();
        }
        private void frmtrangchu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
