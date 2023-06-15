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
    public partial class frmthongtintk : Form
    {
        private string username;
        private string pass;
        public frmthongtintk()
        {
            InitializeComponent();

        }
        public frmthongtintk(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
            txtusername.Text = username;
            txtpass.Text = pass;
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkshowpass.Checked)
            {
                txtpass.UseSystemPasswordChar= false;
            }
            else
            {
                txtpass.UseSystemPasswordChar= true;
            }
        }
    }
}
