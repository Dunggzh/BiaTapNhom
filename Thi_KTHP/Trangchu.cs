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
    public partial class frmtrangchu : Form
    {
        public frmtrangchu()
        {
            InitializeComponent();
        }
        //private Form currentformchild;
        //private void Openformchild(Form childform)
        //{
        //    if (currentformchild != null)
        //    {
        //        currentformchild.Close();
        //    }
        //    currentformchild = childform;
        //    childform.TopLevel = false;
        //    childform.FormBorderStyle = FormBorderStyle.None;
        //    childform.Dock = DockStyle.Fill;
        //    pnltrangchu.Controls.Add(childform);
        //    pnltrangchu.Tag = childform;
        //    childform.BringToFront();
        //    childform.Show();
        //}
        private void mnudangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdangnhap dangnhap = new frmdangnhap();
            dangnhap.ShowDialog();
            //Openformchild(new frmdangnhap());
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát Chương Trình", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Application.Exit();
            }
    }
    }
}
