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
            Loadcboboxkhoa("SELECT * FROM Khoa", "MaKhoa", "MaKhoa");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";

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
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":


                    btnqtthemgv.Enabled = true;
                    btnqtsuagv.Enabled = true;
                    btnqtxoagv.Enabled = true;
                    btnqtghigv.Enabled = false;
                    btnqthuygv.Enabled = false;


                    txtqtmagv.Enabled = false;
                    txtqttengv.Enabled = false;
                    txtqtsodtgv.Enabled = false;
                    cboqttrinhdogv.Enabled = false;
                    cboqtmakhoa.Enabled = false;

                    break;
                case "insert":
                    btnqtthemgv.Enabled = false;
                    btnqtsuagv.Enabled = false;
                    btnqtxoagv.Enabled = false;
                    btnqtghigv.Enabled = true;
                    btnqthuygv.Enabled = true;

                    txtqtmagv.Enabled = true;
                    txtqttengv.Enabled = true;
                    txtqtsodtgv.Enabled = true;
                    cboqttrinhdogv.Enabled = true;
                    cboqtmakhoa.Enabled = true;


                    txtqtmagv.Text = "";
                    txtqttengv.Text = "";
                    txtqtsodtgv.Text = "";

                    txtqtmagv.Focus();
                    break;
                case "edit":

                    btnqtthemgv.Enabled = false;
                    btnqtsuagv.Enabled = false;
                    btnqtxoagv.Enabled = false;
                    btnqtghigv.Enabled = true;
                    btnqthuygv.Enabled = true;

                    txtqtmagv.Enabled = false;
                    txtqttengv.Enabled = true;
                    txtqtsodtgv.Enabled = true;
                    cboqttrinhdogv.Enabled = true;
                    cboqtmakhoa.Enabled = true;

                    txtqttengv.Focus();
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
                string query = "SELECT * FROM GiangVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtgv.DataSource = ds.Tables[0];

                    txtqtmagv.Text = ds.Tables[0].Rows[0]["MaGV"].ToString();
                    txtqttengv.Text = ds.Tables[0].Rows[0]["TenGV"].ToString();
                    if (ds.Tables[0].Rows[0]["TrinhDo"].ToString()=="Thạc sĩ")
                    {
                        cboqttrinhdogv.Text = "Thạc sĩ";
                    }
                    else if (ds.Tables[0].Rows[0]["TrinhDo"].ToString()== "Tiến sĩ")
                    {
                        cboqttrinhdogv.Text = "Tiến sĩ";
                    }
                    else if (ds.Tables[0].Rows[0]["TrinhDo"].ToString()=="Giáo sư")
                    {
                        cboqttrinhdogv.Text = "Giáo sư";
                    }
                    else
                    {
                        cboqttrinhdogv.Text = "Khác";
                    }
                    txtqtsodtgv.Text = ds.Tables[0].Rows[0]["SoDT"].ToString();
                    cboqtmakhoa.SelectedValue = ds.Tables[0].Rows[0]["MaKhoa"].ToString();
                }
                else
                {
                    dgvqtgv.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                SqlConnection conn = new SqlConnection(connectionsString);
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

        private void btnqthuygv_Click(object sender, EventArgs e)
        {
            txtqtmagv.Text = "";
            txtqttengv.Text = "";
            txtqtsodtgv.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghigv_Click(object sender, EventArgs e)
        {
            try
            {
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

                if (status == "insert")
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO GiangVien (MaGV,TenGV,SoDT,TrinhDo,MaKhoa) VALUES ('" + txtqtmagv.Text.Trim() + "',N'" + txtqttengv.Text.Trim() + "','" + txtqtsodtgv.Text.Trim() + "',N'" + trinhdo + "','" + cboqtmakhoa.SelectedValue.ToString() + "')";
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
                    string query = "UPDATE dbo.GiangVien SET TenGV=N'" + txtqttengv.Text.Trim() + "',SoDT='" + txtqtsodtgv.Text.Trim() + "',TrinhDo=N'" + trinhdo + "', MaKhoa='" + cboqtmakhoa.SelectedValue.ToString() + "'  WHERE MaGV='" + txtqtmagv.Text.Trim() + "'";
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

        private void dgvqtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtgv.Rows[e.RowIndex];
                txtqtmagv.Text = row.Cells["MaGV"].Value.ToString();
                txtqttengv.Text = row.Cells["TenGV"].Value.ToString();

                if (row.Cells["TrinhDo"].Value.ToString() == "Thạc sĩ")
                {
                    cboqttrinhdogv.Text = "Thạc sĩ";
                }
                else if (row.Cells["TrinhDo"].Value.ToString() == "Tiến sĩ")
                {
                    cboqttrinhdogv.Text = "Tiến sĩ";
                }
                else if (row.Cells["TrinhDo"].Value.ToString() == "Giáo sư")
                {
                    cboqttrinhdogv.Text = "Giáo sư";
                }
                else
                {
                    cboqttrinhdogv.Text = "Khác";
                }
                txtqtsodtgv.Text = row.Cells["SoDT"].Value.ToString();
                cboqtmakhoa.SelectedValue = row.Cells["MaKhoa"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Arranged");
            }
            
        }
    }
}
