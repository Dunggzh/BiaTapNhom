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
                    cboqtmanganh.Enabled = true;
                    txtqtghichu.Enabled = true;
                    txtqttklop.Enabled = false;

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

                }
                else
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
                    }
                    else
                    {
                        MessageBox.Show("Delete error");
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqthuylop_Click(object sender, EventArgs e)
        {
            txtqttenlop.Text = "";
            txtqtghichu.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghilop_Click(object sender, EventArgs e)
        {
            try
            {

                if (status == "insert")
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
                if (status == "edit")
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvqtlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtlop.Rows[e.RowIndex];
                txtqttenlop.Text = row.Cells["TenLop"].Value.ToString();
                cboqtmanganh.SelectedValue = row.Cells["MaNganh"].Value.ToString();
                txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Arranged");
            }

        }
    }
} 

