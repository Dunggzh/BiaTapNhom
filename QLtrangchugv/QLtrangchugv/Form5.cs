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
    public partial class frmqldiemsv : Form
    {
        string tk = "NguyenthiA";
        string mk = "a";
        int quyen = 1;
        public frmqldiemsv()
        {
            InitializeComponent();
            dgvdiem.AllowUserToAddRows = false;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NVIUQTM\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void frmqldiemsv_Load(object sender, EventArgs e)
        {
            cbbkhoahoc.Items.Add("--");
            string queryt = "select * from KhoaHoc";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvdiem.DataSource = dtt;
            if (dtt != null && dgvdiem.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvdiem.Rows.Count - 1; i++)
                {
                    cbbkhoahoc.Items.Add(dgvdiem.Rows[i].Cells["KyHoc"].Value.ToString());
                }
                cbbkhoahoc.SelectedItem = "--";
            }
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,nhomhp,GiangVien Where GiangVien.MaGV=nhomhp.MaGV and Diem.MaNhomHP=nhomhp.MaNhomHP and GiangVien.UseName= '" + tk + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvdiem.DataSource = dt;
            conn.Close();
        }

        private void cbblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbmasv.Items.Clear();
            cbbmasv.Items.Add("--");
            string queryt = "select * from Diem,SinhVien,nhomhp,GiangVien Where SinhVien.TenLop='" + cbblop.SelectedItem.ToString() + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and Diem.MaNhomHP=nhomhp.MaNhomHP and GiangVien.MaGV=nhomhp.MaGV and GiangVien.UseName='" + tk + "'";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvdiem.DataSource = dtt;
            if (dtt != null && dgvdiem.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvdiem.Rows.Count - 1; i++)
                {
                    cbbmasv.Items.Add(dgvdiem.Rows[i].Cells["MaSinhVien"].Value.ToString());
                }
                cbbmasv.SelectedItem = "--";
            }
            try
            {
                if (cbblop.SelectedItem.Equals("--"))
                {

                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,nhomhp,KeHoachDaoTao Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and nhomhp.MaGV=GiangVien.MaGV and nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.UseName='" + tk + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and nhomhp.MaGV=GiangVien.MaGV and nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.UseName='" + tk + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbkhoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbblop.Items.Clear();
            cbblop.Items.Add("--");
            string queryt = "select * from KeHoachDaoTao,KhoaHoc Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc";
            SqlCommand cmdt = new SqlCommand(queryt, conn);
            SqlDataAdapter datat = new SqlDataAdapter(cmdt);
            DataTable dtt = new DataTable();
            datat.Fill(dtt);
            dgvdiem.DataSource = dtt;
            if (dtt != null && dgvdiem.Rows.Count > 0)
            {

                for (int i = 0; i <= dgvdiem.Rows.Count - 1; i++)
                {
                    cbblop.Items.Add(dgvdiem.Rows[i].Cells["TenLop"].Value.ToString());
                }
                cbblop.SelectedItem = "--";
            }
            try
            {
                if (cbbkhoahoc.SelectedItem.Equals("--"))
                {

                    conn.Open();
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,nhomhp,GiangVien Where GiangVien.MaGV=nhomhp.MaGV and Diem.MaNhomHP=nhomhp.MaNhomHP and GiangVien.UseName= '" + tk + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,nhomhp,KeHoachDaoTao Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and nhomhp.MaGV=GiangVien.MaGV and nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.UseName='" + tk + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbblop.SelectedItem.Equals("--"))
                {

                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and nhomhp.MaGV=GiangVien.MaGV and nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.UseName='" + tk + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    string query = "select Diem.MaSinhVien,Diem.ChuyenCan,Diem.KiemTraGK,Diem.ThucHanh,Diem.ThiKetThuc,Diem.ThoaLuan,Diem.TongKetHP,Diem.DiemChu from Diem,KhoaHoc,GiangVien,nhomhp,KeHoachDaoTao,SinhVien Where KhoaHoc.KyHoc='" + cbbkhoahoc.SelectedItem.ToString() + "' and KhoaHoc.MaKhoaHoc=KeHoachDaoTao.MaKhoaHoc and KeHoachDaoTao.MaKHDT=nhomhp.MaKHDT and nhomhp.MaGV=GiangVien.MaGV and nhomhp.MaNhomHP=Diem.MaNhomHP and GiangVien.UseName='" + tk + "' and SinhVien.MaSinhVien=Diem.MaSinhVien and SinhVien.TenLop='" + cbblop.SelectedItem.ToString() + "' and Diem.MaSinhVien='" + cbbmasv.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvdiem.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvdiem.Rows[e.RowIndex];
            lblmasv.Text = i.Cells[0].Value.ToString();
            txtchuyencan.Text = i.Cells[1].Value.ToString();
            txtgiuaki.Text = i.Cells[2].Value.ToString();
            txtthuchanh.Text = i.Cells[3].Value.ToString();
            txtketthuc.Text = i.Cells[4].Value.ToString();
            txtthaoluan.Text = i.Cells[5].Value.ToString();
            lbltongket.Text = i.Cells[6].Value.ToString();
            lbldiemchu.Text = i.Cells[7].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            cbbluachon.SelectedItem = "(--)";
            cbbluachon.Enabled = true;
            txtchuyencan.Enabled = true;
            txtgiuaki.Enabled = true;
            txtketthuc.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
           if(txtthuchanh.Enabled==false && txtthaoluan.Enabled==false)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtketthuc.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan.Text)*0.1+float.Parse(txtgiuaki.Text)*0.2+float.Parse(txtketthuc.Text)*0.7);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmqldiemsv_Load(sender, e);
                txtchuyencan.Enabled = false;
                txtgiuaki.Enabled = false;
                txtthuchanh.Enabled = false;
                txtketthuc.Enabled = false;
                txtthaoluan.Enabled = false;
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                cbbluachon.Enabled = false;
            }
           else if(txtthuchanh.Enabled==true)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThucHanh=@ThucHanh, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki.Text);
                cmd.Parameters.AddWithValue("@ThucHanh", txtthuchanh.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtketthuc.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan.Text) * 0.1 + float.Parse(txtgiuaki.Text) * 0.1 + float.Parse(txtthuchanh.Text)*0.1 + float.Parse(txtketthuc.Text) * 0.7);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmqldiemsv_Load(sender, e);
                txtchuyencan.Enabled = false;
                txtgiuaki.Enabled = false;
                txtthuchanh.Enabled = false;
                txtketthuc.Enabled = false;
                txtthaoluan.Enabled = false;
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                cbbluachon.Enabled = false;
            }  
           else if(txtthaoluan.Enabled==true)
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "update Diem set ChuyenCan=@ChuyenCan,KiemTraGK=@KiemTraGK, ThoaLuan=@ThoaLuan, ThiKetThuc=@ThiKetThuc, TongKetHP=@TongKetHP where MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", lblmasv.Text);
                cmd.Parameters.AddWithValue("@ChuyenCan", txtchuyencan.Text);
                cmd.Parameters.AddWithValue("@KiemTraGK", txtgiuaki.Text);
                cmd.Parameters.AddWithValue("@ThoaLuan", txtthaoluan.Text);
                cmd.Parameters.AddWithValue("@ThiKetThuc", txtketthuc.Text);
                cmd.Parameters.AddWithValue("@TongKetHP", float.Parse(txtchuyencan.Text) * 0.1 + float.Parse(txtgiuaki.Text) * 0.1 + float.Parse(txtthaoluan.Text) * 0.1 + float.Parse(txtketthuc.Text) * 0.7);
                cmd.ExecuteNonQuery();
                conn.Close();
                frmqldiemsv_Load(sender, e);
                txtchuyencan.Enabled = false;
                txtgiuaki.Enabled = false;
                txtthuchanh.Enabled = false;
                txtketthuc.Enabled = false;
                txtthaoluan.Enabled = false;
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                cbbluachon.Enabled = false;
            }    
        }

        private void cbbluachon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbluachon.SelectedItem.Equals("Thực hành"))
            {
                txtthuchanh.Enabled = true;
                txtthaoluan.Enabled = false;
                cbbluachon.Enabled = false;
            }
            else if (cbbluachon.SelectedItem.Equals("Thảo luận"))
            {
                txtthaoluan.Enabled = true;
                txtthuchanh.Enabled = false;
                cbbluachon.Enabled = false;
            }
            else
            {
                txtthaoluan.Enabled = false;
                txtthuchanh.Enabled = false;
            }
        }
    }
}
