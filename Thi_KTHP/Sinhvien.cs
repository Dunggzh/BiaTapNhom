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
    public partial class frmqtsv : Form
    {
        public frmqtsv()
        {
            InitializeComponent();
            Loadcboboxlop("SELECT * FROM Lop", "TenLop", "TenLop");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";
        
        public void Loadcboboxlop(string query, string dis, string valu)
        {
            SqlConnection conn = new SqlConnection(connectionsString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cboqttenlop.DataSource = ds.Tables[0];
            cboqttenlop.DisplayMember = dis;
            cboqttenlop.ValueMember = valu;
        }
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = true;
                    btnqtsuasv.Enabled = true;
                    btnqtxoasv.Enabled = true;
                    btnqtghisv.Enabled = false;
                    btnqthuysv.Enabled = false;


                    txtqtmasv.Enabled = false;
                    txtqttensv.Enabled = false;
                    txtqtquequansv.Enabled = false;
                    dtpngaysinhsv.Enabled = false;
                    txtqtnoisinhsv.Enabled = false;
                    rdoqtnam.Enabled = false;
                    rdoqtnu.Enabled = false;
                    cboqttenlop.Enabled = false;
                    txtqtghichu.Enabled = false;


                    break;
                case "insert":
                    rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = false;
                    btnqtsuasv.Enabled = false;
                    btnqtxoasv.Enabled = false;
                    btnqtghisv.Enabled = true;
                    btnqthuysv.Enabled = true;

                    txtqtmasv.Enabled = true;
                    txtqttensv.Enabled = true;
                    txtqtquequansv.Enabled = true;
                    dtpngaysinhsv.Enabled = true;
                    txtqtnoisinhsv.Enabled = true;
                    rdoqtnam.Enabled = true;
                    rdoqtnu.Enabled = true;
                    cboqttenlop.Enabled = true;
                    txtqtghichu.Enabled = true;

                    txtqtmasv.Text = "";
                    txtqttensv.Text = "";
                    txtqtquequansv.Text = "";
                    txtqtnoisinhsv.Text = "";
                    txtqtghichu.Text = "";

                    txtqtmasv.Focus();
                    break;
                case "edit":
                    rdoqtnam.Checked = true;

                    btnqtthemsv.Enabled = false;
                    btnqtsuasv.Enabled = false;
                    btnqtxoasv.Enabled = false;
                    btnqtghisv.Enabled = true;
                    btnqthuysv.Enabled = true;

                    txtqtmasv.Enabled = false;
                    txtqttensv.Enabled = true;
                    txtqtquequansv.Enabled = true;
                    dtpngaysinhsv.Enabled = true;
                    txtqtnoisinhsv.Enabled = true;
                    rdoqtnam.Enabled = true;
                    rdoqtnu.Enabled = true;
                    cboqttenlop.Enabled = true;
                    txtqtghichu.Enabled = true;

                    txtqttensv.Focus();
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
                string query = "SELECT * FROM SinhVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtsv.DataSource = ds.Tables[0];

                    txtqtmasv.Text = ds.Tables[0].Rows[0]["MaSinhVien"].ToString();
                    txtqttensv.Text = ds.Tables[0].Rows[0]["TenSV"].ToString();
                    txtqtquequansv.Text = ds.Tables[0].Rows[0]["QueQuan"].ToString();
                    dtpngaysinhsv.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgaySinh"]);
                    txtqtnoisinhsv.Text = ds.Tables[0].Rows[0]["NoiSinh"].ToString();
                    if (ds.Tables[0].Rows[0]["GioiTinh"].ToString() == "NAM")
                    {
                        rdoqtnam.Checked = true;
                        rdoqtnu.Checked = false;
                    }
                    else
                    {
                        rdoqtnam.Checked = false;
                        rdoqtnu.Checked = true;
                    } 
                    cboqttenlop.SelectedValue = ds.Tables[0].Rows[0]["TenLop"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                }
                else
                {
                    dgvqtsv.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemsv_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuasv_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoasv_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.SinhVien WHERE MaSinhVien='" + txtqtmasv.Text.Trim() + "'";
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

        private void btnqthuysv_Click(object sender, EventArgs e)
        {
            txtqtmasv.Text = "";
            txtqttensv.Text = "";
            txtqtquequansv.Text = "";
            txtqtnoisinhsv.Text = "";
            txtqtghichu.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghisv_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = "";
                if (rdoqtnam.Checked)
                {
                    gt = "NAM";

                }
                else
                {
                    gt = "NỮ";
                }
                if (status == "insert")
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO SinhVien (MaSinhVien,TenLop,TenSV,QueQuan,NgaySinh,NoiSinh,GioiTinh,GhiChu) VALUES ('" + txtqtmasv.Text.Trim() + "','" + cboqttenlop.SelectedValue.ToString() + "',N'" + txtqttensv.Text.Trim() + "',N'" + txtqtquequansv.Text.Trim() + "','" + dtpngaysinhsv.Value + "',N'" + txtqtnoisinhsv.Text.Trim() + "',N'" + gt + "',N'" + txtqtghichu.Text.Trim() + "')";
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
                    string query = "UPDATE dbo.SinhVien SET TenLop=N'" + cboqttenlop.SelectedValue.ToString() + "',TenSV=N'" + txtqttensv.Text.Trim() + "',QueQuan=N'" + txtqtquequansv.Text.Trim() + "',NgaySinh='" + dtpngaysinhsv.Value + "',NoiSinh=N'" + txtqtnoisinhsv.Text.Trim() + "',GioiTinh=N'" + gt + "',GhiChu=N'" + txtqtghichu.Text.Trim() + "' WHERE MaSinhVien='" + txtqtmasv.Text.Trim() + "'";
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

        private void dgvqtsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                var row = (DataGridViewRow)dgvqtsv.Rows[e.RowIndex];
                txtqtmasv.Text = row.Cells["MaSinhVien"].Value.ToString();
                txtqttensv.Text = row.Cells["TenSV"].Value.ToString();
                txtqtquequansv.Text = row.Cells["QueQuan"].Value.ToString();
                dtpngaysinhsv.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtqtnoisinhsv.Text = row.Cells["NoiSinh"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "NAM")
                {
                    rdoqtnam.Checked = true;
                    rdoqtnu.Checked = false;
                }
                else
                {
                    rdoqtnam.Checked = false;
                    rdoqtnu.Checked = true;
                }

                cboqttenlop.SelectedValue = row.Cells["TenLop"].Value.ToString();
                txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
        }
    }
}
