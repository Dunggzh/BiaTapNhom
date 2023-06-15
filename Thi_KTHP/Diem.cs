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
    public partial class frmqtdiem : Form
    {
        public frmqtdiem()
        {
            InitializeComponent();
            //Loadcboboxmasv("select * from SinhVien", "TenSinhVien", "MaSinhVien");
            //Loadcboboxmahp("SELECT * FROM NhomHP", "MaNhomHP", "MaNhomHP");
            Setstatus("reset");
            BindingData();
        }

        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
        //public void Loadcboboxmasv(string query, string dis, string valu)
        //{

        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    conn.Close();
        //    cboqtmasv.DataSource = ds.Tables[0];
        //    cboqtmasv.DisplayMember = dis;
        //    cboqtmasv.ValueMember = valu;
        //}
        //public void Loadcboboxmahp(string query, string dis, string valu)
        //{
        //    if (conn.State == ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    conn.Close();
        //    cboqtnhomhocphan.DataSource = ds.Tables[0];
        //    cboqtnhomhocphan.DisplayMember = dis;
        //    cboqtnhomhocphan.ValueMember = valu;
        //}
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemdiem.Enabled = true;
                    btnqtsuadiem.Enabled = true;
                    btnqtxoadiem.Enabled = true;
                    btnqtghidiem.Enabled = false;
                    btnqthuydiem.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkdiem.Enabled = true;

                    dgvqtdiem.Enabled = true;

                    txtqtdiemcc.Enabled = false;
                    txtqtdiemgk.Enabled = false;
                    txtqtdiemth.Enabled = false;
                    txtqtdiemkt.Enabled = false;
                    txtqtdiemtl.Enabled = false;
                    txtqtdiemtongket.Enabled = false;
                    txtqtdiemchu.Enabled = false;
                    cboqtmasv.Enabled = false;
                    cboqtnhomhocphan.Enabled = false;
                    txtqttensv.Enabled = false;
                    txtqttenhp.Enabled = false;
                    txtqttkdiem.Enabled = true;
  

                    break;
                case "insert":
                    btnqtthemdiem.Enabled = false;
                    btnqtsuadiem.Enabled = false;
                    btnqtxoadiem.Enabled = false;
                    btnqtghidiem.Enabled = true;
                    btnqthuydiem.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkdiem.Enabled = false;

                    dgvqtdiem.Enabled = false;

                    txtqtdiemcc.Enabled = true;
                    txtqtdiemgk.Enabled = true;
                    txtqtdiemth.Enabled = true;
                    txtqtdiemkt.Enabled = true;
                    txtqtdiemtl.Enabled = true;
                    txtqtdiemtongket.Enabled = false;
                    txtqtdiemchu.Enabled = false;
                    cboqtmasv.Enabled = true;
                    cboqtnhomhocphan.Enabled = true;
                    txtqttensv.Enabled = true;
                    txtqttenhp.Enabled = true;
                    txtqttkdiem.Enabled = false;



                    txtqtdiemcc.Text = "";
                    txtqtdiemgk.Text = "";
                    txtqtdiemth.Text = "";
                    txtqtdiemkt.Text = "";
                    txtqtdiemtl.Text = "";
                    txtqtdiemtongket.Text = "";
                    txtqtdiemchu.Text = "";
                    txtqttkdiem.Text = "";

                    txtqtdiemcc.Focus();
                    break;
                case "edit":
                    btnqtthemdiem.Enabled = false;
                    btnqtsuadiem.Enabled = false;
                    btnqtxoadiem.Enabled = false;
                    btnqtghidiem.Enabled = true;
                    btnqthuydiem.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkdiem.Enabled = false;

                    txtqtdiemcc.Enabled = true;
                    txtqtdiemgk.Enabled = true;
                    txtqtdiemth.Enabled = true;
                    txtqtdiemkt.Enabled = true;
                    txtqtdiemtl.Enabled = true;
                    txtqtdiemtongket.Enabled = false;
                    txtqtdiemchu.Enabled = false;
                    cboqtmasv.Enabled = false;
                    cboqtnhomhocphan.Enabled = true;
                    txtqttensv.Enabled = true;
                    txtqttenhp.Enabled = true;
                    txtqttkdiem.Enabled = false;

                    txtqttkdiem.Text = "";

                    txtqtdiemcc.Focus();
                    break;
                default: break;
            }
        }

        public void BindingData()
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT ChuyenCan as'Chuyên Cần', KiemTraGK as'Kiểm Tra GK', ThucHanh as'Thực Hành',  ThiKetthuc as'Thi Kết Thúc', ThaoLuan as'Thảo Luận', TongKetHP as'Tổng Kết HP', DiemChu as'Điểm Chữ', MaSinhVien as'Mã Sinh Viên', MaNhomHP as'Mã Nhóm HP' FROM Diem";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtdiem.DataSource = ds.Tables[0];

                    txtqtdiemcc.Text = ds.Tables[0].Rows[0]["Chuyên Cần"].ToString();
                    txtqtdiemgk.Text = ds.Tables[0].Rows[0]["Kiểm Tra GK"].ToString();
                    txtqtdiemth.Text = ds.Tables[0].Rows[0]["Thực Hành"].ToString();
                    txtqtdiemkt.Text = ds.Tables[0].Rows[0]["Thi Kết Thúc"].ToString();
                    txtqtdiemtl.Text = ds.Tables[0].Rows[0]["Thảo Luận"].ToString();
                    txtqtdiemtongket.Text = ds.Tables[0].Rows[0]["Tổng Kết HP"].ToString();
                    txtqtdiemchu.Text = ds.Tables[0].Rows[0]["Điểm Chữ"].ToString();

                    cboqtmasv.SelectedValue = ds.Tables[0].Rows[0]["Mã Sinh Viên"].ToString();
                    cboqtnhomhocphan.SelectedValue = ds.Tables[0].Rows[0]["Mã Nhóm HP"].ToString();


                    // bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Mã Nhóm HP"].ToString();
                    b = dss.Tables[0].Rows[0]["Chuyên Cần"].ToString();
                    c = dss.Tables[0].Rows[0]["Kiểm Tra GK"].ToString();
                    d = dss.Tables[0].Rows[0]["Thi Kết Thúc"].ToString();
                    f = dss.Tables[0].Rows[0]["Thảo Luận"].ToString();
                    h = dss.Tables[0].Rows[0]["Thực Hành"].ToString();

                }
                else
                {
                    dgvqtdiem.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemdiem_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuadiem_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoadiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.Diem WHERE MaSinhVien='" + cboqtmasv.SelectedValue.ToString() + "' AND MaNhomHP= '" + cboqtnhomhocphan.SelectedValue.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttkdiem.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Vui lòng xóa dữ liệu Khóa Học này ở bảng Kế Hoạch Đào Tạo để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuydiem_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtdiemcc.Text = "";
                txtqtdiemgk.Text = "";
                txtqtdiemth.Text = "";
                txtqtdiemkt.Text = "";
                txtqtdiemtl.Text = "";
                txtqtdiemtongket.Text = "";
                txtqtdiemchu.Text = "";
                txtqttkdiem.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        static Double diemcc = 0;
        static Double diemgk = 0;
        static Double diemthikt = 0;
        static Double diemth = 0;
        static Double diemtl = 0;
        static double diemtongket = 0;
        static bool check1 = false;
        static bool check2 = false;
        static bool check3 = false;

        public void TinhDiem()
        {
            try
            {
                check1 = false;
                check2 = false;
                check3 = false;





                if (txtqtdiemth.Text == "" && txtqtdiemtl.Text == "")
                {
                    check1 = true;
                }
                else if (txtqtdiemth.Text != "" && txtqtdiemtl.Text == "")
                {
                    check2 = true;
                    diemth = Double.Parse(txtqtdiemth.Text.Trim());
                }
                else if (txtqtdiemth.Text == "" && txtqtdiemtl.Text != "")
                {
                    check3 = true;
                    diemtl = Double.Parse(txtqtdiemtl.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Trường Thực Hành Và Trường Thảo Luận");
                }
                diemcc = Double.Parse(txtqtdiemcc.Text.Trim());
                diemgk = Double.Parse(txtqtdiemgk.Text.Trim());
                diemthikt = Double.Parse(txtqtdiemkt.Text.Trim());

                
                if (check1 == true)
                {
                    diemtongket = diemcc * 0.1 + diemgk * 0.2 + diemthikt * 0.7;
                }
                else if (check2 == true)
                {
                    diemtongket = diemcc * 0.1 + diemgk * 0.1 + diemth * 0.1 + diemthikt * 0.7;
                }
                else if (check3 == true)
                {
                    diemtongket = diemcc * 0.1 + diemgk * 0.1 + diemtl * 0.1 + diemthikt * 0.7;
                }
                
                if(check1== true|| check2 == true|| check3 == true)
                {
                    string diemchu = "";
                    txtqtdiemtongket.Text = diemtongket.ToString();
                    if (diemtongket >= 8.5)
                    {
                        diemchu = "A";
                    }else if(diemtongket < 8.5 && diemtongket >= 8)
                    {
                        diemchu = "B+";
                    }else if(diemtongket < 8 && diemtongket >= 7.5)
                    {
                        diemchu= "B";
                    }else if(diemtongket < 7.5 && diemtongket >= 6)
                    {
                        diemchu = "C+";
                    }else if(diemtongket < 6 && diemtongket >=5.5)
                    {
                        diemchu= "C";
                    }else if(diemtongket < 5.5 && diemtongket >= 5)
                    {
                        diemchu= "D+";
                    }else if(diemtongket < 5 && diemtongket >= 4)
                    {
                        diemchu= "D";
                    }
                    else
                    {
                        diemchu= "F";
                    }
                    txtqtdiemchu.Text = diemchu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        static string a = null;
        static string b = null;
        static string c = null;
        static string d = null;
        static string f = null;
        static string h = null;
        private void btnqtghidiem_Click(object sender, EventArgs e)
        {
            try
            {
                TinhDiem();

                errorbatloi.Clear();
                bool check = true; double output;
                if (cboqtmasv.Text == "--")
                {
                    check = false;
                    errorbatloi.SetError(cboqtmasv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (cboqtnhomhocphan.Text == "--")
                {
                    check = false;
                    errorbatloi.SetError(cboqtnhomhocphan, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtdiemcc.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtdiemcc, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (double.TryParse(txtqtdiemcc.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtdiemcc, "Sai Định Dạng");
                    }
                }
                if (txtqtdiemgk.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtdiemgk, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (double.TryParse(txtqtdiemgk.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtdiemgk, "Sai Định Dạng");
                    }
                }
                if (txtqtdiemkt.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtdiemkt, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (double.TryParse(txtqtdiemkt.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtdiemkt, "Sai Định Dạng");
                    }
                }
                if (status == "insert"&&check==true)
                {
                    string query = ""; bool check4 = true;
                    if (check1 == true)
                    {
                        query = "INSERT INTO Diem (ChuyenCan,KiemTraGK,ThiKetthuc,TongKetHP,DiemChu,MaSinhVien,MaNhomHP) VALUES ('" + float.Parse(txtqtdiemcc.Text.ToString()) + "','" + float.Parse(txtqtdiemgk.Text.Trim()) + "','" + float.Parse(txtqtdiemkt.Text.Trim()) + "','" + float.Parse(txtqtdiemtongket.Text.Trim()) + "','" + txtqtdiemchu.Text.Trim() + "','" + cboqtmasv.SelectedItem.ToString() + "','" + cboqtnhomhocphan.SelectedItem.ToString() + "')";
                    }
                    else if (check2 == true)
                    {
                        query = "INSERT INTO Diem (ChuyenCan,KiemTraGK,ThucHanh,ThiKetthuc,TongKetHP,DiemChu,MaSinhVien,MaNhomHP) VALUES ('" + float.Parse(txtqtdiemcc.Text.ToString()) + "','" + float.Parse(txtqtdiemgk.Text.Trim()) + "','" + float.Parse(txtqtdiemth.Text.Trim()) + "','" + float.Parse(txtqtdiemkt.Text.Trim()) + "','" + float.Parse(txtqtdiemtongket.Text.Trim()) + "','" + txtqtdiemchu.Text.Trim() + "','" + cboqtmasv.SelectedItem.ToString() + "','" + cboqtnhomhocphan.SelectedItem.ToString() + "')";
                    }
                    else if (check3 == true)
                    {
                        query = "INSERT INTO Diem (ChuyenCan,KiemTraGK,ThiKetthuc,ThaoLuan,TongKetHP,DiemChu,MaSinhVien,MaNhomHP) VALUES ('" + float.Parse(txtqtdiemcc.Text.ToString()) + "','" + float.Parse(txtqtdiemgk.Text.Trim()) + "','" + float.Parse(txtqtdiemkt.Text.Trim()) + "','" + float.Parse(txtqtdiemtl.Text.Trim()) + "','" + float.Parse(txtqtdiemtongket.Text.Trim()) + "','" + txtqtdiemchu.Text.Trim() + "','" + cboqtmasv.SelectedItem.ToString() + "','" + cboqtnhomhocphan.SelectedItem.ToString() + "')";
                    }
                    else
                    {
                        check4= false;
                    }

                    if(check4 == true)
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        //string query = "INSERT INTO Diem (ChuyenCan,KiemTraGK,ThucHanh,ThiKetthuc,ThaoLuan,TongKetHP,DiemChu,MaSinhVien,MaNhomHP) VALUES ('" +float.Parse(txtqtdiemcc.Text.ToString()) + "','" + float.Parse(txtqtdiemgk.Text.Trim()) + "','" + float.Parse(txtqtdiemth.Text.Trim()) + "','" + float.Parse(txtqtdiemkt.Text.Trim()) + "','" + float.Parse(txtqtdiemtl.Text.Trim()) + "','" + float.Parse(txtqtdiemtongket.Text.Trim()) + "','" + txtqtdiemchu.Text.Trim() + "','" + cboqtmasv.SelectedValue.ToString() + "','" + cboqtnhomhocphan.SelectedValue.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        var result = cmd.ExecuteNonQuery();
                        if (result != 0)
                        {
                            //query = "";
                            MessageBox.Show("Insert success");
                            status = "reset";
                            Setstatus(status);
                            BindingData();

                        }
                        else
                        {
                            MessageBox.Show("Insert error");
                        }
                        conn.Close();
                    }
                    
                }
                if (status == "edit" && check == true)
                {
                    string query = ""; bool check5 = true;
                    if (check1 == true)
                    {
                        query = "UPDATE dbo.Diem SET ChuyenCan='" + float.Parse(txtqtdiemcc.Text.Trim()) + "',KiemTraGK='" + float.Parse(txtqtdiemgk.Text.Trim()) + "',ThiKetThuc='" + float.Parse(txtqtdiemkt.Text.Trim()) + "',TongKetHP='" + float.Parse(txtqtdiemtongket.Text.Trim()) + "',DiemChu='" + txtqtdiemchu.Text.Trim() + "',MaNhomHP='" + cboqtnhomhocphan.SelectedItem.ToString() + "' WHERE MaSinhVien = '" + cboqtmasv.SelectedItem.ToString() + "'";
                    }else if(check2 == true)
                    {
                        query = "UPDATE dbo.Diem SET ChuyenCan='" + float.Parse(txtqtdiemcc.Text.Trim()) + "',KiemTraGK='" + float.Parse(txtqtdiemgk.Text.Trim()) + "',ThucHanh='" + float.Parse(txtqtdiemth.Text.Trim()) + "',ThiKetThuc='" + float.Parse(txtqtdiemkt.Text.Trim()) + "',TongKetHP='" + float.Parse(txtqtdiemtongket.Text.Trim()) + "',DiemChu='" + txtqtdiemchu.Text.Trim() + "',MaNhomHP='" + cboqtnhomhocphan.SelectedItem.ToString() + "' WHERE MaSinhVien = '" + cboqtmasv.SelectedItem.ToString() + "'";
                    }else if(check3 == true)
                    {
                        query = "UPDATE dbo.Diem SET ChuyenCan='" + float.Parse(txtqtdiemcc.Text.Trim()) + "',KiemTraGK='" + float.Parse(txtqtdiemgk.Text.Trim()) + "',ThiKetThuc='" + float.Parse(txtqtdiemkt.Text.Trim()) + "',ThaoLuan='" + float.Parse(txtqtdiemtl.Text.Trim()) + "',TongKetHP='" + float.Parse(txtqtdiemtongket.Text.Trim()) + "',DiemChu='" + txtqtdiemchu.Text.Trim() + "',MaNhomHP='" + cboqtnhomhocphan.SelectedItem.ToString() + "' WHERE MaSinhVien = '" + cboqtmasv.SelectedItem.ToString() + "'";
                    }
                    else
                    {
                        check5 = false;
                    }

                    if(check5 == true)
                    {

                        if (cboqtnhomhocphan.SelectedItem.Equals(a) && txtqtdiemcc.Text.Equals(b) && txtqtdiemgk.Text.Equals(c) && txtqtdiemkt.Text.Equals(d))
                        {
                            MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                            txtqtdiemcc.Focus();
                        }
                        else
                        {
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            //query = "UPDATE dbo.SinhVien SET ChuyenCan='" + float.Parse(txtqtdiemcc.Text.Trim()) + "',KiemTraGK='" + float.Parse(txtqtdiemgk.Text.Trim()) + "',ThucHanh='" + float.Parse(txtqtdiemth.Text.Trim()) + "',ThiKetThuc='" + float.Parse(txtqtdiemkt.Text.Trim()) + "',ThaoLuan='" + float.Parse(txtqtdiemtl.Text.Trim()) + "',TongKetHP='" + float.Parse(txtqtdiemtongket.Text.Trim()) + "',DiemChu='" + txtqtdiemchu.Text.Trim() + "',MaNhomHP='" + cboqtnhomhocphan.SelectedValue.ToString() + "' WHERE MaSinhVien = '" + cboqtmasv.SelectedValue.ToString() + "'";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            var result = cmd.ExecuteNonQuery();
                            if (result != 0)
                            {
                                MessageBox.Show("Update success");

                                status = "reset";
                                Setstatus(status);
                                BindingData();
                            }
                            else
                            {
                                MessageBox.Show("UpDate error");
                            }
                            conn.Close();
                        }
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvqtdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtdiem.Rows[e.RowIndex];
                txtqtdiemcc.Text = row.Cells["Chuyên Cần"].Value.ToString();
                txtqtdiemgk.Text = row.Cells["Kiểm Tra GK"].Value.ToString();
                txtqtdiemth.Text = row.Cells["Thực Hành"].Value.ToString();
                txtqtdiemkt.Text = row.Cells["Thi Kết Thúc"].Value.ToString();
                txtqtdiemtl.Text = row.Cells["Thảo Luận"].Value.ToString();
                txtqtdiemtongket.Text = row.Cells["Tổng Kết HP"].Value.ToString();
                txtqtdiemchu.Text = row.Cells["Điểm Chữ"].Value.ToString();

                cboqtmasv.Text = row.Cells["Mã Sinh Viên"].Value.ToString();
                cboqtnhomhocphan.Text = row.Cells["Mã Nhóm HP"].Value.ToString();

                a = row.Cells["Mã Nhóm HP"].Value.ToString();
                b = row.Cells["Chuyên Cần"].Value.ToString();
                c = row.Cells["Kiểm Tra GK"].Value.ToString();
                d = row.Cells["Thi Kết Thúc"].Value.ToString();
                f = row.Cells["Thảo Luận"].Value.ToString();
                h = row.Cells["Thực Hành"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t Sắp Xếp");
            }
        }

        private void frmqtdiem_Load(object sender, EventArgs e)
        {
            try
            {
                cboqtmasv.SelectedItem = "--";

                string query = "select * from SinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmasv.Items.Add(ds.Tables[0].Rows[i]["MaSinhVien"].ToString());
                }
                
                cboqtnhomhocphan.SelectedItem = "--";
                string query1 = "select * from NhomHP";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                for (int i = 0; i <= ds1.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtnhomhocphan.Items.Add(ds1.Tables[0].Rows[i]["MaNhomHP"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void cboqtmasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboqtmasv.SelectedItem.ToString() != "")
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "select * from SinhVien where MaSinhVien='" + cboqtmasv.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        txtqttensv.Text = ds.Tables[0].Rows[0]["TenSV"].ToString();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }

            
        }

        private void cboqtnhomhocphan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboqtnhomhocphan.SelectedItem.ToString() != "")
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "select * from NhomHP,HocPhan where NhomHP.MaHP=HocPhan.MaHP and NhomHP.MaNhomHP='" + cboqtnhomhocphan.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        txtqttenhp.Text = ds.Tables[0].Rows[0]["TenHP"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void txtqttensv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqttenhp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            try
            {
                Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Điểm");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkdiem_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkdiem.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkdiem.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT ChuyenCan as'Chuyên Cần', KiemTraGK as'Kiểm Tra GK', ThucHanh as'Thực Hành',  ThiKetthuc as'Thi Kết Thúc', ThaoLuan as'Thảo Luận', TongKetHP as'Tổng Kết HP', DiemChu as'Điểm Chữ', MaSinhVien as'Mã Sinh Viên', MaNhomHP as'Mã Nhóm HP' FROM dbo.Diem WHERE MaSinhVien LIKE '%" + txtqttkdiem.Text.Trim() + "%' OR MaNhomHP LIKE N'%" + txtqttkdiem.Text.Trim() + "%' OR DiemChu LIKE '%" + txtqttkdiem.Text.Trim() + "%' OR TongKetHP LIKE N'%" + txtqttkdiem.Text.Trim() + "%' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    //export excell
                    dss = ds;
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        status = "reset";
                        Setstatus(status);
                        txtqttkdiem.Focus();

                        dgvqtdiem.DataSource = ds.Tables[0];

                        txtqtdiemcc.Text = ds.Tables[0].Rows[0]["Chuyên Cần"].ToString();
                        txtqtdiemgk.Text = ds.Tables[0].Rows[0]["Kiểm Tra GK"].ToString();
                        txtqtdiemth.Text = ds.Tables[0].Rows[0]["Thực Hành"].ToString();
                        txtqtdiemkt.Text = ds.Tables[0].Rows[0]["Thi Kết Thúc"].ToString();
                        txtqtdiemtl.Text = ds.Tables[0].Rows[0]["Thảo Luận"].ToString();
                        txtqtdiemtongket.Text = ds.Tables[0].Rows[0]["Tổng Kết HP"].ToString();
                        txtqtdiemchu.Text = ds.Tables[0].Rows[0]["Điểm Chữ"].ToString();

                        cboqtmasv.SelectedValue = ds.Tables[0].Rows[0]["Mã Sinh Viên"].ToString();
                        cboqtnhomhocphan.SelectedValue = ds.Tables[0].Rows[0]["Mã Nhóm HP"].ToString();


                        // bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Mã Nhóm HP"].ToString();
                        b = dss.Tables[0].Rows[0]["Chuyên Cần"].ToString();
                        c = dss.Tables[0].Rows[0]["Kiểm Tra GK"].ToString();
                        d = dss.Tables[0].Rows[0]["Thi Kết Thúc"].ToString();
                        f = dss.Tables[0].Rows[0]["Thảo Luận"].ToString();
                        h = dss.Tables[0].Rows[0]["Thực Hành"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không Tìm Thấy Thông Tin");
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
    }
}
