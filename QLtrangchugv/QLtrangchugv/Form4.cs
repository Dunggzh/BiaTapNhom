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

namespace QLtrangchugv
{
    public partial class frmtthp : Form
    {
        string tk = "NguyenthiA";
        string mk = "a";
        int quyen = 1;
        public frmtthp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NVIUQTM\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvqlhp.Rows[e.RowIndex];
            txtmahp.Text = i.Cells[0].Value.ToString();
            txttenhp.Text= i.Cells[1].Value.ToString();
            txtsotc.Text = i.Cells[2].Value.ToString();
            txtsotiet.Text = i.Cells[3].Value.ToString();
        }

        private void frmtthp_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select HocPhan.MaHP,Hocphan.TenHP,HocPhan.SoTC,HocPhan.SoTiet from HocPhan,nhomhp,GiangVien where GiangVien.MaGV=nhomhp.MaGV and HocPhan.MaHP=nhomhp.MaHP and GiangVien.UseName='" + tk + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvqlhp.DataSource = dt;
            conn.Close();
        }
    }
}
