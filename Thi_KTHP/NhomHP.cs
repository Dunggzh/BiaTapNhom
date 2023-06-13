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
            Loadcboboxmagv("SELECT * FROM GiangVien", "MaGV", "MaGV");
            //Loadcboboxmakhdt("SELECT * FROM KeHoachDaoTao", "MaKHDT", "MaKHDT");
            Setstatus("reset");
            BindingData();
        }

        public static string status = "";
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";

        public void Loadcboboxmahp(string query, string dis, string valu)
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
            cboqtmahp.DataSource = ds.Tables[0];
            cboqtmahp.DisplayMember = dis;
            cboqtmahp.ValueMember = valu;
        }
        public void Loadcboboxmagv(string query, string dis, string valu)
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
            cboqtmagv.DataSource = ds.Tables[0];
            cboqtmagv.DisplayMember = dis;
            cboqtmagv.ValueMember = valu;
        }
        //public void Loadcboboxmakhdt(string query, string dis, string valu)
        //{
        //    SqlConnection conn = new SqlConnection(connectionsString);
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
                    btnqthuynhp.Enabled = false;

                    txtqtmanhp.Enabled = false;
                    txtqttennhp.Enabled = false;
                    cboqtmahp.Enabled = false;
                    cboqtmagv.Enabled = false;
                    cboqtmakhdt.Enabled = false;


                    break;
                case "insert":
                    btnqtthemnhp.Enabled = false;
                    btnqtsuanhp.Enabled = false;
                    btnqtxoanhp.Enabled = false;
                    btnqtghinhp.Enabled = true;
                    btnqthuynhp.Enabled = true;

                    txtqtmanhp.Enabled = true;
                    txtqttennhp.Enabled = true;
                    cboqtmahp.Enabled = true;
                    cboqtmagv.Enabled = true;
                    cboqtmakhdt.Enabled = true;

                    txtqtmanhp.Text = "";
                    txtqttennhp.Text = "";

                    txtqtmanhp.Focus();
                    break;
                case "edit":
                    btnqtthemnhp.Enabled = false;
                    btnqtsuanhp.Enabled = false;
                    btnqtxoanhp.Enabled = false;
                    btnqtghinhp.Enabled = true;
                    btnqthuynhp.Enabled = true;

                    txtqtmanhp.Enabled = false;
                    txtqttennhp.Enabled = true;
                    cboqtmahp.Enabled = true;
                    cboqtmagv.Enabled = true;
                    cboqtmakhdt.Enabled = true;

                    txtqttennhp.Focus();
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
                string query = "SELECT * FROM NhomHP";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtnhp.DataSource = ds.Tables[0];

                    txtqtmanhp.Text = ds.Tables[0].Rows[0]["MaNhomHP"].ToString();
                    txtqttennhp.Text = ds.Tables[0].Rows[0]["TenNhomHP"].ToString();
                    cboqtmahp.SelectedValue = ds.Tables[0].Rows[0]["MaHP"].ToString();
                    cboqtmagv.SelectedValue = ds.Tables[0].Rows[0]["MaGV"].ToString();
                    cboqtmakhdt.SelectedValue = ds.Tables[0].Rows[0]["MaKHDT"].ToString();
                }
                else
                {
                    dgvqtnhp.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SqlConnection conn = new SqlConnection(connectionsString);
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

        private void btnqthuynhp_Click(object sender, EventArgs e)
        {
            txtqtmanhp.Text = "";
            txtqttennhp.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghinhp_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO NhomHP (MaNhomHP,TenNhomHP,MaHP,MaGV,MaKHDT) VALUES ('" + txtqtmanhp.Text.Trim() + "',N'" + txtqttennhp.Text.Trim() + "','" + cboqtmahp.SelectedValue.ToString() + "','" + cboqtmagv.SelectedValue.ToString() + "','" + cboqtmakhdt.SelectedValue.ToString() + "')";
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
                    string query = "UPDATE dbo.NhomHP SET TenNhomHP=N'" + txtqttennhp.Text.Trim() + "',MaHP='" + cboqtmahp.SelectedValue.ToString() + "',MaGV='" + cboqtmagv.SelectedValue.ToString() + "',MaKHDT='" + cboqtmakhdt.SelectedValue.ToString() + "' WHERE MaNhomHP='" + txtqtmanhp.Text.Trim() + "'";
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

        private void dgvqtnhp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqtnhp.Rows[e.RowIndex];
            txtqtmanhp.Text = row.Cells["MaNhomHP"].Value.ToString();
            txtqttennhp.Text = row.Cells["TenNhomHP"].Value.ToString();
            cboqtmahp.SelectedValue = row.Cells["MaHP"].Value.ToString();
            cboqtmagv.SelectedValue = row.Cells["MaGV"].Value.ToString();
            cboqtmakhdt.SelectedValue = row.Cells["MaKHDT"].Value.ToString();
        }
    }
}
