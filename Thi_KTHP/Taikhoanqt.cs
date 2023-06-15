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
    public partial class frmqttaikhoan : Form
    {
        private string username;
        private string pass;
        public frmqttaikhoan()
        {
            InitializeComponent();

        }
        public frmqttaikhoan(string username, string pass)
        {
            InitializeComponent();
            Setstatus("reset");
            BindingData();
            this.username = username;
            this.pass = pass;
        }

        public static string status = "";
        SqlConnection conn = new SqlConnection(ConnectionString.connectionsString);
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":


                    btnqtthemtk.Enabled = true;
                    btnqtsuatk.Enabled = true;
                    btnqtxoatk.Enabled = true;
                    btnqtghitk.Enabled = false;
                    btnqthuytk.Enabled = true;

                    txtqtusername.Enabled = false;
                    txtqtpass.Enabled = false;
                    txtqtquyen.Enabled = false;
                    break;
                case "insert":
                    btnqtthemtk.Enabled = false;
                    btnqtsuatk.Enabled = false;
                    btnqtxoatk.Enabled = false;
                    btnqtghitk.Enabled = true;
                    btnqthuytk.Enabled = true;

                    txtqtusername.Enabled = true;
                    txtqtpass.Enabled = true;
                    txtqtquyen.Enabled = true;

                    txtqtusername.Text = "";
                    txtqtpass.Text = "";
                    txtqtquyen.Text = "";

                    txtqtusername.Focus();
                    break;
                case "edit":

                    btnqtthemtk.Enabled = false;
                    btnqtsuatk.Enabled = false;
                    btnqtxoatk.Enabled = false;
                    btnqtghitk.Enabled = true;
                    btnqthuytk.Enabled = true;

                    txtqtusername.Enabled = false;
                    txtqtpass.Enabled = true;
                    txtqtquyen.Enabled = true;

                    txtqtpass.Focus();
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
                string query = "SELECT * FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqttaikhoan.DataSource = ds.Tables[0];

                    txtqtusername.Text = ds.Tables[0].Rows[0]["UserName"].ToString();
                    txtqtpass.Text = ds.Tables[0].Rows[0]["pass"].ToString();
                    txtqtquyen.Text = ds.Tables[0].Rows[0]["Quyen"].ToString();
                }
                else
                {
                    dgvqttaikhoan.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemtk_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuatk_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoatk_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.TaiKhoan WHERE UserName='" + txtqtusername.Text.Trim() + "'";
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

        private void btnqthuytk_Click(object sender, EventArgs e)
        {
            txtqtusername.Text = "";
            txtqtpass.Text = "";
            txtqtquyen.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghitk_Click(object sender, EventArgs e)
        {
            try
            {

                if (status == "insert")
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO TaiKhoan (UserName,pass,Quyen) VALUES ('" + txtqtusername.Text.Trim() + "','" + txtqtpass.Text.Trim() + "','" + txtqtquyen.Text.Trim() + "')";
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
                    string query = "UPDATE dbo.TaiKhoan SET pass='" + txtqtpass.Text.Trim() + "',Quyen='" + txtqtquyen.Text.Trim()+ "' WHERE UserName='" + txtqtusername.Text.Trim() + "'";
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

        private void dgvqttaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqttaikhoan.Rows[e.RowIndex];
                txtqtusername.Text = row.Cells["UserName"].Value.ToString();
                txtqtpass.Text = row.Cells["pass"].Value.ToString();
                txtqtquyen.Text = row.Cells["Quyen"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Arranged");
            }
        }
    }
}
