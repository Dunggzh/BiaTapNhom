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
        private int[] sotc = new int[20];
        private string[] namhoc = new string[20], hocky = new string[20];
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
        private diemth[] diem = new diemth[20];
        private void bang(string query)
        {
            try
            {

                dgvdiemth.DataSource = null;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvdiemth.DataSource = dt;
                for (int i = 0; i <= dgvdiemth.Columns.Count - 1; i++)
                {
                    dgvdiemth.Columns[i].ReadOnly = true;
                    dgvdiemth.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmdiemtonghop_Load(object sender, EventArgs e)
        {
            dgvdiemth.DataSource = null;
            string query1 = "select * from HocPhan,Nganh,KeHoachDaoTao,Lop,KhoaHoc,SinhVien where  Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc   and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            dgvdiemth.DataSource = dt1;
            if (dt1 != null && dgvdiemth.Rows.Count > 0)
            {
                var a = dgvdiemth.Rows[0];
                lblmasv.Text = a.Cells["MaSinhVien"].Value.ToString();
                lblhoten.Text = a.Cells["Tensv"].Value.ToString();
                lblkhoahoc.Text = a.Cells["TenKhoahoc"].Value.ToString();
                lbllop.Text = a.Cells["TenLop"].Value.ToString();
                lblnganh.Text = a.Cells["TenNganh"].Value.ToString();

            }
            else
            {
                string query2 = "select * from HocPhan,Nganh,KeHoachDaoTao,Lop,KhoaHoc,SinhVien where  Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc   and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
                SqlCommand cmd = new SqlCommand(query2, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvdiemth.DataSource = dt;
                var b = dgvdiemth.Rows[0];
                lblmasv.Text = b.Cells["MaSinhVien"].Value.ToString();
                lblhoten.Text = b.Cells["Tensv"].Value.ToString();
                lbllop.Text = b.Cells["TenLop"].Value.ToString();
                lblnganh.Text = b.Cells["TenNganh"].Value.ToString();
                dgvdiemth.DataSource = null;
            }
            string queryth = "select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
            bang(queryth);
            string query = "select * from KhoaHoc";
            bang(query);
            for (int i = 0; i < dgvdiemth.Rows.Count; i++)
            {
                namhoc[i] = hnamhoc(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                hocky[i] = hhocky(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());

                diem[i] = new diemth() { NamHoc = namhoc[i], HocKy = hocky[i] };
                sotc[i] = hsotc(sotc[i], dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                diem[i].SoTC = sotc[i];
                if (diem[i].SoTC != 0)
                {
                    tbche10[i] = htbche10(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                    tbche4[i] = htbche4(dgvdiemth.Rows[i].Cells["KyHoc"].Value.ToString());
                    diem[i].TBCHe10 = tbche10[i] / diem[i].SoTC;
                    diem[i].TBCHe4 = tbche4[i] / diem[i].SoTC;
                }
                ds.Add(diem[i]);
            }
            dgvdiemth.DataSource = ds;
            for (int i = 0; i <= dgvdiemth.Columns.Count - 1; i++)
            {
                dgvdiemth.Columns[i].ReadOnly = true;
                dgvdiemth.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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
        public int hsotc(int a, string hocky)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string query1 = "select * from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'and KyHoc='" + hocky + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                a = a + Convert.ToInt32(dt.Rows[i]["SoTC"].ToString().Trim());

            }
            return a;
        }
        public float htbche10(string hocky)
        {
            int a = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            float kq = 0, b;
            string query1 = "select * from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'and KyHoc='" + hocky + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                a = Convert.ToInt32(dt.Rows[i]["SoTC"].ToString().Trim());
                b = Convert.ToSingle(dt.Rows[i]["TongKetHP"].ToString().Trim());
                kq = kq + (a * b);
            }
            return kq;
        }
        public float htbche4(string hocky)
        {
            int a = 0;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            float kq = 0, b = 0;
            string query1 = "select * from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'and KyHoc='" + hocky + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                a = Convert.ToInt32(dt.Rows[i]["SoTC"].ToString().Trim());
                switch (Convert.ToString(dt.Rows[i]["DiemChu"].ToString().Trim()))
                {
                    case "A": b = (float)4.0; break;
                    case "B+": b = (float)3.5; break;
                    case "B":
                        b = (float)3.0;
                        break;
                    case "C+":
                        b = (float)2.5;
                        break;
                    case "C":
                        b = (float)2.0;
                        break;
                    case "D+":
                        b = (float)1.5;
                        break;
                    case "D":
                        b = (float)1.0;
                        break;
                    case "F":
                        b = (float)0.5;
                        break;
                }
                kq = kq + (a * b);
            }
            return kq;
        }
    }
}
