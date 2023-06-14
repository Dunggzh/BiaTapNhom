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
      

        private void mnsttcn_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtingv());
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmquanlysinhvien());
        }

        private void thôngTinKhoáHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmthongtinhp());
        }

        private void frmtrangchugv_Load(object sender, EventArgs e)
        {

        }
    }
}
