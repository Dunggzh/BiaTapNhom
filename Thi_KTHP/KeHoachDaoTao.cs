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
    public partial class frmqtkhdt : Form
    {
        public frmqtkhdt()
        {
            InitializeComponent();
            Loadcboboxkhoa("SELECT * FROM KhoaHoc", "MaKhoaHoc", "MaKhoaHoc");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
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
            cboqtmakhoahoc.DataSource = ds.Tables[0];
            cboqtmakhoahoc.DisplayMember = dis;
            cboqtmakhoahoc.ValueMember = valu;
        }
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemkhdt.Enabled = true;
                    btnqtsuakhdt.Enabled = true;
                    btnqtxoakhdt.Enabled = true;
                    btnqtghikhdt.Enabled = false;
                    btnqthuykhdt.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkkhdt.Enabled = true;

                    dgvqtkhdt.Enabled = true;

                    cboqttenkhoa.Enabled = false;
                    cboqttennganh.Enabled = false;
                    cboqttenlop.Enabled = false;
                    
                    cboqtmakhoahoc.Enabled = false;
                    txtqtmakhdt.Enabled = false;
                    txtqttkkhdt.Enabled = true;
                    break;
                case "insert":
                    btnqtthemkhdt.Enabled = false;
                    btnqtsuakhdt.Enabled = false;
                    btnqtxoakhdt.Enabled = false;
                    btnqtghikhdt.Enabled = true;
                    btnqthuykhdt.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhdt.Enabled = false;

                    dgvqtkhdt.Enabled = false;

                    cboqttenkhoa.Enabled = true;
                    cboqttennganh.Enabled = true;
                    cboqttenlop.Enabled = true;
                
                    cboqtmakhoahoc.Enabled = true;
                    txtqtmakhdt.Enabled = true;
                    txtqttkkhdt.Enabled = false;

                    txtqtmakhdt.Text = "";
                    txtqttkkhdt.Text = "";

                    txtqtmakhdt.Focus();
                    break;
                case "edit":
                    btnqtthemkhdt.Enabled = false;
                    btnqtsuakhdt.Enabled = false;
                    btnqtxoakhdt.Enabled = false;
                    btnqtghikhdt.Enabled = true;
                    btnqthuykhdt.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkkhdt.Enabled = false;

                    txtqtmakhdt.Enabled = false;
                    cboqttenkhoa.Enabled = true;
                    cboqttennganh.Enabled = true;
                    cboqttenlop.Enabled = true;
                    
                    cboqtmakhoahoc.Enabled = true;
                    txtqttkkhdt.Enabled = false;

                    txtqttkkhdt.Text = "";

                    cboqttenkhoa.Focus();
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
                string query = "SELECT MaKHDT as'Mã Kế Hoạch Đào Tạo', TenLop as'Tên Lớp', MaKhoaHoc as'Mã Khóa Học' FROM KeHoachDaoTao";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                //export excell
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhdt.DataSource = ds.Tables[0];

                    txtqtmakhdt.Text = ds.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();
                    cboqttenlop.Text = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                    cboqtmakhoahoc.SelectedValue = ds.Tables[0].Rows[0]["Mã Khóa Học"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Lớp"].ToString();
                    b = dss.Tables[0].Rows[0]["Mã Khóa Học"].ToString();
                }
                else
                {
                    dgvqtkhdt.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
        private void btnqtthemkhdt_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuakhdt_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoakhdt_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.KeHoachDaoTao WHERE MaKHDT='" + txtqtmakhdt.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttkkhdt.Text = "";
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
                MessageBox.Show(ex.Message + "\n Vui lòng xóa dữ liệu Khoa này ở bảng Ngành để tránh dư thừa dữ liệu!");
            }
        }

        private void btnqthuykhdt_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmakhdt.Text = "";
                txtqttkkhdt.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }

            
        }

        private void btnqtghikhdt_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true;
                if (txtqtmakhdt.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmakhdt, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }

                if (status == "insert" &&check==true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO KeHoachDaoTao (MaKHDT,TenLop,MaKhoaHoc) VALUES ('" + txtqtmakhdt.Text.Trim() + "',N'" + cboqttenlop.SelectedItem.ToString() + "','" + cboqtmakhoahoc.SelectedValue.ToString() + "')";
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
                    if (cboqttenlop.Text.Equals(a) && cboqtmakhoahoc.Text.Equals(b))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        cboqttenkhoa.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.KeHoachDaoTao SET TenLop=N'" + cboqttenlop.SelectedItem.ToString() + "',MaKhoaHoc='" + cboqtmakhoahoc.SelectedValue.ToString() + "' WHERE MaKHDT='" + txtqtmakhdt.Text.Trim() + "'";
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
                MessageBox.Show(ex.Message + "\n Mã KHDT đã tồn tại!");
                txtqtmakhdt.Focus();
            }
        }
        static string a = null;
        static string b = null;
        private void dgvqtkhdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var row = (DataGridViewRow)dgvqtkhdt.Rows[e.RowIndex];
                txtqtmakhdt.Text = row.Cells["Mã Kế Hoạch Đào Tạo"].Value.ToString();
                cboqttenlop.SelectedItem = row.Cells["Tên Lớp"].Value.ToString();
                cboqtmakhoahoc.SelectedValue = row.Cells["Mã Khóa Học"].Value.ToString();

                a = row.Cells["Tên Lớp"].Value.ToString();
                b = row.Cells["Mã Khóa Học"].Value.ToString();
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
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng KHDT");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkkhdt_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkkhdt.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkkhdt.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaKHDT as'Mã Kế Hoạch Đào Tạo', TenLop as'Tên Lớp', MaKhoaHoc as'Mã Khóa Học' FROM dbo.KeHoachDaoTao WHERE MaKHDT LIKE '%" + txtqttkkhdt.Text.Trim() + "%' OR TenLop LIKE '%" + txtqttkkhdt.Text.Trim() + "%' OR MakHoaHoc LIKE N'%" + txtqttkkhdt.Text.Trim() + "%'  ";
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
                        txtqttkkhdt.Focus();

                        dgvqtkhdt.DataSource = ds.Tables[0];

                        txtqtmakhdt.Text = ds.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();
                        cboqttenlop.Text = ds.Tables[0].Rows[0]["Tên Lớp"].ToString();
                        cboqtmakhoahoc.Text = ds.Tables[0].Rows[0]["Mã Khóa Học"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Lớp"].ToString();
                        b = dss.Tables[0].Rows[0]["Mã Khóa Học"].ToString();
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

        private void frmqtkhdt_Load(object sender, EventArgs e)
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }
    }
}
