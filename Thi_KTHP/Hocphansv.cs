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
    public partial class frmhocphansv : Form
    {
        public frmhocphansv()
        {
            InitializeComponent();
            dgvmainqlhp.AllowUserToAddRows = false;
        }
        SqlConnection conn = new SqlConnection("data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;");

        private void Hocphansv_Load(object sender, EventArgs e)
        {
            cbokhoa.SelectedItem = "--";
            cbonganh.SelectedItem = "--";
            string query1 = "select * from Khoa";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            dgvmainqlhp.DataSource = dt1;
            for (int i = 0; i <= dgvmainqlhp.Rows.Count - 1; i++)
            {
                cbokhoa.Items.Add(dgvmainqlhp.Rows[i].Cells["TenKhoa"].Value.ToString());
            }
            dgvmainqlhp.DataSource = null;
            string query = "select a.TenKhoa as'TÊN KHOA',b.TenNganh as'TÊN NGÀNH',c.MaHP as'MÃ HP',c.TenHP as'TÊN HP',c.SoTC as'SỐ TC' from Khoa a,Nganh b,HocPhan c where c.MaNganh=b.MaNganh and a.MaKhoa=b.MaKhoa";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvmainqlhp.DataSource = dt;
            for (int i = 0; i <= dgvmainqlhp.Columns.Count - 1; i++)
            {
                dgvmainqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void cbokhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonganh.Items.Clear();
            cbonganh.Items.Add("--");
            cbonganh.SelectedItem = "--";
            string query = "select * from Nganh,Khoa where Nganh.MaKhoa=Khoa.MaKhoa and Khoa.TenKhoa=N'" + cbokhoa.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvmainqlhp.DataSource = dt;
            for (int i = 0; i <= dgvmainqlhp.Rows.Count - 1; i++)
            {
                cbonganh.Items.Add(dgvmainqlhp.Rows[i].Cells["TenNganh"].Value.ToString());
            }
            dgvmainqlhp.DataSource = null;

            string query1 = "select a.TenKhoa as N'TÊN KHOA',b.TenNganh AS N'TÊN NGÀNH',c.MaHP AS N'MÃ HP',c.TenHP AS N'TÊN HP',c.SoTC AS N'SỐ TC' from HocPhan c,Khoa a,Nganh b where a.MaKhoa=b.MaKhoa and b.MaNganh=c.MaNganh and  a.TenKhoa=N'" + cbokhoa.SelectedItem.ToString() + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            dgvmainqlhp.DataSource = dt1;
            for (int i = 0; i <= dgvmainqlhp.Columns.Count - 1; i++)
            {
                dgvmainqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void cbonganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonganh.SelectedItem.Equals("--"))
            {
                string query2 = "select a.TenKhoa as N'TÊN KHOA',b.TenNganh AS N'TÊN NGÀNH',c.MaHP AS N'MÃ HP',c.TenHP AS N'TÊN HP',c.SoTC AS N'SỐ TC' from HocPhan c,Khoa a,Nganh b where a.MaKhoa=b.MaKhoa and b.MaNganh=c.MaNganh and  a.TenKhoa=N'" + cbokhoa.SelectedItem + "'";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataAdapter data2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                data2.Fill(dt2);
                dgvmainqlhp.DataSource = dt2;
                for (int i = 0; i <= dgvmainqlhp.Columns.Count - 1; i++)
                {
                    dgvmainqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                string query = "select c.MaHP AS N'MÃ HP',c.TenHP AS N'TÊN HP',c.SoTC AS N'SỐ TC' from HocPhan c,Khoa a,Nganh b where a.MaKhoa=b.MaKhoa and b.MaNganh=c.MaNganh and a.TenKhoa=N'" + cbokhoa.SelectedItem + "'and b.TenNganh=N'" + cbonganh.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvmainqlhp.DataSource = dt;
                for (int i = 0; i <= dgvmainqlhp.Columns.Count - 1; i++)
                {
                    dgvmainqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
    }
}
