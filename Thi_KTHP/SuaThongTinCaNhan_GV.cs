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
    public partial class frmsuathongtincanhan_gv : Form
    {
        private string username;
        private string pass;
        public frmsuathongtincanhan_gv(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        public frmsuathongtincanhan_gv()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void frmsuathongtincanhan_gv_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            string query = "select * from GiangVien Where MaGV='" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblmagv.Text = dt.Rows[0]["MaGV"].ToString();
                lbltengv.Text = dt.Rows[0]["TenGV"].ToString();
                lblmakhoa.Text = dt.Rows[0]["MaKhoa"].ToString();
                txtsdt_sttcn.Text = dt.Rows[0]["SoDT"].ToString();
                lbltrinhdo.Text = dt.Rows[0]["TrinhDo"].ToString();

            }
            conn.Close();
        }

        private void btnsua_sttcn_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            string query1 = "update GiangVien set SoDT='" + txtsdt_sttcn.Text + "' where MaGV='" + this.username + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            var result = cmd1.ExecuteNonQuery();
            if (result != 0)
            {
                MessageBox.Show("cap nhat du lieu thanh cong");
            }
            conn.Close();
        }
    }
}
