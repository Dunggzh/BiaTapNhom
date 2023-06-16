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
    public partial class frmquanlysinhvien : Form
    {
        private string username;
        private string pass;
        public frmquanlysinhvien(string username, string pass)
        {
            InitializeComponent();
            dgvqlsv.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        public frmquanlysinhvien()
        {
            InitializeComponent();
            dgvqlsv.AllowUserToAddRows = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);

        private void cbbtenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvqlsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void frmquanlysinhvien_Load_1(object sender, EventArgs e)
        {
            cbbtenlop.Items.Add("--");
            string queryt = "select * from Lop";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvqlsv.DataSource = dtt;
            if (dtt != null && dgvqlsv.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvqlsv.Rows.Count - 1; i++)
                {
                    cbbtenlop.Items.Add(dgvqlsv.Rows[i].Cells["TenLop"].Value.ToString());
                }
                cbbtenlop.SelectedItem = "--";
            }
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select * from Sinhvien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvqlsv.DataSource = dt;
            for (int i = 0; i <= dgvqlsv.Columns.Count - 1; i++)
            {
                dgvqlsv.Columns[i].ReadOnly = true;
                dgvqlsv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        private void dgvqlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvqlsv.Rows[e.RowIndex];
            txtmasv.Text = i.Cells[0].Value.ToString();
            txthoten.Text = i.Cells[2].Value.ToString();
            txtquequan.Text = i.Cells[3].Value.ToString();
            dtpngaysinh.Value = Convert.ToDateTime(i.Cells[4].Value);
            txtnoisinh.Text = i.Cells[5].Value.ToString();
            txtgioitinh.Text = i.Cells[6].Value.ToString();
        }

        private void cbbtenlop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbmasv.Items.Clear();
            cbbmasv.Items.Add("--");
            string queryt = "select * from SinhVien,Lop where Lop.TenLop=SinhVien.TenLop and Lop.TenLop='" + cbbtenlop.SelectedItem.ToString() + "'";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvqlsv.DataSource = dtt;
            if (dtt != null && dgvqlsv.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvqlsv.Rows.Count - 1; i++)
                {
                    cbbmasv.Items.Add(dgvqlsv.Rows[i].Cells["MaSinhVien"].Value.ToString());
                }
                cbbmasv.SelectedItem = "--";
            }
            try
            {
                if (cbbtenlop.SelectedItem.Equals("--"))
                {

                    conn.Open();
                    DataTable dt = new DataTable();
                    string query = "select * from Sinhvien";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvqlsv.DataSource = dt;
                    for (int i = 0; i <= dgvqlsv.Columns.Count - 1; i++)
                    {
                        dgvqlsv.Columns[i].ReadOnly = true;
                        dgvqlsv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select * from SinhVien where TenLop='" + cbbtenlop.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvqlsv.DataSource = dt;
                    for (int i = 0; i <= dgvqlsv.Columns.Count - 1; i++)
                    {
                        dgvqlsv.Columns[i].ReadOnly = true;
                        dgvqlsv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbmasv_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string query = "select * from SinhVien where MaSinhVien='" + cbbmasv.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            dgvqlsv.DataSource = dt;
            for (int i = 0; i <= dgvqlsv.Columns.Count - 1; i++)
            {
                dgvqlsv.Columns[i].ReadOnly = true;
                dgvqlsv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }
    }
}
