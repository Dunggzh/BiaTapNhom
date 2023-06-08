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
            dgvmainqlhp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        SqlConnection conn = new SqlConnection("Data Source=KHANG\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void bang(string query)
        {
            dgvmainqlhp.DataSource = null;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            data.Fill(dt);
            dgvmainqlhp.DataSource = dt;
            for (int i = 0; i <= dgvmainqlhp.Columns.Count - 1; i++)
            {
                dgvmainqlhp.Columns[i].ReadOnly = true;
                dgvmainqlhp.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
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
            string query = "select khoa.TenKhoa,Nganh.TenNganh,HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTiet,HocPhan.SoTC from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=nhomhp.MaGV and nhomhp.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc";
            bang(query);
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
            string query1 = "select Nganh.TenNganh,HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTiet,HocPhan.SoTC from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=nhomhp.MaGV and nhomhp.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and  Khoa.TenKhoa=N'" + cbokhoa.SelectedItem.ToString() + "'";
            bang(query1);

        }

        private void cbonganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbonganh.SelectedItem.Equals("--"))
            {
                string query2 = "select Nganh.TenNganh,HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTiet,HocPhan.SoTC from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=nhomhp.MaGV and nhomhp.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and  Khoa.TenKhoa=N'" + cbokhoa.SelectedItem.ToString() + "'";
                bang(query2);
            }
            else
            {
                string query3 = "select khoa.TenKhoa,Nganh.TenNganh,HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTiet,HocPhan.SoTC from Khoa,HocPhan,Nganh,nhomhp,GiangVien,KeHoachDaoTao,Lop,KhoaHoc where Nganh.MaKhoa=khoa.MaKhoa  and GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaGV=nhomhp.MaGV and nhomhp.MaHP=HocPhan.MaHP and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and Lop.MaNganh=Nganh.MaNganh and lop.TenLop=KeHoachDaoTao.TenLop and KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and Khoa.TenKhoa=N'" + cbokhoa.SelectedItem + "'and Nganh.TenNganh=N'" + cbonganh.SelectedItem.ToString() + "'";
                bang(query3);
            }
        }
    }
}
