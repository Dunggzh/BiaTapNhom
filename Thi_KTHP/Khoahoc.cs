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
    public partial class frmqtkhoahoc : Form
    {
        public frmqtkhoahoc()
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
                    btnqtthemkhoahoc.Enabled = true;
                    btnqtsuakhoahoc.Enabled = true;
                    btnqtxoakhoahoc.Enabled = true;
                    btnqtghikhoahoc.Enabled = false;
                    btnqthuykhoahoc.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkkhoahoc.Enabled = true;

                    dgvqtkhoahoc.Enabled = true;

                    txtqtmakhoahoc.Enabled = false;
                    txtqttenkhoahoc.Enabled = false;
                    txtqtkyhoc.Enabled = false;
                    txtqttkkhoahoc.Enabled = true;
                    break;
                case "insert":
                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhoahoc.Enabled = false;

                    dgvqtkhoahoc.Enabled = false;

                    txtqtmakhoahoc.Enabled = true;
                    txtqttenkhoahoc.Enabled = true;
                    txtqtkyhoc.Enabled = true;
                    txtqttkkhoahoc.Enabled = false;

                    txtqtmakhoahoc.Text = "";
                    txtqttenkhoahoc.Text = "";
                    txtqtkyhoc.Text = "";
                    txtqttkkhoahoc.Text = "";


                    txtqtmakhoahoc.Focus();
                    break;
                case "edit":

                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhoahoc.Enabled = false;

                    txtqtmakhoahoc.Enabled = false;
                    txtqttenkhoahoc.Enabled = true;
                    txtqtkyhoc.Enabled = true;
                    txtqttkkhoahoc.Enabled= false;

                    txtqttkkhoahoc.Text = "";

                    txtqttenkhoahoc.Focus();
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
                string query = "SELECT MaKhoaHoc as'Mã Khóa Học',TenKhoaHoc as'Tên Khóa Học', KyHoc as'Kỳ Học' FROM KhoaHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoahoc.DataSource = ds.Tables[0];

                    txtqtmakhoahoc.Text = ds.Tables[0].Rows[0]["Mã Khóa Học"].ToString();
                    txtqttenkhoahoc.Text = ds.Tables[0].Rows[0]["Tên Khóa Học"].ToString();
                    txtqtkyhoc.Text = ds.Tables[0].Rows[0]["Kỳ Học"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Khóa Học"].ToString();
                    b = dss.Tables[0].Rows[0]["Kỳ Học"].ToString();
                }
                else
                {
                    dgvqtkhoahoc.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemkhoahoc_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuakhoahoc_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoakhoahoc_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.KhoaHoc WHERE MaKhoaHoc='" + txtqtmakhoahoc.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttkkhoahoc.Text = "";
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
                MessageBox.Show(ex.Message+"\n Vui lòng xóa dữ liệu Khóa Học này ở bảng Kế Hoạch Đào Tạo để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuykhoahoc_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmakhoahoc.Text = "";
                txtqttenkhoahoc.Text = "";
                txtqtkyhoc.Text = "";
                txtqttkkhoahoc.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtghikhoahoc_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true;
                if (txtqtmakhoahoc.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmakhoahoc, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttenkhoahoc.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttenkhoahoc, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtkyhoc.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtkyhoc, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }

                if (status == "insert" && check == true)
                {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO KhoaHoc (MaKhoaHoc,TenKhoaHoc,KyHoc) VALUES ('" + txtqtmakhoahoc.Text.Trim() + "','" + txtqttenkhoahoc.Text.Trim()+ "','" + txtqtkyhoc.Text.Trim()+"')";
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
                    if (txtqttenkhoahoc.Text.Equals(a) && txtqtkyhoc.Text.Equals(b))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttenkhoahoc.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.KhoaHoc SET TenKhoaHoc=N'" + txtqttenkhoahoc.Text.Trim() + "',KyHoc='" + txtqtkyhoc.Text.Trim() + "' WHERE MaKhoaHoc='" + txtqtmakhoahoc.Text.Trim() + "'";
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
                MessageBox.Show(ex.Message+"\n Mã Khoá Học đã tồn tại!");
                txtqtmakhoahoc.Focus();
            }
        }
        static string a = null;
        static string b = null;
        private void dgvqtkhoahoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtkhoahoc.Rows[e.RowIndex];
                txtqtmakhoahoc.Text = row.Cells["Mã Khóa Học"].Value.ToString();
                txtqttenkhoahoc.Text = row.Cells["Tên Khóa Học"].Value.ToString();
                txtqtkyhoc.Text = row.Cells["Kỳ Học"].Value.ToString();

                a = row.Cells["Tên Khóa Học"].Value.ToString();
                b = row.Cells["Kỳ Học"].Value.ToString();
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
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Khóa Học");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkkhoahoc_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkkhoahoc.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkkhoahoc.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaKhoaHoc as'Mã Khóa Học',TenKhoaHoc as'Tên Khóa Học', KyHoc as'Kỳ Học' FROM dbo.KhoaHoc WHERE MaKhoaHoc LIKE '%" + txtqttkkhoahoc.Text.Trim() + "%' OR KyHoc LIKE '%" + txtqttkkhoahoc.Text.Trim() + "%' OR TenKhoaHoc LIKE '%" + txtqttkkhoahoc.Text.Trim() + "%' ";
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
                        txtqttkkhoahoc.Focus();

                        dgvqtkhoahoc.DataSource = ds.Tables[0];

                        txtqtmakhoahoc.Text = ds.Tables[0].Rows[0]["Mã Khóa Học"].ToString();
                        txtqttenkhoahoc.Text = ds.Tables[0].Rows[0]["Tên Khóa Học"].ToString();
                        txtqtkyhoc.Text = ds.Tables[0].Rows[0]["Kỳ Học"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Khóa Học"].ToString();
                        b = dss.Tables[0].Rows[0]["Kỳ Học"].ToString();
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
                 MessageBox.Show(ex.Message+ "\nLỗi rồi! Liên hệ 098***** :<\nChúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
    }
}
