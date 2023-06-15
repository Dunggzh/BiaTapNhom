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
    public partial class frmqtsv : Form
    {
        public frmqtsv()
        {
            InitializeComponent();
            //Loadcboboxlop("SELECT * FROM Lop", "TenLop", "TenLop");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
        //public void Loadcboboxlop(string query, string dis, string valu)
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
        //    cboqttenlop.DataSource = ds.Tables[0];
        //    cboqttenlop.DisplayMember = dis;
        //    cboqttenlop.ValueMember = valu;
        //}
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = true;
                    btnqtsuasv.Enabled = true;
                    btnqtxoasv.Enabled = true;
                    btnqtghisv.Enabled = false;
                    btnqthuysv.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttksv.Enabled = true;
                    

                    dgvqtsv.Enabled = true;

                    txtqtmasv.Enabled = false;
                    txtqttensv.Enabled = false;
                    txtqtquequansv.Enabled = false;
                    dtpngaysinhsv.Enabled = false;
                    txtqtnoisinhsv.Enabled = false;
                    rdoqtnam.Enabled = false;
                    rdoqtnu.Enabled = false;
                    cboqttenlop.Enabled = false;
                    txtqtghichu.Enabled = false;
                    txtqttksv.Enabled = true;
                    cboqttenkhoa.Enabled = false;
                    cboqttennganh.Enabled = false;


                    break;
                case "insert":
                    rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = false;
                    btnqtsuasv.Enabled = false;
                    btnqtxoasv.Enabled = false;
                    btnqtghisv.Enabled = true;
                    btnqthuysv.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttksv.Enabled = false;

                    dgvqtsv.Enabled = false;

                    txtqtmasv.Enabled = true;
                    txtqttensv.Enabled = true;
                    txtqtquequansv.Enabled = true;
                    dtpngaysinhsv.Enabled = true;
                    txtqtnoisinhsv.Enabled = true;
                    rdoqtnam.Enabled = true;
                    rdoqtnu.Enabled = true;
                    cboqttenlop.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttksv.Enabled = false;
                    cboqttenkhoa.Enabled = true;
                    cboqttennganh.Enabled = true;

                    txtqtmasv.Text = "";
                    txtqttensv.Text = "";
                    txtqtquequansv.Text = "";
                    txtqtnoisinhsv.Text = "";
                    txtqtghichu.Text = "";
                    txtqttksv.Text = "";

                    txtqtmasv.Focus();
                    break;
                case "edit":
                    //rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = false;
                    btnqtsuasv.Enabled = false;
                    btnqtxoasv.Enabled = false;
                    btnqtghisv.Enabled = true;
                    btnqthuysv.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttksv.Enabled = false;

                    txtqtmasv.Enabled = false;
                    txtqttensv.Enabled = true;
                    txtqtquequansv.Enabled = true;
                    dtpngaysinhsv.Enabled = true;
                    txtqtnoisinhsv.Enabled = true;
                    rdoqtnam.Enabled = true;
                    rdoqtnu.Enabled = true;
                    cboqttenlop.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttksv.Enabled = false;
                    cboqttenkhoa.Enabled = true;
                    cboqttennganh.Enabled = true;

                    txtqttksv.Text = "";

                    txtqttensv.Focus();
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
                string query = "SELECT MaSinhVien as'Mã Sinh Viên', TenSV as'Tên Sinh Viên', QueQuan as'Quê Quán', NgaySinh as'Ngày Sinh', NoiSinh as'Nơi Sinh', GioiTinh as'Giới Tính', TenLop as'Tên Lớp', GhiChu as'Ghi Chú' FROM SinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtsv.DataSource = ds.Tables[0];

                    txtqtmasv.Text = ds.Tables[0].Rows[0]["Mã Sinh Viên"].ToString();
                    txtqttensv.Text = ds.Tables[0].Rows[0]["Tên Sinh Viên"].ToString();
                    txtqtquequansv.Text = ds.Tables[0].Rows[0]["Quê Quán"].ToString();
                    dtpngaysinhsv.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Ngày Sinh"]);
                    txtqtnoisinhsv.Text = ds.Tables[0].Rows[0]["Nơi Sinh"].ToString();
                    if (ds.Tables[0].Rows[0]["Giới Tính"].ToString() == "NAM")
                    {
                        rdoqtnam.Checked = true;
                        rdoqtnu.Checked = false;
                    }
                    else
                    {
                        rdoqtnam.Checked = false;
                        rdoqtnu.Checked = true;
                    }
                    cboqttenlop.SelectedValue = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();

                    // bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Sinh Viên"].ToString();
                    b = dss.Tables[0].Rows[0]["Quê Quán"].ToString();
                   
                    c = dss.Tables[0].Rows[0]["Nơi Sinh"].ToString();
                    // bắt lỗi ghi sửa
                   
                    d = dss.Tables[0].Rows[0]["Tên Lớp"].ToString();
                    f = dss.Tables[0].Rows[0]["Ghi Chú"].ToString();


                }
                else
                {
                    dgvqtsv.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemsv_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuasv_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoasv_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.SinhVien WHERE MaSinhVien='" + txtqtmasv.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttksv.Text = "";
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
                MessageBox.Show(ex.Message + "\n Vui lòng xóa dữ liệu Ngành này ở bảng Lớp để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuysv_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmasv.Text = "";
                txtqttensv.Text = "";
                txtqtquequansv.Text = "";
                txtqtnoisinhsv.Text = "";
                txtqtghichu.Text = "";
                txtqttksv.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghisv_Click(object sender, EventArgs e)
        {
            try
            {

                errorbatloi.Clear();
                bool check = true;
                if (txtqtmasv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmasv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttensv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttensv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtnoisinhsv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtnoisinhsv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtquequansv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtquequansv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtghichu.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtghichu, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }



                string gt = "";
                if (rdoqtnam.Checked)
                {
                    gt = "NAM";

                }
                else
                {
                    gt = "NỮ";
                }


                if (status == "insert"&&check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO SinhVien (MaSinhVien,TenLop,TenSV,QueQuan,NgaySinh,NoiSinh,GioiTinh,GhiChu) VALUES ('" + txtqtmasv.Text.Trim() + "','" + cboqttenlop.SelectedItem.ToString() + "',N'" + txtqttensv.Text.Trim() + "',N'" + txtqtquequansv.Text.Trim() + "','" + dtpngaysinhsv.Value + "',N'" + txtqtnoisinhsv.Text.Trim() + "',N'" + gt + "',N'" + txtqtghichu.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
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
                if (status == "edit" && check == true)
                {
                    if (txtqttensv.Text.Equals(a) && txtqtquequansv.Text.Equals(b)&&txtqtnoisinhsv.Text.Equals(c)&&cboqttenlop.SelectedItem.Equals(d)&&txtqtghichu.Text.Equals(f))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttensv.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.SinhVien SET TenLop=N'" + cboqttenlop.SelectedItem.ToString() + "',TenSV=N'" + txtqttensv.Text.Trim() + "',QueQuan=N'" + txtqtquequansv.Text.Trim() + "',NgaySinh='" + dtpngaysinhsv.Value + "',NoiSinh=N'" + txtqtnoisinhsv.Text.Trim() + "',GioiTinh=N'" + gt + "',GhiChu=N'" + txtqtghichu.Text.Trim() + "' WHERE MaSinhVien='" + txtqtmasv.Text.Trim() + "'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Mã Ngành đã tồn tại!");
                txtqtmasv.Focus();
            }
        }
        static string a = null;
        static string b = null;
        static string c = null;
        static string d = null;
        static string f = null;
        private void dgvqtsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var row = (DataGridViewRow)dgvqtsv.Rows[e.RowIndex];


                txtqtmasv.Text = row.Cells["Mã Sinh Viên"].Value.ToString();
                txtqttensv.Text = row.Cells["Tên Sinh Viên"].Value.ToString();
                txtqtquequansv.Text = row.Cells["Quê Quán"].Value.ToString();
                dtpngaysinhsv.Value = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value);
                txtqtnoisinhsv.Text = row.Cells["Nơi Sinh"].Value.ToString();
                if (row.Cells["Giới Tính"].Value.ToString() == "NAM")
                {
                    rdoqtnam.Checked = true;
                    rdoqtnu.Checked = false;
                }
                else
                {
                    rdoqtnam.Checked = false;
                    rdoqtnu.Checked = true;
                }
                cboqttenlop.Text = row.Cells["Tên Lớp"].Value.ToString();
                txtqtghichu.Text = row.Cells["Ghi Chú"].Value.ToString();

                // bắt lỗi ghi sửa
                a = row.Cells["Tên Sinh Viên"].Value.ToString();
                b = row.Cells["Quê Quán"].Value.ToString();

                c = row.Cells["Nơi Sinh"].Value.ToString();
                // bắt lỗi ghi sửa

                d = row.Cells["Tên Lớp"].Value.ToString();
                f = row.Cells["Ghi Chú"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t Sắp Xếp");
            }
        }

        private void frmqtsv_Load(object sender, EventArgs e)
        {
            try
            {
                cboqttenkhoa.SelectedItem = "--";
                cboqttennganh.SelectedItem = "--";
                cboqttenlop.SelectedItem = "--";
                string query = "select * from Khoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqttenkhoa.Items.Add(ds.Tables[0].Rows[i]["TenKhoa"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void cboqttenkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboqttennganh.Items.Clear();
                cboqttennganh.Items.Add("--");
                cboqttennganh.SelectedItem = "--";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from Nganh,Khoa where Nganh.MaKhoa=Khoa.MaKhoa and Khoa.TenKhoa=N'" + cboqttenkhoa.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqttennganh.Items.Add(ds.Tables[0].Rows[i]["TenNganh"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void cboqttennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboqttenlop.Items.Clear();
                cboqttenlop.Items.Add("--");
                cboqttenlop.SelectedItem = "--";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from Lop,Nganh where Nganh.MaNganh=Lop.MaNganh and Nganh.TenNganh=N'" + cboqttennganh.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqttenlop.Items.Add(ds.Tables[0].Rows[i]["TenLop"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttksv_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttksv.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttksv.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaSinhVien as'Mã Sinh Viên', TenSV as'Tên Sinh Viên', QueQuan as'Quê Quán', NgaySinh as'Ngày Sinh', NoiSinh as'Nơi Sinh', GioiTinh as'Giới Tính', TenLop as'Tên Lớp', GhiChu as'Ghi Chú' FROM dbo.SinhVien WHERE MaSinhVien LIKE '%" + txtqttksv.Text.Trim() + "%' OR TenSV LIKE N'%" + txtqttksv.Text.Trim() + "%' OR TenLop LIKE '%" + txtqttksv.Text.Trim() + "%' OR NoiSinh LIKE '%" + txtqttksv.Text.Trim() + "%' OR QueQuan LIKE '%" + txtqttksv.Text.Trim() + "%' OR GhiChu LIKE '%" + txtqttksv.Text.Trim() + "%' ";
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
                        txtqttksv.Focus();

                        dgvqtsv.DataSource = ds.Tables[0];

                        txtqtmasv.Text = ds.Tables[0].Rows[0]["Mã Sinh Viên"].ToString();
                        txtqttensv.Text = ds.Tables[0].Rows[0]["Tên Sinh Viên"].ToString();
                        txtqtquequansv.Text = ds.Tables[0].Rows[0]["Quê Quán"].ToString();
                        dtpngaysinhsv.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["Ngày Sinh"]);
                        txtqtnoisinhsv.Text = ds.Tables[0].Rows[0]["Nơi Sinh"].ToString();
                        if (ds.Tables[0].Rows[0]["Giới Tính"].ToString() == "NAM")
                        {
                            rdoqtnam.Checked = true;
                            rdoqtnu.Checked = false;
                        }
                        else
                        {
                            rdoqtnam.Checked = false;
                            rdoqtnu.Checked = true;
                        }
                        cboqttenlop.SelectedValue = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                        txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();

                        // bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Sinh Viên"].ToString();
                        b = dss.Tables[0].Rows[0]["Quê Quán"].ToString();

                        c = dss.Tables[0].Rows[0]["Nơi Sinh"].ToString();
                        // bắt lỗi ghi sửa

                        d = dss.Tables[0].Rows[0]["Tên Lớp"].ToString();
                        f = dss.Tables[0].Rows[0]["Ghi Chú"].ToString();
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
                MessageBox.Show(ex.Message + "\nLỗi rồi! Liên hệ 098***** :<\nChúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
    }
}
