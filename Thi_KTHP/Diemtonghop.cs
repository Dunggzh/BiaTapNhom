using System;
using System.Collections;
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
    public partial class frmdiemtonghop : Form
    {
        private int[] sotc=new int[20];
        private string[] namhoc=new string[20], hocky = new string[20];
        private float[] tbche10 = new float[20], tbche4 = new float[20];
        private string username;
        private string pass;
        public frmdiemtonghop(string username, string pass)
        {
            InitializeComponent();
            dgvdiemth.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        public frmdiemtonghop()
        {
            InitializeComponent();
            dgvdiemth.AllowUserToAddRows = false;
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        List<diemth> ds = new List<diemth>();
        private diemth[] diem=new diemth[20];
        private void bang(string query)
        {
            try
            {
                dgvdiemth.DataSource = null;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvdiemth.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmdiemtonghop_Load(object sender, EventArgs e)
        {
            string query = "select * from KhoaHoc";
            bang(query);
            for(int i=0;i<dgvdiemth.Rows.Count;i++)
            {
                namhoc[i]= hnamhoc(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                hocky[i]= hhocky(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                
                diem[i]=new diemth() { NamHoc = namhoc[i],HocKy=hocky[i] };
                sotc[i] = hsotc(sotc[i], dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                diem[i] = new diemth() { SoTC = sotc[i] };
                ds.Add(diem[i]);
            }
            dgvdiemth.DataSource = ds;
        }
    public string hnamhoc(string a)
    {
        string kq = a.Substring(0, a.Length - 2);
        return kq;
    }
    public string hhocky(string a)
    {
        string kq = a.Substring(a.Length - 1);
        return kq;
    }
        public int hsotc(int a,string hocky)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string query1 = "select * from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'and KyHoc='"+hocky+"'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                a= a+Convert.ToInt32( dt.Rows[i]["SoTC"].ToString().Trim());
            }
            return a;
        }
}
}
