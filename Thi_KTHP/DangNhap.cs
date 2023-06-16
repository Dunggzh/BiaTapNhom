using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_KTHP
{
    public partial class frmdangnhap : Form
    {

        public delegate void truyendl();
        public truyendl truyenchocha;
        public frmdangnhap()
        {
            InitializeComponent();
            reset();
        }
        private int k=0;
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void reset()
        {
            txtusername.Text = "72DCHT20070";
            txtpass.Text = "1";
            txtusername.Focus();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            errusername.Clear();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            errpass.Clear();
        }
        public void timkiem(string query,Form tg)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (truyenchocha != null)
                {
                    truyenchocha();
                    tg.ShowDialog();
                    Application.Exit();
                }
                k = 1;
            }
            reader.Close();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (txtusername.Text == "")
            {
                errusername.SetError(txtusername, "Chưa Nhập UserName");
                a = 1;
            }
            if (txtpass.Text == "")
            {
                errpass.SetError(txtpass, "Chưa Nhập Pass");
                b = 1;
            }
            if (a == 0 && b == 0)
            {
                frmtrangchuqt frmtrangchuqt = new frmtrangchuqt(txtusername.Text,txtpass.Text);
                frmtrangchusv frmtrangchusv=new frmtrangchusv(txtusername.Text, txtpass.Text);
                frmtrangchugv frmtrangchugv = new frmtrangchugv(txtusername.Text, txtpass.Text);
                string querysv = "select * from TaiKhoan where Username='" + txtusername.Text.Trim() + "'  and  Pass= '" + txtpass.Text.Trim() + "'  and quyen = 0";
                string queryqt = "select * from TaiKhoan where Username='" + txtusername.Text.Trim() + "'  and  Pass= '" + txtpass.Text.Trim() + "'  and quyen = 1";
                string querygv = "select * from TaiKhoan where Username='" + txtusername.Text.Trim() + "'  and  Pass= '" + txtpass.Text.Trim() + "'  and quyen = 2";

                timkiem(querysv, frmtrangchusv);
                timkiem(queryqt, frmtrangchuqt);
                timkiem(querygv, frmtrangchugv);
                if (k == 0)
                {
                    MessageBox.Show("Khong tin thay tai khoan");
                }
            }

            reset();
                conn.Close();
            
        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}
//test up code 
// test 
