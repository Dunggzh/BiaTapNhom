using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thi_KTHP
{
    public partial class frmqtdoimk : Form
    {
        private string username;
        private string pass;
        public frmqtdoimk()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        public frmqtdoimk(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked)
            {
                txtmkcu.UseSystemPasswordChar = false;
                txtmkmoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtmkcu.UseSystemPasswordChar = true;
                txtmkmoi.UseSystemPasswordChar = true;
            }
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmkcu.Text.Equals(this.pass))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "update TaiKhoan set pass='" + txtmkmoi.Text.Trim() + "' where UserName='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Update success");
                    }
                    else
                    {
                        MessageBox.Show("Update error");
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Cũ Không Đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
