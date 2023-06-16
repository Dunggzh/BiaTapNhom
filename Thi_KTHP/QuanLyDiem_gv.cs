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
    public partial class QuanLyDiem_gv : Form
    {
        private string username;
        private string pass;
        public QuanLyDiem_gv(string username, string pass)
        {
            InitializeComponent();
            dgv_qldsv.AllowUserToAddRows = false;
            this.username = username;
            this.pass = pass;
        }
        public QuanLyDiem_gv()
        {
            InitializeComponent();
            dgv_qldsv.AllowUserToAddRows = false;
        }
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        private void QuanLyDiem_gv_Load(object sender, EventArgs e)
        {
            cbbkyhoc_qldsv.Items.Add("--");
            string queryt = "select * from KhoaHoc";
            SqlCommand cdmt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cdmt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgv_qldsv.DataSource = dtt;
            if (dtt != null && dgv_qldsv.Rows.Count > 0)
            {

                for (int i = 0; i <= dgv_qldsv.Rows.Count - 1; i++)
                {
                    cbbkyhoc_qldsv.Items.Add(dgv_qldsv.Rows[i].Cells["KyHoc"].Value.ToString());
                }
                cbbkyhoc_qldsv.SelectedItem = "--";
            }
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,Nhomhp,GiangVien Where GiangVien.MaGV=Nhomhp.MaGV and Diem.MaNhomHP=Nhomhp.MaNhomHP and GiangVien.MaGV= '" + this.username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgv_qldsv.DataSource = dt;
            conn.Close();
        }

        private void cbbkyhoc_qldsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbblop_qldsv.Items.Clear();
            cbblop_qldsv.Items.Add("--");
            string queryt = "select * from KeHoachDaoTao,KhoaHoc Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgv_qldsv.DataSource = dtt;
            if (dtt != null && dgv_qldsv.Rows.Count > 0)
            {

                for (int i = 0; i <= dgv_qldsv.Rows.Count - 1; i++)
                {
                    cbblop_qldsv.Items.Add(dgv_qldsv.Rows[i].Cells["TenLop"].Value.ToString());
                }
                cbblop_qldsv.SelectedItem = "--";
            }
            try
            {
                if (cbbkyhoc_qldsv.SelectedItem.Equals("--"))
                {

                    conn.Open();
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,Nhomhp,GiangVien Where GiangVien.MaGV=Nhomhp.MaGV and Diem.MaNhomHP=Nhomhp.MaNhomHP and GiangVien.MaGV= '" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,Nhomhp,KeHoachDaoTao Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and Nhomhp.MaGV=GiangVien.MaGV and Nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.MaGV='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbblop_qldsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbmasv_qldsv.Items.Clear();
            cbbmasv_qldsv.Items.Add("--");
            string queryt = "select * from Diem,SinhVien,Nhomhp,GiangVien Where SinhVien.TenLop='" + cbblop_qldsv.SelectedItem.ToString() + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and Diem.MaNhomHP=Nhomhp.MaNhomHP and GiangVien.MaGV=Nhomhp.MaGV and GiangVien.MaGV='" + this.username + "'";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgv_qldsv.DataSource = dtt;
            if (dtt != null && dgv_qldsv.Rows.Count > 0)
            {

                for (int i = 0; i <= dgv_qldsv.Rows.Count - 1; i++)
                {
                    cbbmasv_qldsv.Items.Add(dgv_qldsv.Rows[i].Cells["MaSinhVien"].Value.ToString());
                }
                cbbmasv_qldsv.SelectedItem = "--";
            }
            try
            {
                if (cbblop_qldsv.SelectedItem.Equals("--"))
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,Nhomhp,KeHoachDaoTao Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=Nhomhp.MaKHDT and Nhomhp.MaGV=GiangVien.MaGV and Nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.MaGV='" + this.username + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,Nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=Nhomhp.MaKHDT and Nhomhp.MaGV=GiangVien.MaGV and Nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.MaGV='" + this.username + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop_qldsv.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbmasv_qldsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbmasv_qldsv.SelectedItem.Equals("--"))
                {

                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,Nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=Nhomhp.MaKHDT and Nhomhp.MaGV=GiangVien.MaGV and Nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.MaGV='" + this.username + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop_qldsv.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThaoLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,Nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkyhoc_qldsv.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=Nhomhp.MaKHDT and Nhomhp.MaGV=GiangVien.MaGV and Nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.MaGV='" + this.username + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop_qldsv.SelectedItem.ToString() + "' and Diem.MaSinhVien='" + cbbmasv_qldsv.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgv_qldsv.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_qldsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgv_qldsv.Rows[e.RowIndex];
            lblmasv_qldsv.Text = i.Cells[0].Value.ToString();
            txtchuyencan_qldcsv.Text = i.Cells[1].Value.ToString();
            txtgiuaki_qldsv.Text = i.Cells[2].Value.ToString();
            txtthuchanh_qldsv.Text = i.Cells[3].Value.ToString();
            txtthiketthuc_qldsv.Text = i.Cells[4].Value.ToString();
            txtthaoluan_qldsv.Text = i.Cells[5].Value.ToString();
            lbltongketHP_qldsv.Text = i.Cells[6].Value.ToString();
            lbldiemchu_qldsv.Text = i.Cells[7].Value.ToString();
        }

        private void cbbluachon_qldsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbluachon_qldsv.SelectedItem.Equals("Thực hành"))
            {
                txtthuchanh_qldsv.Enabled = true;
                txtthaoluan_qldsv.Enabled = false;
                cbbluachon_qldsv.Enabled = false;
            }
            else if (cbbluachon_qldsv.SelectedItem.Equals("Thảo luận"))
            {
                txtthaoluan_qldsv.Enabled = true;
                txtthuchanh_qldsv.Enabled = false;
                cbbluachon_qldsv.Enabled = false;
            }
            else
            {
                txtthaoluan_qldsv.Enabled = false;
                txtthuchanh_qldsv.Enabled = false;
            }
        }

        private void btnluu_qldsv_Click(object sender, EventArgs e)
        {
            if (txtthuchanh_qldsv.Enabled == false && txtthaoluan_qldsv.Enabled == false)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP, DiemChu=@DiemChu where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv_qldsv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan_qldcsv.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki_qldsv.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtthiketthuc_qldsv.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan_qldcsv.Text) * 0.1 + float.Parse(txtgiuaki_qldsv.Text) * 0.2 + float.Parse(txtthiketthuc_qldsv.Text) * 0.7);
                float dc = float.Parse(lbltongketHP_qldsv.Text);
                if (dc >= 8.5 && dc <= 10) cmd.Parameters.AddWithValue("@DiemChu", "A");
                else if (dc >= 8 && dc < 8.5) cmd.Parameters.AddWithValue("@DiemChu", "B+");
                else if (dc >= 7 && dc < 8) cmd.Parameters.AddWithValue("@DiemChu", "B");
                else if (dc >= 6 && dc < 7) cmd.Parameters.AddWithValue("@DiemChu", "C+");
                else if (dc >= 5.5 && dc < 6) cmd.Parameters.AddWithValue("@DiemChu", "C");
                else if (dc >= 5.1 && dc < 5.5) cmd.Parameters.AddWithValue("@DiemChu", "D+");
                else if (dc >= 4 && dc < 5.1) cmd.Parameters.AddWithValue("@DiemChu", "D");
                else cmd.Parameters.AddWithValue("@DiemChu", "F");
                cmd.ExecuteNonQuery();
                conn.Close();
                // frmqldiemsv_gv(sender, e);
                txtchuyencan_qldcsv.Enabled = false;
                txtgiuaki_qldsv.Enabled = false;
                txtthuchanh_qldsv.Enabled = false;
                txtthiketthuc_qldsv.Enabled = false;
                txtthaoluan_qldsv.Enabled = false;
                btnluu_qldsv.Enabled = false;
                btnsua_qldsv.Enabled = true;
                cbbluachon_qldsv.Enabled = false;
            }
            else if (txtthuchanh_qldsv.Enabled == true)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThucHanh=@ThucHanh, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP, DiemChu=@DiemChu where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv_qldsv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan_qldcsv.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki_qldsv.Text);
                cmd.Parameters.AddWithValue("@ThucHanh", txtthuchanh_qldsv.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtthiketthuc_qldsv.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan_qldcsv.Text) * 0.1 + float.Parse(txtgiuaki_qldsv.Text) * 0.1 + float.Parse(txtthuchanh_qldsv.Text) * 0.1 + float.Parse(txtthiketthuc_qldsv.Text) * 0.7);
                float dc = float.Parse(lbltongketHP_qldsv.Text);
                if (dc >= 8.5 && dc <= 10) cmd.Parameters.AddWithValue("@DiemChu", "A");
                else if (dc >= 8 && dc < 8.5) cmd.Parameters.AddWithValue("@DiemChu", "B+");
                else if (dc >= 7 && dc < 8) cmd.Parameters.AddWithValue("@DiemChu", "B");
                else if (dc >= 6 && dc < 7) cmd.Parameters.AddWithValue("@DiemChu", "C+");
                else if (dc >= 5.5 && dc < 6) cmd.Parameters.AddWithValue("@DiemChu", "C");
                else if (dc >= 5.1 && dc < 5.5) cmd.Parameters.AddWithValue("@DiemChu", "D+");
                else if (dc >= 4 && dc < 5.1) cmd.Parameters.AddWithValue("@DiemChu", "D");
                else cmd.Parameters.AddWithValue("@DiemChu", "F");
                cmd.ExecuteNonQuery();
                conn.Close();
                txtchuyencan_qldcsv.Enabled = false;
                txtgiuaki_qldsv.Enabled = false;
                txtthuchanh_qldsv.Enabled = false;
                txtthiketthuc_qldsv.Enabled = false;
                txtthaoluan_qldsv.Enabled = false;
                btnluu_qldsv.Enabled = false;
                btnsua_qldsv.Enabled = true;
                cbbluachon_qldsv.Enabled = false;
            }
            else if (txtthaoluan_qldsv.Enabled == true)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThaoLuan=@ThaoLuan, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP,DiemChu=@DiemChu where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv_qldsv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan_qldcsv.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki_qldsv.Text);
                cmd.Parameters.AddWithValue("@ThoaLuan", txtthaoluan_qldsv.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtthiketthuc_qldsv.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan_qldcsv.Text) * 0.1 + float.Parse(txtgiuaki_qldsv.Text) * 0.1 + float.Parse(txtthaoluan_qldsv.Text) * 0.1 + float.Parse(txtthiketthuc_qldsv.Text) * 0.7);
                float dc = float.Parse(lbltongketHP_qldsv.Text);
                if (dc >= 8.5 && dc <= 10) cmd.Parameters.AddWithValue("@DiemChu", "A");
                else if (dc >= 8 && dc < 8.5) cmd.Parameters.AddWithValue("@DiemChu", "B+");
                else if (dc >= 7 && dc < 8) cmd.Parameters.AddWithValue("@DiemChu", "B");
                else if (dc >= 6 && dc < 7) cmd.Parameters.AddWithValue("@DiemChu", "C+");
                else if (dc >= 5.5 && dc < 6) cmd.Parameters.AddWithValue("@DiemChu", "C");
                else if (dc >= 5.1 && dc < 5.5) cmd.Parameters.AddWithValue("@DiemChu", "D+");
                else if (dc >= 4 && dc < 5.1) cmd.Parameters.AddWithValue("@DiemChu", "D");
                else cmd.Parameters.AddWithValue("@DiemChu", "F");
                cmd.ExecuteNonQuery();
                conn.Close();
                txtchuyencan_qldcsv.Enabled = false;
                txtgiuaki_qldsv.Enabled = false;
                txtthuchanh_qldsv.Enabled = false;
                txtthiketthuc_qldsv.Enabled = false;
                txtthaoluan_qldsv.Enabled = false;
                btnluu_qldsv.Enabled = false;
                btnsua_qldsv.Enabled = true;
                cbbluachon_qldsv.Enabled = false;
            }
        }

        private void btnsua_qldsv_Click(object sender, EventArgs e)
        {
            cbbluachon_qldsv.SelectedItem = "(--)";
            cbbluachon_qldsv.Enabled = true;
            txtchuyencan_qldcsv.Enabled = true;
            txtgiuaki_qldsv.Enabled = true;
            txtthiketthuc_qldsv.Enabled = true;
            btnluu_qldsv.Enabled = true;
            btnsua_qldsv.Enabled = false;
        }
    }
}
