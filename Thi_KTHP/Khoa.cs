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

        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":


                    btnqtthemkhoa.Enabled = true;
                    btnqtsuakhoa.Enabled = true;
                    btnqtxoakhoa.Enabled = true;
                    btnqtghikhoa.Enabled = false;
                    btnqthuykhoa.Enabled = false;


                    txtqtmakhoa.Enabled = false;
                    txtqttenkhoa.Enabled = false;
                    txtqtsdt.Enabled = false;
                    txtqtghichu.Enabled = false;
                    break;
                case "insert":
                    btnqtthemkhoa.Enabled = false;
                    btnqtsuakhoa.Enabled = false;
                    btnqtxoakhoa.Enabled = false;
                    btnqtghikhoa.Enabled = true;
                    btnqthuykhoa.Enabled = true;


                    txtqtmakhoa.Enabled = true;
                    txtqttenkhoa.Enabled = true;
                    txtqtsdt.Enabled = true;
                    txtqtghichu.Enabled = true;

                    txtqtmakhoa.Text = "";
                    txtqttenkhoa.Text = "";
                    txtqtsdt.Text = "";
                    txtqtghichu.Text = "";
                    txtqtmakhoa.Focus();
                    break;
                case "edit":

                    btnqtthemkhoa.Enabled = false;
                    btnqtsuakhoa.Enabled = false;
                    btnqtxoakhoa.Enabled = false;
                    btnqtghikhoa.Enabled = true;
                    btnqthuykhoa.Enabled = true;

                    txtqtmakhoa.Enabled = false;
                    txtqttenkhoa.Enabled = true;
                    txtqtsdt.Enabled = true;
                    txtqtghichu.Enabled = true;

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
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoa.DataSource = ds.Tables[0];

                    txtqtmakhoa.Text = ds.Tables[0].Rows[0]["MaKhoa"].ToString();
                    txtqttenkhoa.Text = ds.Tables[0].Rows[0]["TenKhoa"].ToString();
                    txtqtsdt.Text = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqthuykhoa_Click(object sender, EventArgs e)
        {
            txtqtmakhoa.Text = "";
            txtqttenkhoa.Text = "";
            txtqtsdt.Text = "";
            txtqtghichu.Text = "";

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
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvqtkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqtkhoa.Rows[e.RowIndex];
            txtqtmakhoa.Text = row.Cells["MaKhoa"].Value.ToString();
            txtqttenkhoa.Text = row.Cells["TenKhoa"].Value.ToString();
            txtqtsdt.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
        }
    }
}
