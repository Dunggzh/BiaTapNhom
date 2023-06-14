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
            cboqtmakhoa.DataSource = ds.Tables[0];
            cboqtmakhoa.DisplayMember = dis;
            cboqtmakhoa.ValueMember = valu;
        }
        public static string status = "";
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";

        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":


                    btnqtthemnganh.Enabled = true;
                    btnqtsuanganh.Enabled = true;
                    btnqtxoanganh.Enabled = true;
                    btnqtghinganh.Enabled = false;
                    btnqthuynganh.Enabled = false;


                    txtqtmanganh.Enabled = false;
                    txtqttennganh.Enabled = false;
                    cboqtmakhoa.Enabled = false;
                    break;
                case "insert":
                    btnqtthemnganh.Enabled = false;
                    btnqtsuanganh.Enabled = false;
                    btnqtxoanganh.Enabled = false;
                    btnqtghinganh.Enabled = true;
                    btnqthuynganh.Enabled = true;


                    txtqtmanganh.Enabled = true;
                    txtqttennganh.Enabled = true;
                    cboqtmakhoa.Enabled = true;

                    txtqtmanganh.Text = "";
                    txtqttennganh.Text = "";

                    txtqtmanganh.Focus();
                    break;
                case "edit":

                    btnqtthemnganh.Enabled = false;
                    btnqtsuanganh.Enabled = false;
                    btnqtxoanganh.Enabled = false;
                    btnqtghinganh.Enabled = true;
                    btnqthuynganh.Enabled = true;

                    txtqtmanganh.Enabled = false;
                    txtqttennganh.Enabled = true;
                    cboqtmakhoa.Enabled = true;

                    txtqttennganh.Focus();
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
                string query = "SELECT MaNganh  as'Mã ngành', TenNganh as 'Tên ngành', MaKhoa as 'Mã khoa' FROM Nganh";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtnganh.DataSource = ds.Tables[0];

                    txtqtmanganh.Text = ds.Tables[0].Rows[0]["Mã ngành"].ToString();
                    txtqttennganh.Text = ds.Tables[0].Rows[0]["Tên ngành"].ToString();
                    cboqtmakhoa.SelectedValue = ds.Tables[0].Rows[0]["Mã khoa"].ToString();

                }
                else
                {
                    dgvqtnganh.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SqlConnection conn = new SqlConnection(connectionsString);
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

        private void btnqthuynganh_Click(object sender, EventArgs e)
        {
            txtqtmanganh.Text = "";
            txtqttennganh.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghinganh_Click(object sender, EventArgs e)
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
                if (status == "edit")
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE dbo.Nganh SET TenNganh=N'" + txtqttennganh.Text.Trim() + "',Makhoa='"+cboqtmakhoa.SelectedValue.ToString()+"' WHERE MaNganh='" + txtqtmanganh.Text.Trim() + "'";
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

        private void dgvqtnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtnganh.Rows[e.RowIndex];
                txtqtmanganh.Text = row.Cells["Mã ngành"].Value.ToString();
                txtqttennganh.Text = row.Cells["Tên ngành"].Value.ToString();
                cboqtmakhoa.SelectedValue = row.Cells["Mã khoa"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arranged");
            }

        }
    }
}
