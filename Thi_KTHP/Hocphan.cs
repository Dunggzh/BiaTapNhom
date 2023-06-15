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
    public partial class frmqthocphan : Form
    {
        public frmqthocphan()
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
                    btnqtthemhp.Enabled = true;
                    btnqtsuahp.Enabled = true;
                    btnqtxoahp.Enabled = true;
                    btnqtghihp.Enabled = false;
                    btnqthuyhp.Enabled = true;
                    btnqtxuatexcell.Enabled = true;
                    btnqttkhocphan.Enabled = true;

                    dgvqthp.Enabled = true;

                    txtqtmahp.Enabled = false;
                    txtqttenhp.Enabled = false;
                    txtqtsotiet.Enabled = false;
                    cboqtsotinchi.Enabled = false;
                    txtqttkhocphan.Enabled = true;
                    break;
                case "insert":
                    btnqtthemhp.Enabled = false;
                    btnqtsuahp.Enabled = false;
                    btnqtxoahp.Enabled = false;
                    btnqtghihp.Enabled = true;
                    btnqthuyhp.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkhocphan.Enabled = false;

                    dgvqthp.Enabled = false;

                    txtqtmahp.Enabled = true;
                    txtqttenhp.Enabled = true;
                    txtqtsotiet.Enabled = true;
                    cboqtsotinchi.Enabled = true;
                    txtqttkhocphan.Enabled = false;

                    txtqtmahp.Text = "";
                    txtqttenhp.Text = "";
                    txtqtsotiet.Text = "";
                    txtqttkhocphan.Text = "";

                    txtqtmahp.Focus();
                    break;
                case "edit":

                    btnqtthemhp.Enabled = false;
                    btnqtsuahp.Enabled = false;
                    btnqtxoahp.Enabled = false;
                    btnqtghihp.Enabled = true;
                    btnqthuyhp.Enabled = true;
                    btnqtxuatexcell.Enabled = false;
                    btnqttkhocphan.Enabled = false;

                    txtqtmahp.Enabled = false;
                    txtqttenhp.Enabled = true;
                    txtqtsotiet.Enabled = true;
                    cboqtsotinchi.Enabled = true;
                    txtqttkhocphan.Enabled = false;

                    txtqttkhocphan.Text = "";

                    txtqttenhp.Focus();
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
                string query = "SELECT MaHP as'Mã Học Phần', TenHP as'Tên Học Phần', SoTC as'Số Tín Chỉ', SoTiet as'Số Tiết' FROM HocPhan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dss = ds;
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqthp.DataSource = ds.Tables[0];

                    txtqtmahp.Text = ds.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                    txtqttenhp.Text = ds.Tables[0].Rows[0]["Tên Học Phần"].ToString();
                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["Số Tín Chỉ"]) == 2)
                    {
                        cboqtsotinchi.Text = "2";
                    }
                    else if (Convert.ToInt32(ds.Tables[0].Rows[0]["Số Tín Chỉ"]) == 3)
                    {
                        cboqtsotinchi.Text = "3";
                    }
                    else
                    {
                        cboqtsotinchi.Text = "4";
                    }
                    txtqtsotiet.Text = ds.Tables[0].Rows[0]["Số Tiết"].ToString();

                    //bắt lỗi ghi sửa
                    a = dss.Tables[0].Rows[0]["Tên Học Phần"].ToString();
                    b = dss.Tables[0].Rows[0]["Số Tín Chỉ"].ToString();
                    c = dss.Tables[0].Rows[0]["Số Tiết"].ToString();
                }
                else
                {
                    dgvqthp.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqtthemhp_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuahp_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoahp_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Chứ!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE dbo.HocPhan WHERE MaHP='" + txtqtmahp.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        MessageBox.Show("Delete success");
                        status = "reset";
                        Setstatus(status);
                        BindingData();
                        txtqttkhocphan.Text = "";
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

        private void btnqthuyhp_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();

                txtqtmahp.Text = "";
                txtqttenhp.Text = "";
                txtqtsotiet.Text = "";
                txtqttkhocphan.Text = "";

                status = "reset";
                Setstatus(status);
                BindingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
            
        }

        private void btnqtghihp_Click(object sender, EventArgs e)
        {
            try
            {
                errorbatloi.Clear();
                bool check = true; int output;
                if (txtqtmahp.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtmahp, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqttenhp.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqttenhp, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                if (txtqtsotiet.Text == "")
                {
                    check = false;
                    errorbatloi.SetError(txtqtsotiet, "Bạn Chưa Nhập Dữ Liệu Trường Này");
                }
                else
                {
                    if (int.TryParse(txtqtsotiet.Text, out output) == false)
                    {
                        check = false;
                        errorbatloi.SetError(txtqtsotiet, "Sai Định Dạng");
                    }
                }


                int sotc;
                if (cboqtsotinchi.SelectedItem.Equals("2"))
                {
                    sotc = 2;
                }
                else if (cboqtsotinchi.SelectedItem.Equals("3"))
                {
                    sotc = 3;
                }
                else
                {
                    sotc = 4;
                }

                if (status == "insert"&&check==true)
                {
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO HocPhan (MaHP,TenHP,SoTC,SoTiet) VALUES ('" + txtqtmahp.Text.Trim() + "',N'" + txtqttenhp.Text.Trim() + "','"+ sotc + "','"+txtqtsotiet.Text.Trim()+"')";
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
                    if (txtqttenhp.Text.Equals(a) && cboqtsotinchi.SelectedItem.Equals(b) && txtqtsotiet.Text.Equals(c))
                    {
                        MessageBox.Show("Bạn Chưa Thay Đổi Dữ Liệu");
                        txtqttenhp.Focus();
                    }
                    else
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "UPDATE dbo.HocPhan SET TenHP=N'" + txtqttenhp.Text.Trim() + "',SoTC='" + sotc + "',SoTiet='" + txtqtsotiet.Text.Trim() + "' WHERE MaHP='" + txtqtmahp.Text.Trim() + "'";
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
                MessageBox.Show(ex.Message + "\n Mã Học Phần đã tồn tại!");
                txtqtmahp.Focus();
            }
        }
        static string a = null;
        static string b = null;
        static string c = null;
        private void dgvqthp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqthp.Rows[e.RowIndex];
                txtqtmahp.Text = row.Cells["Mã Học Phần"].Value.ToString();
                txtqttenhp.Text = row.Cells["Tên Học Phần"].Value.ToString();
                if (Convert.ToInt32(row.Cells["Số Tín Chỉ"].Value) == 2)
                {
                    cboqtsotinchi.Text = "2";
                }
                else if (Convert.ToInt32(row.Cells["Số Tín Chỉ"].Value) == 3)
                {
                    cboqtsotinchi.Text = "3";
                }
                else
                {
                    cboqtsotinchi.Text = "4";
                }
                txtqtsotiet.Text = row.Cells["Số Tiết"].Value.ToString();

                a = row.Cells["Tên Học Phần"].Value.ToString();
                b = row.Cells["Số Tín Chỉ"].Value.ToString();
                c = row.Cells["Số Tiết"].Value.ToString();
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
                obj.WriteDataTableToExcel(dss.Tables[0], "Person Details", "D:\\Exceldata.xlsx", "Bảng Học Phần");
                MessageBox.Show("Excel created D: \tExceldata.xlsx", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Lỗi rồi! Liên hệ 098***** :<\n Chúng tôi sẽ cố gắng sửa lỗi này một cách sớm nhất!");
            }
        }

        private void btnqttkhocphan_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                if (txtqttkhocphan.Text == "")
                {
                    check = false;
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    txtqttkhocphan.Focus();
                }
                if (check == true)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT MaHP as'Mã Học Phần', TenHP as'Tên Học Phần', SoTC as'Số Tín Chỉ', SoTiet as'Số Tiết' FROM dbo.HocPhan WHERE MaHP LIKE '%" + txtqttkhocphan.Text.Trim() + "%' OR SoTC LIKE '%" + Convert.ToString(txtqttkhocphan.Text) + "%' OR TenHP LIKE N'%" + txtqttkhocphan.Text.Trim() + "%' OR SoTiet LIKE N'%" + Convert.ToString(txtqttkhocphan.Text) + "%'  ";
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
                        txtqttkhocphan.Focus();

                        dgvqthp.DataSource = ds.Tables[0];

                        txtqtmahp.Text = ds.Tables[0].Rows[0]["Mã Học Phần"].ToString();
                        txtqttenhp.Text = ds.Tables[0].Rows[0]["Tên Học Phần"].ToString();
                        cboqtsotinchi.Text = ds.Tables[0].Rows[0]["Số Tín Chỉ"].ToString();
                        txtqtsotiet.Text = ds.Tables[0].Rows[0]["Số Tiết"].ToString();

                        //bắt lỗi ghi sửa
                        a = dss.Tables[0].Rows[0]["Tên Học Phần"].ToString();
                        b = dss.Tables[0].Rows[0]["Số Tín Chỉ"].ToString();
                        c = dss.Tables[0].Rows[0]["Số Tiết"].ToString();
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
