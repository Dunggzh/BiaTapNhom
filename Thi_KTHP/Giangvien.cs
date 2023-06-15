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
    public partial class frmqtgv : Form
    {
        public frmqtgv()
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


                    btnqtthemgv.Enabled = true;
                    btnqtsuagv.Enabled = true;
                    btnqtxoagv.Enabled = true;
                    btnqtghigv.Enabled = false;
                    btnqthuygv.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkgv.Enabled = true;

                    dgvqtgv.Enabled = true;


                    txtqtmagv.Enabled = false;
                    txtqttengv.Enabled = false;
                    txtqtsodtgv.Enabled = false;
                    cboqttrinhdogv.Enabled = false;
                    cboqtmakhoa.Enabled = false;
                    txtqttengv.Enabled = false;
                    txtqttkgv.Enabled = true;

                    break;
                case "insert":
                    btnqtthemgv.Enabled = false;
                    btnqtsuagv.Enabled = false;
                    btnqtxoagv.Enabled = false;
                    btnqtghigv.Enabled = true;
                    btnqthuygv.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkgv.Enabled = false;

                    dgvqtgv.Enabled = false;

                    txtqtmagv.Enabled = true;
                    txtqttengv.Enabled = true;
                    txtqtsodtgv.Enabled = true;
                    cboqttrinhdogv.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttengv.Enabled = true;
                    txtqttkgv.Enabled = false;


                    txtqtmagv.Text = "";
                    txtqttengv.Text = "";
                    txtqtsodtgv.Text = "";
                    txtqttkgv.Text = "";

                    txtqtmagv.Focus();
                    break;
                case "edit":

                    btnqtthemgv.Enabled = false;
                    btnqtsuagv.Enabled = false;
                    btnqtxoagv.Enabled = false;
                    btnqtghigv.Enabled = true;
                    btnqthuygv.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkgv.Enabled = false;

                    txtqtmagv.Enabled = false;
                    txtqttengv.Enabled = true;
                    txtqtsodtgv.Enabled = true;
                    cboqttrinhdogv.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttengv.Enabled = true;
                    txtqttkgv.Enabled = false;

                    txtqttkgv.Text = "";

                    txtqttengv.Focus();
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
                string query = "SELECT MaGV as'Mã Giảng Viên', TenGV as'Tên Giảng Viên', TrinhDo as'Trình Độ', SoDT as'Số Điện Thoại', MaKhoa as'Mã Khoa' FROM GiangVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtgv.DataSource = ds.Tables[0];

                    txtqtmagv.Text = ds.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                    txtqttengv.Text = ds.Tables[0].Rows[0]["Tên Giảng Viên"].ToString();
                    if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Thạc sĩ")
                    {
                        cboqttrinhdogv.Text = "Thạc sĩ";
                    }
                    else if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Tiến sĩ")
                    {
                        cboqttrinhdogv.Text = "Tiến sĩ";
                    }
                    else if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Giáo sư")
                    {
                        cboqttrinhdogv.Text = "Giáo sư";
                    }
                    else
                    {
                        cboqttrinhdogv.Text = "Khác";
                    }
                    txtqtsodtgv.Text = ds.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                    cboqtmakhoa.Text = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Giảng Viên"].ToString();
                    b = dss.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                    c = dss.Tables[0].Rows[0]["Trình Độ"].ToString();
                    d = dss.Tables[0].Rows[0]["Mã Khoa"].ToString();
                }
                else
                {
                    dgvqtgv.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemgv_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuagv_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoagv_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.GiangVien WHERE MaGV='" + txtqtmagv.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttkgv.Text = "";
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

        private void btnqthuygv_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmagv.Text = "";
                txtqttengv.Text = "";
                txtqtsodtgv.Text = "";
                txtqttkgv.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghigv_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true; int output;
                if (txtqtmagv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmagv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttengv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttengv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtsodtgv.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtsodtgv, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (int.TryParse(txtqtsodtgv.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtsodtgv, "Sai Định Dạng");
                    }
                }

                string trinhdo = "";
                if (cboqttrinhdogv.SelectedItem.Equals("Thạc sĩ"))
                {
                    trinhdo = "Thạc sĩ";
                }
                else if (cboqttrinhdogv.SelectedItem.Equals("Tiến sĩ"))
                {
                    trinhdo = "Tiến sĩ";
                }
                else if(cboqttrinhdogv.SelectedItem.Equals("Giáo sư"))
                {
                    trinhdo = "Giáo sư";
                }
                else
                {
                    trinhdo = "Khác";
                }

                if (status == "insert"&&check==true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO GiangVien (MaGV,TenGV,SoDT,TrinhDo,MaKhoa) VALUES ('" + txtqtmagv.Text.Trim() + "',N'" + txtqttengv.Text.Trim() + "','" + txtqtsodtgv.Text.Trim() + "',N'" + trinhdo + "','" + cboqtmakhoa.SelectedItem.ToString() + "')";
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

                    if (txtqttengv.Text.Equals(a) && cboqttrinhdogv.SelectedItem.Equals(b) && txtqtsodtgv.Text.Equals(c) && cboqtmakhoa.SelectedItem.Equals(d))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttengv .Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.GiangVien SET TenGV=N'" + txtqttengv.Text.Trim() + "',SoDT='" + txtqtsodtgv.Text.Trim() + "',TrinhDo=N'" + trinhdo + "', MaKhoa='" + cboqtmakhoa.SelectedItem.ToString() + "'  WHERE MaGV='" + txtqtmagv.Text.Trim() + "'";
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
        static string d = null;
        private void dgvqtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var row = (DataGridViewRow)dgvqtgv.Rows[e.RowIndex];
                txtqtmagv.Text = row.Cells["Mã Giảng Viên"].Value.ToString();
                txtqttengv.Text = row.Cells["Tên Giảng Viên"].Value.ToString();

                if (row.Cells["Trình Độ"].Value.ToString() == "Thạc sĩ")
                {
                    cboqttrinhdogv.Text = "Thạc sĩ";
                }
                else if (row.Cells["Trình Độ"].Value.ToString() == "Tiến sĩ")
                {
                    cboqttrinhdogv.Text = "Tiến sĩ";
                }
                else if (row.Cells["Trình Độ"].Value.ToString() == "Giáo sư")
                {
                    cboqttrinhdogv.Text = "Giáo sư";
                }
                else
                {
                    cboqttrinhdogv.Text = "Khác";
                }
                txtqtsodtgv.Text = row.Cells["Số Điện Thoại"].Value.ToString();
                cboqtmakhoa.Text = row.Cells["Mã Khoa"].Value.ToString();

                a = row.Cells["Tên Giảng Viên"].Value.ToString();
                b = row.Cells["Số Điện Thoại"].Value.ToString();
                c = row.Cells["Trình Độ"].Value.ToString();
                d = row.Cells["Mã Khoa"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t Sắp Xếp");
            }
            
        }

        private void frmqtgv_Load(object sender, EventArgs e)
        {
            try
            {
                //cboqtmakhoa.SelectedItem = "--";

                string query = "select * from Khoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmakhoa.Items.Add(ds.Tables[0].Rows[i]["MaKhoa"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboqtmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboqtmakhoa.SelectedItem.ToString() != "")
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "select * from Khoa where MaKhoa='" + cboqtmakhoa.SelectedItem.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        txtqttenkhoa.Text = ds.Tables[0].Rows[0]["TenKhoa"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtxuatexcell_Click(object sender, EventArgs e)
        {
            try
            {
                Thi_KTHP.Excell obj = new Thi_KTHP.Excell();
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Giảng Viên");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkgv_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkgv.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkgv.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaGV as'Mã Giảng Viên', TenGV as'Tên Giảng Viên', TrinhDo as'Trình Độ', SoDT as'Số Điện Thoại', MaKhoa as'Mã Khoa' FROM dbo.GiangVien WHERE MaGV LIKE '%" + txtqttkgv.Text.Trim() + "%' OR TenGV LIKE N'%" + txtqttkgv.Text.Trim() + "%' OR SoDT LIKE '%" + txtqttkgv.Text.Trim() + "%' OR TrinhDo LIKE N'%" + txtqttkgv.Text.Trim() + "%' OR MaKhoa LIKE N'%" + txtqttkgv.Text.Trim() + "%' ";
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
                        txtqttkgv.Focus();

                        dgvqtgv.DataSource = ds.Tables[0];

                        txtqtmagv.Text = ds.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                        txtqttengv.Text = ds.Tables[0].Rows[0]["Tên Giảng Viên"].ToString();
                        if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Thạc sĩ")
                        {
                            cboqttrinhdogv.Text = "Thạc sĩ";
                        }
                        else if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Tiến sĩ")
                        {
                            cboqttrinhdogv.Text = "Tiến sĩ";
                        }
                        else if (ds.Tables[0].Rows[0]["Trình Độ"].ToString() == "Giáo sư")
                        {
                            cboqttrinhdogv.Text = "Giáo sư";
                        }
                        else
                        {
                            cboqttrinhdogv.Text = "Khác";
                        }
                        txtqtsodtgv.Text = ds.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                        cboqtmakhoa.Text = ds.Tables[0].Rows[0]["Mã Khoa"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Giảng Viên"].ToString();
                        b = dss.Tables[0].Rows[0]["Số Điện Thoại"].ToString();
                        c = dss.Tables[0].Rows[0]["Trình Độ"].ToString();
                        d = dss.Tables[0].Rows[0]["Mã Khoa"].ToString();
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
