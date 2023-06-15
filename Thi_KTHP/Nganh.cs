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
    public partial class frmqtnganh : Form
    {
        public frmqtnganh()
        {
            InitializeComponent();
            Loadcboboxkhoa("SELECT * FROM Khoa", "MaKhoa", "MaKhoa");
            Setstatus("reset");
            BindingData();
        }
        public void Loadcboboxkhoa(string query, string dis, string valu)
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
            cboqtmakhoa.DataSource = ds.Tables[0];
            cboqtmakhoa.DisplayMember = dis;
            cboqtmakhoa.ValueMember = valu;
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
                    btnqtthemnganh.Enabled = true;
                    btnqtsuanganh.Enabled = true;
                    btnqtxoanganh.Enabled = true;
                    btnqtghinganh.Enabled = false;
                    btnqthuynganh.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttknganh.Enabled = true;

                    dgvqtnganh.Enabled = true;


                    txtqtmanganh.Enabled = false;
                    txtqttennganh.Enabled = false;
                    cboqtmakhoa.Enabled = false;
                    txtqttknganh.Enabled = true;
                    break;
                case "insert":
                    btnqtthemnganh.Enabled = false;
                    btnqtsuanganh.Enabled = false;
                    btnqtxoanganh.Enabled = false;
                    btnqtghinganh.Enabled = true;
                    btnqthuynganh.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttknganh.Enabled = false;

                    dgvqtnganh.Enabled = false;


                    txtqtmanganh.Enabled = true;
                    txtqttennganh.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttknganh.Enabled = false;

                    txtqtmanganh.Text = "";
                    txtqttennganh.Text = "";
                    txtqttknganh.Text = "";

                    txtqtmanganh.Focus();
                    break;
                case "edit":
                    btnqtthemnganh.Enabled = false;
                    btnqtsuanganh.Enabled = false;
                    btnqtxoanganh.Enabled = false;
                    btnqtghinganh.Enabled = true;
                    btnqthuynganh.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttknganh.Enabled = false;

                    txtqtmanganh.Enabled = false;
                    txtqttennganh.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttknganh.Enabled = false;

                    txtqttknganh.Text = "";

                    txtqttennganh.Focus();
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
                string query = "SELECT MaNganh  as'Mã Ngành', TenNganh as 'Tên Ngành', MaKhoa as 'Mã Khoa' FROM Nganh";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtnganh.DataSource = ds.Tables[0];

                    txtqtmanganh.Text = ds.Tables[0].Rows[0]["Mã Ngành"].ToString();
                    txtqttennganh.Text = ds.Tables[0].Rows[0]["Tên Ngành"].ToString();
                    cboqtmakhoa.SelectedValue = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Ngành"].ToString();
                    b = dss.Tables[0].Rows[0]["Mã Khoa"].ToString();

                }
                else
                {
                    dgvqtnganh.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemnganh_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuanganh_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoanganh_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.Nganh WHERE MaNganh='" + txtqtmanganh.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttknganh.Text = "";
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

        private void btnqthuynganh_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmanganh.Text = "";
                txtqttennganh.Text = "";
                txtqttknganh.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtghinganh_Click(object sender, EventArgs e)
        {

            try
            {
                errorbatloi.Clear();
                bool check = true;
                if (txtqtmanganh.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmanganh, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttennganh.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttennganh, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }

                if (status == "insert" && check== true)
                {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO Nganh (MaNganh,TenNganh,MaKhoa) VALUES ('" + txtqtmanganh.Text.Trim() + "',N'" + txtqttennganh.Text.Trim() + "','" + cboqtmakhoa.SelectedValue.ToString() + "')";
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
                    if (txtqttennganh.Text.Equals(a) && cboqtmakhoa.Text.Equals(b))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttennganh.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.Nganh SET TenNganh=N'" + txtqttennganh.Text.Trim() + "',Makhoa='" + cboqtmakhoa.SelectedValue.ToString() + "' WHERE MaNganh='" + txtqtmanganh.Text.Trim() + "'";
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
                txtqtmanganh.Focus();
            }
        }
        static string a = null;
        static string b = null;
        private void dgvqtnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtnganh.Rows[e.RowIndex];
                txtqtmanganh.Text = row.Cells["Mã ngành"].Value.ToString();
                txtqttennganh.Text = row.Cells["Tên ngành"].Value.ToString();
                cboqtmakhoa.SelectedValue = row.Cells["Mã khoa"].Value.ToString();

                a = row.Cells["Tên Ngành"].Value.ToString();
                b = row.Cells["Mã Khoa"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n\t Sắp Xếp");
            }

        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            try
            {
                Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Ngành");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttknganh_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttknganh.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttknganh.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaNganh  as'Mã Ngành', TenNganh as 'Tên Ngành', MaKhoa as 'Mã Khoa' FROM dbo.Nganh WHERE MaNganh LIKE '%" + txtqttknganh.Text.Trim() + "%' OR TenNganh LIKE '%" + txtqttknganh.Text.Trim() + "%' OR MaKhoa LIKE '%" + txtqttknganh.Text.Trim() + "%' ";
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
                        txtqttknganh.Focus();

                        dgvqtnganh.DataSource = ds.Tables[0];

                        txtqtmanganh.Text = ds.Tables[0].Rows[0]["Mã Ngành"].ToString();
                        txtqttennganh.Text = ds.Tables[0].Rows[0]["Tên Ngành"].ToString();
                        cboqtmakhoa.SelectedValue = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Ngành"].ToString();
                        b = dss.Tables[0].Rows[0]["Mã Khoa"].ToString();
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
