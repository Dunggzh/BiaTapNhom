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
    public partial class frmthongtin_gv : Form
    {

        private string username;
        private string pass;

        public frmthongtin_gv(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        public frmthongtin_gv()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void frmthongtingv_Load(object sender, EventArgs e)
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
                lblsdt.Text = dt.Rows[0]["SoDT"].ToString();
                lbltrinhdo.Text = dt.Rows[0]["TrinhDo"].ToString();

            }
            conn.Close();
        }

    }
}
