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

namespace Thi_KTHP
{
    public partial class frmdangnhap : Form
    {
        public delegate void truyendl(string nd);
        public truyendl truyenchocha;
        public frmdangnhap()
        {
            InitializeComponent();    
        }

        SqlDataReader reader;
        SqlConnection conn = new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void reset()
        {
            txtusername.Text = "";
            txtpass.Text = "";
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
            if (a == 0 || b == 0)
            {

                string query = "select * from TaiKhoan where Username='" + txtusername.Text.Trim() + "'  and  Pass= '" + txtpass.Text.Trim() + "'  and quyen = 0";

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
                        truyenchocha("tat");
                        frmtrangchusv frmtrangchusv = new frmtrangchusv();
                        frmtrangchusv.ShowDialog();
                        Application.Exit();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Khong tim thay tai khoan ");
                }
                reset();
                conn.Close();
            }
        }
    }
}
