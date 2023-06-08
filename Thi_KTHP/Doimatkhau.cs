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
    public partial class frmdoimatkhau : Form
    {
        private string username;
        private string pass;
        public frmdoimatkhau()
        {
            InitializeComponent();
        }
        public frmdoimatkhau(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        SqlConnection conn = new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");

        private void btndoimk_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (txtmkcu.Text.Equals(txtmkmoi.Text))
            {
                loimkmoi.SetError(txtmkmoi, "mk moi khong duoc trung mk cu!"); a = 1;
            }
            if (txtmkcu.Text.Equals(""))
            {
                loimkcu.SetError(txtmkcu, "Khong duoc de trong o mk cu"); b = 1;
            }
            if (txtmkmoi.Text.Equals(""))
            {
                loimkmoi.SetError(txtmkmoi, "Khong duoc de trong o mk cu"); c = 1;
            }
            if (a == 0 && b == 0 && c == 0)
            {
                loimkmoi.Clear();
                loimkcu.Clear();
                if (txtmkcu.Text.Equals(this.pass))
                {
                    DataTable dt = new DataTable();
                    string query = "update TaiKhoan set pass='" + txtmkmoi.Text + "' where UserName='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var ktra = cmd.ExecuteNonQuery();
                    if (ktra > 0)
                    {
                        MessageBox.Show("Sua thanh cong");
                        txtmkcu.Text = "";
                        txtmkmoi.Text = "";
                    }
                }
                else
                {
                    loimkcu.SetError(txtmkcu, "Mat Khau Cu Chua Chinh Xac!");
                }
            }

            conn.Close();
        }

        private void txtmkcu_TextChanged(object sender, EventArgs e)
        {
            loimkcu.Clear();
        }

        private void txtmkmoi_TextChanged(object sender, EventArgs e)
        {
            loimkmoi.Clear();
        }
    }
}
