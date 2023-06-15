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
            Loadcboboxtenlop("SELECT * FROM Lop", "TenLop", "TenLop");
            Loadcboboxmakhoahoc("SELECT * FROM KhoaHoc", "MaKhoaHoc", "MaKhoaHoc");
            Setstatus("reset");
            BindingData();
        }
        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);

        public void Loadcboboxtenlop(string query, string dis, string valu)
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
            cboqttenlop.DataSource = ds.Tables[0];
            cboqttenlop.DisplayMember = dis;
            cboqttenlop.ValueMember = valu;
        }
        public void Loadcboboxmakhoahoc(string query, string dis, string valu)
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
                    btnqthuykhdt.Enabled = false;

                    txtqtmakhdt.Enabled = false;
                    cboqttenlop.Enabled = false;
                    cboqtmakhoahoc.Enabled = false;
   
                    break;
                case "insert":
                    btnqtthemkhdt.Enabled = false;
                    btnqtsuakhdt.Enabled = false;
                    btnqtxoakhdt.Enabled = false;
                    btnqtghikhdt.Enabled = true;
                    btnqthuykhdt.Enabled = true;

                    txtqtmakhdt.Enabled = true;
                    cboqttenlop.Enabled = true;
                    cboqtmakhoahoc .Enabled = true;
     
                    txtqtmakhdt.Text = "";

                    txtqtmakhdt.Focus();
                    break;
                case "edit":
                    btnqtthemkhdt.Enabled = false;
                    btnqtsuakhdt.Enabled = false;
                    btnqtxoakhdt.Enabled = false;
                    btnqtghikhdt.Enabled = true;
                    btnqthuykhdt.Enabled = true;

                    txtqtmakhdt.Enabled = false;
                    cboqttenlop .Enabled = true;
                    cboqtmakhoahoc.Enabled = true;

                    cboqttenlop.Focus();
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
                string query = "SELECT * FROM KeHoachDaoTao";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhdt.DataSource = ds.Tables[0];

                    txtqtmakhdt.Text = ds.Tables[0].Rows[0]["MaKHDT"].ToString();
                    cboqttenlop.SelectedValue = ds.Tables[0].Rows[0]["TenLop"].ToString();
                    cboqtmakhoahoc.SelectedValue = ds.Tables[0].Rows[0]["MaKhoaHoc"].ToString();
                }
                else
                {
                    dgvqtkhdt.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnqthuykhdt_Click(object sender, EventArgs e)
        {
            txtqtmakhdt.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghikhdt_Click(object sender, EventArgs e)
        {
            try
            {

                if (status == "insert")
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO KeHoachDaoTao (MaKHDT,TenLop,MaKhoaHoc) VALUES ('" + txtqtmakhdt.Text.Trim() + "',N'" + cboqttenlop.SelectedValue.ToString() + "','" + cboqtmakhoahoc.SelectedValue.ToString() + "')";
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
                    string query = "UPDATE dbo.KeHoachDaoTao SET TenLop=N'" + cboqttenlop.SelectedValue.ToString() + "',MaKhoaHoc='" + cboqtmakhoahoc.SelectedValue.ToString() + "' WHERE MaKHDT='" + txtqtmakhdt.Text.Trim() + "'";
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

        private void dgvqtkhdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtkhdt.Rows[e.RowIndex];
                txtqtmakhdt.Text = row.Cells["MaKHDT"].Value.ToString();
                cboqttenlop.SelectedValue = row.Cells["TenLop"].Value.ToString();
                cboqtmakhoahoc.SelectedValue = row.Cells["MaKhoaHoc"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Arranged");
            }

        }
    }
}
