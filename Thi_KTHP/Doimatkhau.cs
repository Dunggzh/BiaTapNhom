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
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);

        private void btndoimk_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0,f=0,g=0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (txtmkcu.Text.Equals(txtmkmoi.Text))
            {
                loimkmoi.SetError(txtmkmoi, "Sai cú pháp!"); a = 1;
            }
            if (txtmkcu.Text.Equals(""))
            {
                loimkcu.SetError(txtmkcu, "Sai cú pháp!"); b = 1;
            }
            if (txtmkmoi.Text.Equals(""))
            {
                loimkmoi.SetError(txtmkmoi, "Sai cú pháp!"); c = 1;
            }
            if (txtnhaplaimk.Text.Equals(""))
            {
                loinhaplaimk.SetError(txtnhaplaimk, "Sai cú pháp!"); d = 1;
            }
            if (txtnhaplaimk.Text.Equals(txtmkmoi.Text) == false)
            {
                loinhaplaimk.SetError(txtnhaplaimk, "Nhập Lại Mật Khẩu Không Trùng Khớp");f = 1;
            }
            
           if(txtmkcu.Text.Equals(this.pass)!=true) {
                loimkcu.SetError(txtmkcu, "Mật Khẩu Cũ Chưa Chính Xác!");g = 1;
            }
            if (a == 0 && b == 0 && c == 0 && d==0&& f ==0&&g==0)
            {
                loimkmoi.Clear();
                loimkcu.Clear();
                loinhaplaimk.Clear();
                if (txtmkcu.Text.Equals(this.pass))
                {
                    DataTable dt = new DataTable();
                    string query = "update TaiKhoan set pass='" + txtmkmoi.Text + "' where UserName='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var ktra = cmd.ExecuteNonQuery();
                    if (ktra > 0)
                    {
                        this.pass=txtmkmoi.Text;
                        MessageBox.Show("Sửa Thành Công");
                        txtmkcu.Text = "";
                        txtmkmoi.Text = "";
                        txtnhaplaimk.Text = "";   
                    }
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

        private void txtnhaplaimk_TextChanged(object sender, EventArgs e)
        {
           loinhaplaimk.Clear();
        }
    }
}
