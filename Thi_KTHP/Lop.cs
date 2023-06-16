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
    public partial class frmqtlop : Form
    {
        public frmqtlop()
        {
            InitializeComponent();
            Loadcboboxnganh("SELECT * FROM Nganh", "MaNganh", "MaNganh");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
        public void Loadcboboxnganh(string query, string dis, string valu)
        {
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cboqtmanganh.DataSource = ds.Tables[0];
            cboqtmanganh.DisplayMember = dis;
            cboqtmanganh.ValueMember = valu;
        }
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemlop.Enabled = true;
                    btnqtsualop.Enabled = true;
                    btnqtxoalop.Enabled = true;
                    btnqtghilop.Enabled = false;
                    btnqthuylop.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttklop.Enabled = true;

                    dgvqtlop.Enabled = true;

                    txtqttenlop.Enabled = false;
                    cboqtmanganh.Enabled = false;
                    txtqtghichu.Enabled = false;
                    txtqttklop.Enabled = true;

                    

                    break;
                case "insert":
                    btnqtthemlop.Enabled = false;
                    btnqtsualop.Enabled = false;
                    btnqtxoalop.Enabled = false;
                    btnqtghilop.Enabled = true;
                    btnqthuylop.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttklop.Enabled = false;

                    dgvqtlop.Enabled = false;

                    txtqttenlop.Enabled = true;
                    cboqtmanganh.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttklop.Enabled = false;

                    txtqttenlop.Text = "";
                    txtqtghichu.Text = "";
                    txtqttklop.Text = "";
                    txtqttenlop.Focus();
                    break;
                case "edit":
                    btnqtthemlop.Enabled = false;
                    btnqtsualop.Enabled = false;
                    btnqtxoalop.Enabled = false;
                    btnqtghilop.Enabled = true;
                    btnqthuylop.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttklop.Enabled = false;


                    txtqttenlop.Enabled = false;
                    cboqtmanganh.Enabled = false;
                    txtqtghichu.Enabled = true;
                    txtqttklop.Enabled = false;

                    txtqttklop.Text = "";

                    cboqtmanganh.Focus();
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
                string query = "SELECT TenLop as'Tên Lớp',MaNganh as'Mã Ngành', GhiChu as'Ghi Chú' FROM Lop";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtlop.DataSource = ds.Tables[0];

                    txtqttenlop.Text = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                    cboqtmanganh.SelectedValue = ds.Tables[0].Rows[0]["Mã Ngành"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Mã Ngành"].ToString();
                    b = dss.Tables[0].Rows[0]["Ghi Chú"].ToString();
                }
                else
                {
                    dgvqtlop.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemlop_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsualop_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoalop_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.Lop WHERE TenLop='" + txtqttenlop.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttklop.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Vui lòng xóa dữ liệu Khóa Học này ở bảng Kế Hoạch Đào Tạo để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuylop_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqttenlop.Text = "";
                txtqtghichu.Text = "";
                txtqttklop.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghilop_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true;
                if (txtqttenlop.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttenlop, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }

                if (status == "insert" && check == true)
                {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO Lop (TenLop,MaNganh,GhiChu) VALUES (N'" + txtqttenlop.Text.Trim() + "','" + cboqtmanganh.SelectedValue.ToString() + "',N'" + txtqtghichu.Text.Trim() + "')";
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
                    if (txtqtghichu.Text.Equals(b))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        cboqtmanganh.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.Lop SET MaNganh='" + cboqtmanganh.SelectedValue.ToString() + "',GhiChu=N'" + txtqtghichu.Text.Trim() + "' WHERE TenLop=N'" + txtqttenlop.Text.Trim() + "'";
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
                MessageBox.Show(ex.Message);
            }
        }
        static string a = null;
        static string b = null;
        private void dgvqtlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtlop.Rows[e.RowIndex];
                txtqttenlop.Text = row.Cells["Tên Lớp"].Value.ToString();
                cboqtmanganh.SelectedValue = row.Cells["Mã Ngành"].Value.ToString();
                txtqtghichu.Text = row.Cells["Ghi Chú"].Value.ToString();

                a = row.Cells["Mã Ngành"].Value.ToString();
                b = row.Cells["Ghi Chú"].Value.ToString();
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
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Lớp");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttklop_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttklop.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttklop.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT TenLop as'Tên Lớp',MaNganh as'Mã Ngành', GhiChu as'Ghi Chú' FROM dbo.Lop WHERE TenLop LIKE '%" + txtqttklop.Text.Trim() + "%' OR MaNganh LIKE '%" + txtqttklop.Text.Trim() + "%' OR GhiChu LIKE '%" + txtqttklop.Text.Trim() + "%' ";
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
                        txtqttklop.Focus();

                        dgvqtlop.DataSource = ds.Tables[0];

                        txtqttenlop.Text = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                        cboqtmanganh.SelectedValue = ds.Tables[0].Rows[0]["Mã Ngành"].ToString();
                        txtqtghichu.Text = ds.Tables[0].Rows[0]["Ghi Chú"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Mã Ngành"].ToString();
                        b = dss.Tables[0].Rows[0]["Ghi Chú"].ToString();
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

