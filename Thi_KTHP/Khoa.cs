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
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";
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
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM Khoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                //export excell
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoa.DataSource = ds.Tables[0];

                    txtqtmakhoa.Text = ds.Tables[0].Rows[0]["MaKhoa"].ToString();
                    txtqttenkhoa.Text = ds.Tables[0].Rows[0]["TenKhoa"].ToString();
                    txtqtsdt.Text = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["TenKhoa"].ToString();
                    b = dss.Tables[0].Rows[0]["SoDienThoai"].ToString();
                    c = dss.Tables[0].Rows[0]["GhiChu"].ToString();
                }
                else
                {
                    dgvqtkhoa.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if(MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!","Lưu Ý",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
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
                MessageBox.Show("Vui Lòng Xóa Khoa Này Ở Bảng Ngành");
            }
        }

        private void btnqthuykhoa_Click(object sender, EventArgs e)
        {
            txtqtmakhoa.Text = "";
            txtqttenkhoa.Text = "";
            txtqtsdt.Text = "";
            txtqtghichu.Text = "";
            txtqttkkhoa.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghikhoa_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (status == "insert")
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
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
                if (status == "edit")
                {
                    if (txtqttenkhoa.Text.Equals(a) && txtqtsdt.Text.Equals(b) && txtqtghichu.Text.Equals(c))
                    {
                        MessageBox.Show("Bạn Chưa Update");
                        txtqttenkhoa.Focus();
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(connectionsString);
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
                MessageBox.Show(ex.Message);
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
                txtqtmakhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txtqttenkhoa.Text = row.Cells["TenKhoa"].Value.ToString();
                txtqtsdt.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();

                a = row.Cells["TenKhoa"].Value.ToString();
                b = row.Cells["SoDienThoai"].Value.ToString();
                c = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arranged");
            }

        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
            obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Khoa");
            MessageBox.Show("Excel created D:\tExceldata.xlsx");
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
                    SqlConnection conn = new SqlConnection(connectionsString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT * FROM dbo.Khoa WHERE MaKhoa LIKE '%" + txtqttkkhoa.Text.Trim() + "%' OR SoDienThoai LIKE '%" + Convert.ToString(txtqttkkhoa.Text) + "%' OR TenKhoa LIKE N'%" + txtqttkkhoa.Text.Trim() + "%' OR GhiChu LIKE '%" + txtqttkkhoa.Text.Trim() + "%'  ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    dss = ds;
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        status = "reset";
                        Setstatus(status);
                        txtqttkkhoa.Focus();

                        dgvqtkhoa.DataSource = ds.Tables[0];

                        txtqtmakhoa.Text = ds.Tables[0].Rows[0]["MaKhoa"].ToString();
                        txtqttenkhoa.Text = ds.Tables[0].Rows[0]["TenKhoa"].ToString();
                        txtqtsdt.Text = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
                        txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
