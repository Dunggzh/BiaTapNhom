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
using System.Xml.Linq;

namespace Thi_KTHP
{
    public partial class frmqtkhoa : Form
    {
        public frmqtkhoa()
        {
            InitializeComponent();
            Setstatus("reset");
            BindingData();
        }

        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemkhoa.Enabled = true;
                    btnqtsuakhoa.Enabled = true;
                    btnqtxoakhoa.Enabled = true;
                    btnqtghikhoa.Enabled = false;
                    btnqthuykhoa.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkkhoa.Enabled = true;

                    dgvqtkhoa.Enabled = true;

                    txtqtmakhoa.Enabled = false;
                    txtqttenkhoa.Enabled = false;
                    txtqtsdt.Enabled = false;
                    txtqtghichu.Enabled = false;
                    txtqttkkhoa.Enabled = true;
                    break;
                case "insert":
                    btnqtthemkhoa.Enabled = false;
                    btnqtsuakhoa.Enabled = false;
                    btnqtxoakhoa.Enabled = false;
                    btnqtghikhoa.Enabled = true;
                    btnqthuykhoa.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhoa.Enabled = false;

                    dgvqtkhoa.Enabled = false;

                    txtqtmakhoa.Enabled = true;
                    txtqttenkhoa.Enabled = true;
                    txtqtsdt.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttkkhoa.Enabled = false;

                    txtqtmakhoa.Text = "";
                    txtqttenkhoa.Text = "";
                    txtqtsdt.Text = "";
                    txtqtghichu.Text = "";
                    txtqttkkhoa.Text = "";

                    txtqtmakhoa.Focus();
                    break;
                case "edit":
                    btnqtthemkhoa.Enabled = false;
                    btnqtsuakhoa.Enabled = false;
                    btnqtxoakhoa.Enabled = false;
                    btnqtghikhoa.Enabled = true;
                    btnqthuykhoa.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhoa.Enabled = false;

                    txtqtmakhoa.Enabled = false;
                    txtqttenkhoa.Enabled = true;
                    txtqtsdt.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttkkhoa.Enabled = false;

                    txtqttenkhoa.Focus();
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
                string query = "SELECT MaKhoa as'Mã Khoa',TenKhoa as'Tên Khoa', SoDienThoai as'Số Điện Thoại',GhiChu as'Ghi Chú' FROM Khoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                //export excell
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoa.DataSource = ds.Tables[0];

                    txtqtmakhoa.Text = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();
                    txtqttenkhoa.Text = ds.Tables[0].Rows[0]["Tên Khoa"].ToString();
                    txtqtsdt.Text = ds.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Khoa"].ToString();
                    b = dss.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                    c = dss.Tables[0].Rows[0]["Ghi Chú"].ToString();
                }
                else
                {
                    dgvqtkhoa.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemkhoa_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuakhoa_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoakhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE dbo.Khoa WHERE MaKhoa='" + txtqtmakhoa.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
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
                MessageBox.Show(ex.Message+"\n Vui lòng xóa dữ liệu Khoa này ở bảng Ngành để tránh dư thừa dữ liệu!");
            }
        }
        private void btnqthuykhoa_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmakhoa.Text = "";
                txtqttenkhoa.Text = "";
                txtqtsdt.Text = "";
                txtqtghichu.Text = "";
                txtqttkkhoa.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\nLỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtghikhoa_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check= true;int output;
                if (txtqtmakhoa.Text == "")
                {
                    check= false;
                    errorbatloi.SetError(txtqtmakhoa, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttenkhoa.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttenkhoa, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtsdt.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtsdt, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if(int.TryParse(txtqtsdt.Text,out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtsdt, "Sai Định Dạng");
                    }
                }   

                if (status == "insert" && check== true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO Khoa (MaKhoa,TenKhoa,SoDienThoai,GhiChu) VALUES ('" + txtqtmakhoa.Text.Trim() + "',N'" + txtqttenkhoa.Text.Trim() + "','" + txtqtsdt.Text.Trim() + "',N'" + txtqtghichu.Text.Trim() + "')";
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
                    if (txtqttenkhoa.Text.Equals(a) && txtqtsdt.Text.Equals(b) && txtqtghichu.Text.Equals(c))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttenkhoa.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.Khoa SET TenKhoa=N'" + txtqttenkhoa.Text.Trim() + "',SoDienThoai='" + txtqtsdt.Text.Trim() + "',GhiChu=N'" + txtqtghichu.Text.Trim() + "' WHERE MaKhoa='" + txtqtmakhoa.Text.Trim() + "'";
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
                MessageBox.Show(ex.Message+"\n Mã Khoa đã tồn tại!");
                txtqtmakhoa.Focus();
            }
        }

        static string a = null;
        static string b = null;
        static string c = null;
        private void dgvqtkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtkhoa.Rows[e.RowIndex];
                txtqtmakhoa.Text = row.Cells["Mã Khoa"].Value.ToString();
                txtqttenkhoa.Text = row.Cells["Tên Khoa"].Value.ToString();
                txtqtsdt.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                txtqtghichu.Text = row.Cells["Ghi Chú"].Value.ToString();

                a = row.Cells["Tên Khoa"].Value.ToString();
                b = row.Cells["Số Điện Thoại"].Value.ToString();
                c = row.Cells["Ghi Chú"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Arranged");
            }
        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            try
            {
                Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Khoa");
                MessageBox.Show("Excel created D: \tExceldata.xlsx","Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkkhoa_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkkhoa.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkkhoa.Focus();
                }
                if(check==true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaKhoa as'Mã Khoa',TenKhoa as'Tên Khoa', SoDienThoai as'Số Điện Thoại',GhiChu as'Ghi Chú' FROM dbo.Khoa WHERE MaKhoa LIKE '%" + txtqttkkhoa.Text.Trim() + "%' OR SoDienThoai LIKE '%" + Convert.ToString(txtqttkkhoa.Text) + "%' OR TenKhoa LIKE N'%" + txtqttkkhoa.Text.Trim() + "%' OR GhiChu LIKE N'%" + txtqttkkhoa.Text.Trim() + "%'  ";
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
                        txtqttkkhoa.Focus();

                        dgvqtkhoa.DataSource = ds.Tables[0];

                        txtqtmakhoa.Text = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();
                        txtqttenkhoa.Text = ds.Tables[0].Rows[0]["Tên Khoa"].ToString();
                        txtqtsdt.Text = ds.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                        txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();
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
                MessageBox.Show(ex.Message+"\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
    }
}
