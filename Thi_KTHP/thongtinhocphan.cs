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
    public partial class frmthongtinhp : Form
    {
        private string username;
        private string pass;
        public frmthongtinhp()
        {
            InitializeComponent();
        }
        public frmthongtinhp(string username, string pass)
        {
            InitializeComponent();
            dgvqlhp.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvqlhp.Rows[e.RowIndex];
            txtmahp.Text = i.Cells[0].Value.ToString();
            txttenhp.Text = i.Cells[1].Value.ToString();
            txtsotc.Text = i.Cells[2].Value.ToString();
            txtsotiet.Text = i.Cells[3].Value.ToString();
        }
        private void frmthongtinhp_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select HocPhan.MaHP,Hocphan.TenHP,HocPhan.SoTC,HocPhan.SoTiet from HocPhan,nhomhp,GiangVien where GiangVien.MaGV=nhomhp.MaGV and HocPhan.MaHP=nhomhp.MaHP and GiangVien.MaGV='" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvqlhp.DataSource = dt;
            for (int i = 0; i <= dgvqlhp.Columns.Count - 1; i++)
            {
                dgvqlhp.Columns[i].ReadOnly = true;
                dgvqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        private void dgvqlhp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvqlhp.Rows[e.RowIndex];
            txtmahp.Text = i.Cells["MaHP"].Value.ToString();
            txttenhp.Text = i.Cells["TenHP"].Value.ToString();
            txtsotc.Text = i.Cells["SoTC"].Value.ToString();
            txtsotiet.Text = i.Cells["Sotiet"].Value.ToString();

        }
    }
}
