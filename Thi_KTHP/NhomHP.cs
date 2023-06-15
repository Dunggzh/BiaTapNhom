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
    public partial class frmqtnhomhp : Form
    {
        public frmqtnhomhp()
        {
            InitializeComponent();
            Loadcboboxmahp("SELECT * FROM HocPhan", "MaHP", "MaHP");
            //Loadcboboxmagv("SELECT * FROM GiangVien", "MaGV", "MaGV");
            //Loadcboboxmakhdt("SELECT * FROM KeHoachDaoTao", "MaKHDT", "MaKHDT");
            Setstatus("reset");
            BindingData();
        }

        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        // để export excell
        static DataSet dss;
        public void Loadcboboxmahp(string query, string dis, string valu)
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
            cboqtmahp.DataSource = ds.Tables[0];
            cboqtmahp.DisplayMember = dis;
            cboqtmahp.ValueMember = valu;
        }
        //public void Loadcboboxmagv(string query, string dis, string valu)
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
        //    cboqtmagv.DataSource = ds.Tables[0];
        //    cboqtmagv.DisplayMember = dis;
        //    cboqtmagv.ValueMember = valu;
        //}
        //public void Loadcboboxmakhdt(string query, string dis, string valu)
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
        //    cboqtmakhdt.DataSource = ds.Tables[0];
        //    cboqtmakhdt.DisplayMember = dis;
        //    cboqtmakhdt.ValueMember = valu;
        //}

        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemnhp.Enabled = true;
                    btnqtsuanhp.Enabled = true;
                    btnqtxoanhp.Enabled = true;
                    btnqtghinhp.Enabled = false;
                    btnqthuynhp.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttknhp.Enabled = true;

                    dgvqtnhp.Enabled = true;

                    txtqtmanhp.Enabled = false;
                    txtqttennhp.Enabled = false;
                    cboqtmahp.Enabled = false;
                    cboqtmagv.Enabled = false;
                    cboqtmakhdt.Enabled = false;
                    cboqtmakhoahoc.Enabled = false;
                    cboqtmakhoa.Enabled = false;
                    txtqttknhp.Enabled = true;


                    break;
                case "insert":
                    btnqtthemnhp.Enabled = false;
                    btnqtsuanhp.Enabled = false;
                    btnqtxoanhp.Enabled = false;
                    btnqtghinhp.Enabled = true;
                    btnqthuynhp.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttknhp.Enabled = false;

                    dgvqtnhp.Enabled = false;

                    txtqtmanhp.Enabled = true;
                    txtqttennhp.Enabled = true;
                    cboqtmahp.Enabled = true;
                    cboqtmagv.Enabled = true;
                    cboqtmakhdt.Enabled = true;
                    cboqtmakhoahoc.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttknhp.Enabled = false;

                    txtqtmanhp.Text = "";
                    txtqttennhp.Text = "";
                    txtqttknhp.Text = "";

                    txtqtmanhp.Focus();
                    break;
                case "edit":
                    btnqtthemnhp.Enabled = false;
                    btnqtsuanhp.Enabled = false;
                    btnqtxoanhp.Enabled = false;
                    btnqtghinhp.Enabled = true;
                    btnqthuynhp.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttknhp.Enabled = false;

                    txtqtmanhp.Enabled = false;
                    txtqttennhp.Enabled = true;
                    cboqtmahp.Enabled = true;
                    cboqtmagv.Enabled = true;
                    cboqtmakhdt.Enabled = true;
                    cboqtmakhoahoc.Enabled = true;
                    cboqtmakhoa.Enabled = true;
                    txtqttknhp.Enabled = false;

                    txtqttknhp.Text = "";

                    txtqttennhp.Focus();
                    break;
                default: break;
            }
        }

        public void BindingData()
        {
            try
            {


                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT MaNhomHP as'Mã Nhóm Học Phần', TenNhomHP as'Tên Nhóm Học Phần', MaHP as'Mã Học Phần',MaGV as'Mã Giảng Viên', MaKHDT as'Mã Kế Hoạch Đào Tạo' FROM NhomHP";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtnhp.DataSource = ds.Tables[0];

                    txtqtmanhp.Text = ds.Tables[0].Rows[0]["Mã Nhóm Học Phần"].ToString();
                    txtqttennhp.Text = ds.Tables[0].Rows[0]["Tên Nhóm Học Phần"].ToString();
                    cboqtmahp.SelectedValue = ds.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                    cboqtmagv.Text = ds.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                    cboqtmakhdt.Text = ds.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();

                    // bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Nhóm Học Phần"].ToString();
                    b = dss.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                    c = dss.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                    d = dss.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();
                }
                else
                {
                    dgvqtnhp.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemnhp_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuanhp_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoanhp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.NhomHP WHERE MaNhomHP='" + txtqtmanhp.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttknhp.Text = "";
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

        private void btnqthuynhp_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmanhp.Text = "";
                txtqttennhp.Text = "";
                txtqttknhp.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghinhp_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true;
                if (txtqtmanhp.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmanhp, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttennhp.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttennhp, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }

                if (status == "insert"&&check==true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO NhomHP (MaNhomHP,TenNhomHP,MaHP,MaGV,MaKHDT) VALUES ('" + txtqtmanhp.Text.Trim() + "',N'" + txtqttennhp.Text.Trim() + "','" + cboqtmahp.SelectedValue.ToString() + "','" + cboqtmagv.SelectedItem.ToString() + "','" + cboqtmakhdt.SelectedItem.ToString() + "')";
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
                    if (txtqttennhp.Text.Equals(a) && cboqtmahp.SelectedValue.Equals(b) && cboqtmagv.SelectedItem.Equals(c) && cboqtmakhdt.SelectedItem.Equals(d))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttennhp.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.NhomHP SET TenNhomHP=N'" + txtqttennhp.Text.Trim() + "',MaHP='" + cboqtmahp.SelectedValue.ToString() + "',MaGV='" + cboqtmagv.SelectedItem.ToString() + "',MaKHDT='" + cboqtmakhdt.SelectedItem.ToString() + "' WHERE MaNhomHP='" + txtqtmanhp.Text.Trim() + "'";
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
        private void dgvqtnhp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtnhp.Rows[e.RowIndex];
                txtqtmanhp.Text = row.Cells["Mã Nhóm Học Phần"].Value.ToString();
                txtqttennhp.Text = row.Cells["Tên Nhóm Học Phần"].Value.ToString();
                cboqtmahp.SelectedValue = row.Cells["Mã Học Phần"].Value.ToString();
                cboqtmagv.Text = row.Cells["Mã Giảng Viên"].Value.ToString();
                cboqtmakhdt.Text = row.Cells["Mã Kế Hoạch Đào Tạo"].Value.ToString();

                a = row.Cells["Tên Nhóm Học Phần"].Value.ToString();
                b = row.Cells["Mã Học Phần"].Value.ToString();
                c = row.Cells["Mã Giảng Viên"].Value.ToString();
                d = row.Cells["Mã Kế Hoạch Đào Tạo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\t Sắp Xếp");
            }

        }

        private void frmqtnhomhp_Load(object sender, EventArgs e)
        {
            try
            {
                cboqtmakhoahoc.SelectedItem = "--";
                cboqtmakhdt.SelectedItem = "--";
                string query = "select * from KhoaHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmakhoahoc.Items.Add(ds.Tables[0].Rows[i]["TenKhoaHoc"].ToString());
                }

                cboqtmakhoa.SelectedItem = "--";
                cboqtmagv.SelectedItem = "--";
                string query1 = "select * from Khoa";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                for (int i = 0; i <= ds1.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmakhoa.Items.Add(ds1.Tables[0].Rows[i]["TenKhoa"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void cboqtmakhoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboqtmakhdt.Items.Clear();
                cboqtmakhdt.Text = "";
                //cboqtmakhdt.Items.Add("--");
                //cboqtmakhdt.SelectedItem = "--";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from KeHoachDaoTao,KhoaHoc where KeHoachDaoTao.MaKhoaHoc=KhoaHoc.MaKhoaHoc and KhoaHoc.TenKhoaHoc='" + cboqtmakhoahoc.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmakhdt.Items.Add(ds.Tables[0].Rows[i]["MaKHDT"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void cboqtmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboqtmagv.Items.Clear();
                cboqtmagv.Text = "";
                //cboqtmagv.Items.Add("--");
                //cboqtmagv.SelectedItem = "--";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from Khoa,GiangVien where Khoa.MaKhoa=GiangVien.MaKhoa and Khoa.TenKhoa=N'" + cboqtmakhoa.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cboqtmagv.Items.Add(ds.Tables[0].Rows[i]["MaGV"].ToString());
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
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Nhóm Học Phần");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttknhp_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttknhp.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttknhp.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaNhomHP as'Mã Nhóm Học Phần', TenNhomHP as'Tên Nhóm Học Phần', MaHP as'Mã Học Phần',MaGV as'Mã Giảng Viên', MaKHDT as'Mã Kế Hoạch Đào Tạo' FROM dbo.NhomHP WHERE MaNhomHP LIKE '%" + txtqttknhp.Text.Trim() + "%' OR TenNhomHP LIKE N'%" + txtqttknhp.Text.Trim() + "%' OR MaHP LIKE '%" + txtqttknhp.Text.Trim() + "%'OR MaGV LIKE '%" + txtqttknhp.Text.Trim() + "%' OR MaKHDT LIKE '%" + txtqttknhp.Text.Trim() + "%' ";
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
                        txtqttknhp.Focus();

                        dgvqtnhp.DataSource = ds.Tables[0];

                        txtqtmanhp.Text = ds.Tables[0].Rows[0]["Mã Nhóm Học Phần"].ToString();
                        txtqttennhp.Text = ds.Tables[0].Rows[0]["Tên Nhóm Học Phần"].ToString();
                        cboqtmahp.SelectedValue = ds.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                        cboqtmagv.Text = ds.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                        cboqtmakhdt.Text = ds.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();

                        // bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Nhóm Học Phần"].ToString();
                        b = dss.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                        c = dss.Tables[0].Rows[0]["Mã Giảng Viên"].ToString();
                        d = dss.Tables[0].Rows[0]["Mã Kế Hoạch Đào Tạo"].ToString();
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
