using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thi_KTHP
{
    public partial class frmdiemsv : Form
    {
        private string username;
        private string pass;
        public frmdiemsv()
        {
            InitializeComponent();
            dgvmain.AllowUserToAddRows = false;

        }

        public frmdiemsv(string username, string pass)
        {
            InitializeComponent();
            dgvmain.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void bang(string query)
        {
            dgvmain.DataSource = null;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvmain.DataSource = dt;
            for (int i = 0; i <= dgvmain.Columns.Count - 1; i++)
            {
                dgvmain.Columns[i].ReadOnly = true;
                dgvmain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void Diemsv_Load(object sender, EventArgs e)
        {

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            //them combobox khoahoc
            string queryt = "select * from KhoaHoc";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvmain.DataSource = dtt;
            if (dtt != null && dgvmain.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvmain.Rows.Count - 1; i++)
                {
                    cbohocky.Items.Add(dgvmain.Rows[i].Cells["KyHoc"].Value.ToString());
                }
                cbohocky.SelectedItem = "--";
            }

            //do du lieu len label
            dgvmain.DataSource = null;
            string query1 = "select * from HocPhan,Nganh,KeHoachDaoTao,Lop,KhoaHoc,SinhVien where  Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc   and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            dgvmain.DataSource = dt1;
            if (dt1 != null && dgvmain.Rows.Count > 0)
            {
                var a = dgvmain.Rows[0];
                lblmasv.Text = a.Cells["MaSinhVien"].Value.ToString();
                lblhoten.Text = a.Cells["Tensv"].Value.ToString();
                lblkhoahoc.Text = a.Cells["TenKhoahoc"].Value.ToString();
                lbllop.Text = a.Cells["TenLop"].Value.ToString();
                lblnganh.Text = a.Cells["TenNganh"].Value.ToString();

            }
            else
            {
                try {
                    string query2 = "select * from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dgvmain.DataSource = dt;
                    var b = dgvmain.Rows[0];
                    lblmasv.Text = b.Cells["MaSinhVien"].Value.ToString();
                    lblhoten.Text = b.Cells["Tensv"].Value.ToString();
                    lbllop.Text = b.Cells["TenLop"].Value.ToString();
                    lblnganh.Text = b.Cells["TenNganh"].Value.ToString();
                    dgvmain.DataSource = null;
                }catch(Exception ex)
                {

                }
                }
            string queryth = "select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
            bang(queryth);
            }

        private void cbohocky_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbohocky_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbohocky.SelectedItem.Equals("--"))
            {
                string query = "select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'";
                bang(query);
            }
            else
            {
                string query = "select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Khoa,HocPhan,Nganh,NhomHP,GiangVien,KeHoachDaoTao,Lop,KhoaHoc,Diem,SinhVien where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=NhomHP.MaGV and NhomHP.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=NhomHP.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Diem.MaSinhVien=SinhVien.MaSinhVien and Diem.MaNhomHP=NhomHP.MaNhomHP and SinhVien.TenLop=Lop.TenLop  and SinhVien.MaSinhVien='" + this.username + "'and KhoaHoc.KyHoc='" + cbohocky.SelectedItem.ToString() + "'";
                bang(query);
            }
        }
    }
}
