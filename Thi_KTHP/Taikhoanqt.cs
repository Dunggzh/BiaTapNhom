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
    public partial class frmqttaikhoan : Form
    {
        private string username;
        private string pass;
        public frmqttaikhoan()
        {
            InitializeComponent();

        }
        public frmqttaikhoan(string username, string pass)
        {
            InitializeComponent();
            Setstatus("reset");
            BindingData();
            this.username = username;
            this.pass = pass;
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
                    btnqtthemtk.Enabled = true;
                    btnqtsuatk.Enabled = true;
                    btnqtxoatk.Enabled = true;
                    btnqtghitk.Enabled = false;
                    btnqthuytk.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttktaikhoan.Enabled = true;

                    dgvqttaikhoan.Enabled = true;


                    txtqtusername.Enabled = false;
                    txtqtpass.Enabled = false;
                    txtqtquyen.Enabled = false;
                    txtqttktaikhoan.Enabled = true;
                    break;
                case "insert":
                    btnqtthemtk.Enabled = false;
                    btnqtsuatk.Enabled = false;
                    btnqtxoatk.Enabled = false;
                    btnqtghitk.Enabled = true;
                    btnqthuytk.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttktaikhoan.Enabled = false;

                    dgvqttaikhoan.Enabled = false;


                    txtqtusername.Enabled = true;
                    txtqtpass.Enabled = true;
                    txtqtquyen.Enabled = true;
                    txtqttktaikhoan.Enabled = false;

                    txtqtusername.Text = "";
                    txtqtpass.Text = "";
                    txtqtquyen.Text = "";
                    txtqttktaikhoan.Text = "";

                    txtqtusername.Focus();
                    break;
                case "edit":


                    btnqtthemtk.Enabled = false;
                    btnqtsuatk.Enabled = false;
                    btnqtxoatk.Enabled = false;
                    btnqtghitk.Enabled = true;
                    btnqthuytk.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttktaikhoan.Enabled = false;

                    txtqtusername.Enabled = false;
                    txtqtpass.Enabled = true;
                    txtqtquyen.Enabled = true;
                    txtqttktaikhoan.Enabled = false;

                    txtqttktaikhoan.Text = "";

                    txtqtpass.Focus();
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
                string query = "SELECT UserName as'Username',pass as'Password',Quyen as'Quyền' FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqttaikhoan.DataSource = ds.Tables[0];

                    txtqtusername.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                    txtqtpass.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    txtqtquyen.Text = ds.Tables[0].Rows[0]["Quyền"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Password"].ToString();
                    b = dss.Tables[0].Rows[0]["Quyền"].ToString();
                }
                else
                {
                    dgvqttaikhoan.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemtk_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuatk_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoatk_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.TaiKhoan WHERE UserName='" + txtqtusername.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttktaikhoan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Vui lòng xóa dữ liệu Ngành này ở bảng Lớp để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuytk_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtusername.Text = "";
                txtqtpass.Text = "";
                txtqtquyen.Text = "";
                txtqttktaikhoan.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghitk_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true; int output;
                if (txtqtusername.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtusername, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtpass.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtpass, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtquyen.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtquyen, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (int.TryParse(txtqtquyen.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtquyen, "Sai Định Dạng");
                    }
                }

                if (status == "insert" && check==true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO TaiKhoan (UserName,pass,Quyen) VALUES ('" + txtqtusername.Text.Trim() + "','" + txtqtpass.Text.Trim() + "','" + txtqtquyen.Text.Trim() + "')";
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

                    if (txtqtpass.Text.Equals(a) && txtqtquyen.Text.Equals(b))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqtpass.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.TaiKhoan SET pass='" + txtqtpass.Text.Trim() + "',Quyen='" + txtqtquyen.Text.Trim() + "' WHERE UserName='" + txtqtusername.Text.Trim() + "'";
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
                    }

                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Mã Ngành đã tồn tại!");
                txtqtusername.Focus();
            }
        }
        static string a = null;
        static string b = null;
        private void dgvqttaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var row = (DataGridViewRow)dgvqttaikhoan.Rows[e.RowIndex];
                txtqtusername.Text = row.Cells["Username"].Value.ToString();
                txtqtpass.Text = row.Cells["Password"].Value.ToString();
                txtqtquyen.Text = row.Cells["Quyền"].Value.ToString();

                a = row.Cells["Password"].Value.ToString();
                b = row.Cells["Quyền"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t Sắp Xếp");
            }
        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            try
            {
                Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Tài Khoản");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttktaikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttktaikhoan.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttktaikhoan.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT   UserName as'Username',pass as'Password',Quyen as'Quyền' FROM dbo.TaiKhoan WHERE UserName LIKE '%" + txtqttktaikhoan.Text.Trim() + "%' OR pass LIKE '%" + txtqttktaikhoan.Text.Trim() + "%' OR Quyen LIKE '%" + txtqttktaikhoan.Text.Trim() + "%' ";
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
                        txtqttktaikhoan.Focus();

                        dgvqttaikhoan.DataSource = ds.Tables[0];

                        txtqtusername.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                        txtqtpass.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                        txtqtquyen.Text = ds.Tables[0].Rows[0]["Quyền"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Password"].ToString();
                        b = dss.Tables[0].Rows[0]["Quyền"].ToString();
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
