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
    
    public partial class frmthongtincanhan : Form
    {
        private string username;
        private string pass;
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        public frmthongtincanhan()
        {
            InitializeComponent();
        }

        public frmthongtincanhan(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }

        private void frmthongtincanhan_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            string query1 = "select * from SinhVien where MaSinhVien='" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                txtmsv.Text = dt1.Rows[0]["MaSinhVien"].ToString();
                txtht.Text = dt1.Rows[0]["Tensv"].ToString();
                txttenlop.Text = dt1.Rows[0]["TenLop"].ToString();
                txtquequan.Text = dt1.Rows[0]["QueQuan"].ToString();
                txtnoisinh.Text = dt1.Rows[0]["NoiSinh"].ToString();
                if (dt1.Rows[0]["GioiTinh"].ToString().Equals("NAM"))
                {
                    rdonam.Checked= true;
                    rdonu.Checked = false;
                }
                else
                {
                    rdonam.Checked = false;
                    rdonu.Checked = true;
                }
                dtpngaysinh.Value = Convert.ToDateTime(dt1.Rows[0]["NgaySinh"].ToString());
                txtghichu.Text = dt1.Rows[0]["GhiChu"].ToString();
            }
            conn.Close();
        }
    }
}
