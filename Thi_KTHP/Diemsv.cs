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
        SqlConnection conn = new SqlConnection("data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;");

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
            string query1 = "select * from SinhVien a,HocPhan b, Diem c,Nganh d,Lop e,KhoaHoc g where a.MaSinhVien=c.MaSinhVien and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.MaSinhVien='" + this.username + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataAdapter data1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            data1.Fill(dt1);
            dgvmain.DataSource = dt1;
            if (dt1 != null && dgvmain.Rows.Count > 0)
            {
                var a = dgvmain.Rows[0];
                lblmasv.Text = a.Cells["MaSinhVien"].Value.ToString();
                lblhoten.Text = a.Cells["Hoten"].Value.ToString();
                lblkhoahoc.Text = a.Cells["TenKhoahoc"].Value.ToString();
                lbllop.Text = a.Cells["TenLop"].Value.ToString();
                lblnganh.Text = a.Cells["TenNganh"].Value.ToString();
                cbohocky.SelectedItem = "--";
                if (cbohocky.SelectedItem.Equals("--"))
                {
                    dgvmain.DataSource = null;
                    string query = "select b.MaHP as 'Mã học phần',TenHP as 'Tên học phần',SoTC as 'Số tín chỉ',a.MaSinhVien as 'Mã sinh viên',ChuyenCan as 'Chuyên cần',KiemTraGK as 'Kiểm tra GK',ThucHanh as'Thực hành',ThiKetThuc as'Thi Kết thúc',ThoaLuan as'Thảo luận',TongKetHP as'Tổng kết HP',DiemChu as 'Điểm chữ'  from SinhVien a,HocPhan b, Diem c,Nganh d,Lop e,KhoaHoc g\r\nwhere a.MaSinhVien=c.MaSinhVien and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.MaSinhVien='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dgvmain.DataSource = dt;
                    for (int i = 0; i <= dgvmain.Columns.Count - 1; i++)
                    {
                        dgvmain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    dgvmain.DataSource = null;
                    string query = "select b.MaHP as 'Mã học phần',TenHP as 'Tên học phần',SoTC as 'Số tín chỉ',a.MaSinhVien as 'Mã sinh viên',ChuyenCan as 'Chuyên cần',KiemTraGK as 'Kiểm tra GK',ThucHanh as'Thực hành',ThiKetThuc as'Thi Kết thúc',ThoaLuan as'Thảo luận',TongKetHP as'Tổng kết HP',DiemChu as 'Điểm chữ'  from SinhVien a,HocPhan b, Diem c,Nganh d,Lop e,KhoaHoc g\r\nwhere a.MaSinhVien=c.MaSinhVien and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.MaSinhVien='" + this.username + "'and g.KyHoc='" + cbohocky.SelectedItem + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    dgvmain.DataSource = dt;
                    for (int i = 0; i <= dgvmain.Columns.Count - 1; i++)
                    {
                        dgvmain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            else
            {
                string query2 = "select *  from SinhVien a,HocPhan b,Nganh d,Lop e,KhoaHoc g\r\nwhere  a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh  and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh  and a.MaSinhVien='" + this.username + "'";
                SqlCommand cmd = new SqlCommand(query2, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvmain.DataSource = dt;
                var b = dgvmain.Rows[0];
                lblmasv.Text = b.Cells["MaSinhVien"].Value.ToString();
                lblhoten.Text = b.Cells["Hoten"].Value.ToString();
                lbllop.Text = b.Cells["TenLop"].Value.ToString();
                lblnganh.Text = b.Cells["TenNganh"].Value.ToString();
                dgvmain.DataSource = null;
            }




            conn.Close();
        }

        private void cbohocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbohocky.SelectedItem.Equals("--"))
            {
                dgvmain.DataSource = null;
                string query = "select b.MaHP as 'Mã học phần',TenHP as 'Tên học phần',SoTC as 'Số tín chỉ',a.MaSinhVien as 'Mã sinh viên',ChuyenCan as 'Chuyên cần',KiemTraGK as 'Kiểm tra GK',ThucHanh as'Thực hành',ThiKetThuc as'Thi Kết thúc',ThoaLuan as'Thảo luận',TongKetHP as'Tổng kết HP',DiemChu as 'Điểm chữ'  from SinhVien a,HocPhan b, Diem c,Nganh d,Lop e,KhoaHoc g\r\nwhere a.MaSinhVien=c.MaSinhVien and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and a.MaSinhVien='" + this.username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvmain.DataSource = dt;

                for (int i = 0; i <= dgvmain.Columns.Count - 1; i++)
                {
                    dgvmain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvmain.DataSource = null;
                string query = "select b.MaHP as 'Mã học phần',TenHP as 'Tên học phần',SoTC as 'Số tín chỉ',a.MaSinhVien as 'Mã sinh viên',ChuyenCan as 'Chuyên cần',KiemTraGK as 'Kiểm tra GK',ThucHanh as'Thực hành',ThiKetThuc as'Thi Kết thúc',ThoaLuan as'Thảo luận',TongKetHP as'Tổng kết HP',DiemChu as 'Điểm chữ'  from SinhVien a,HocPhan b, Diem c,Nganh d,Lop e,KhoaHoc g\r\nwhere a.MaSinhVien=c.MaSinhVien and a.TenLop=e.TenLop and a.MaNganh=d.MaNganh and d.MaNganh=e.MaNganh and b.MaNganh=d.MaNganh and b.MaHP=c.MaHP and c.MaKhoaHoc=g.MaKhoaHoc and g.KyHoc='" + cbohocky.SelectedItem + "'and a.MaSinhVien='" + this.username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dgvmain.DataSource = dt;

                for (int i = 0; i <= dgvmain.Columns.Count - 1; i++)
                {
                    dgvmain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            conn.Close();
        }
    }
}
