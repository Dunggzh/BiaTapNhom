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
    public partial class ThongKediem_Gv : Form
    {
        private int[] sotc = new int[20];
        private string[] namhoc = new string[20], hocky = new string[20];
        private float[] tbche10 = new float[20], tbche4 = new float[20];
        List<diemthongke> ds = new List<diemthongke>();
        private diemthongke[] diem = new diemthongke[100];
        private string username;
        private string pass;
        public ThongKediem_Gv(string username, string pass)
        {
            InitializeComponent();
            dgvthongke.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        public ThongKediem_Gv()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);

        private void btnthongke_Click(object sender, EventArgs e)
        {
            string querykhdt = "select * from KeHoachDaoTao a,khoahoc b where a.Makhoahoc=b.Makhoahoc and b.KyHoc=' " + cbohocki.SelectedItem.ToString() + "'";
            bang(querykhdt);
        }

        private void bang(string query)
        {
            dgvthongke.DataSource = null;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvthongke.DataSource = dt;
            for (int i = 0; i <= dgvthongke.Columns.Count - 1; i++)
            {
                dgvthongke.Columns[i].ReadOnly = true;
                dgvthongke.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void ThongKediem_Gv_Load(object sender, EventArgs e)
        {
            
        }
    }
}
