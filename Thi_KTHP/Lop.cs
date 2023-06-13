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
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";

        public void Loadcboboxnganh(string query, string dis, string valu)
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
                    btnqthuylop.Enabled = false;

                    txtqttenlop.Enabled = false;
                    cboqtmanganh.Enabled = false;
                    txtqtghichu.Enabled = false;
                    break;
                case "insert":
                    btnqtthemlop.Enabled = false;
                    btnqtsualop.Enabled = false;
                    btnqtxoalop.Enabled = false;
                    btnqtghilop.Enabled = true;
                    btnqthuylop.Enabled = true;


                    txtqttenlop.Enabled = true;
                    cboqtmanganh.Enabled = true;
                    txtqtghichu .Enabled = true;

                    txtqttenlop.Text = "";
                    txtqtghichu.Text = "";
                    txtqttenlop.Focus();
                    break;
                case "edit":

                    btnqtthemlop.Enabled = false;
                    btnqtsualop.Enabled = false;
                    btnqtxoalop.Enabled = false;
                    btnqtghilop.Enabled = true;
                    btnqthuylop.Enabled = true;


                    txtqttenlop.Enabled = false;
                    cboqtmanganh.Enabled = true;
                    txtqtghichu.Enabled= true;

                    cboqtmanganh.Focus();
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
                string query = "SELECT * FROM Lop";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtlop.DataSource = ds.Tables[0];

                    txtqttenlop.Text = ds.Tables[0].Rows[0]["TenLop"].ToString();
                    cboqtmanganh.SelectedValue = ds.Tables[0].Rows[0]["MaNganh"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                }
                else
                {
                    dgvqtlop.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SqlConnection conn = new SqlConnection(connectionsString);
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
                    SqlConnection conn = new SqlConnection(connectionsString);
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
                    SqlConnection conn = new SqlConnection(connectionsString);
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
            var row = (DataGridViewRow)dgvqtlop.Rows[e.RowIndex];
            txtqttenlop.Text = row.Cells["TenLop"].Value.ToString();
            cboqtmanganh.SelectedValue = row.Cells["MaNganh"].Value.ToString();
            txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
        }
    }
} 

