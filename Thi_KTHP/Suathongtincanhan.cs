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
    public partial class frmsuathongtincanhan : Form
    {
        private string username;
        private string pass;
        public frmsuathongtincanhan()
        {
            InitializeComponent();
        }
        public frmsuathongtincanhan(string username, string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);

        private void frmsuathongtincanhan_Load(object sender, EventArgs e)
        {
            txtmsv.Enabled = false;
            txtht.Enabled = false;
            txttenlop.Enabled = false;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            string query = "select * from SinhVien where MaSinhVien='" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            adapter1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtmsv.Text = dt.Rows[0]["MaSinhVien"].ToString();
                txtht.Text = dt.Rows[0]["TenSV"].ToString();
                txttenlop.Text = dt.Rows[0]["TenLop"].ToString();
                txtquequan.Text = dt.Rows[0]["QueQuan"].ToString();
                txtnoisinh.Text = dt.Rows[0]["NoiSinh"].ToString();
                if (dt.Rows[0]["GioiTinh"].ToString().Equals("NAM"))
                {
                    rdonam.Checked = true;
                    rdonu.Checked = false;
                }
                else
                {
                    rdonam.Checked = false;
                    rdonu.Checked = true;
                }
                dtpngaysinh.Value = Convert.ToDateTime(dt.Rows[0]["NgaySinh"].ToString());

                txtghichu.Text = dt.Rows[0]["GhiChu"].ToString();
            }
            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string gt;
            if (rdonam.Checked)
            {
                gt = "NAM";
            }
            else
            {
                gt = "NU";
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            string query1 = "update SinhVien set NgaySinh='" + Convert.ToDateTime(dtpngaysinh.Text).ToString("MM/dd/yyyy") + "',QueQuan=N'" + txtquequan.Text.Trim() + "',NoiSinh=N'" + txtnoisinh.Text.Trim() + "',GioiTinh='" + gt + "',GhiChu=N'" + txtghichu.Text.Trim() + "' where MaSinhVien='" + this.username + "'";
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
