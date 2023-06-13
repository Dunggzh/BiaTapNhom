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
    public partial class frmqtkhoahoc : Form
    {
        public frmqtkhoahoc()
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


                    btnqtthemkhoahoc.Enabled = true;
                    btnqtsuakhoahoc.Enabled = true;
                    btnqtxoakhoahoc.Enabled = true;
                    btnqtghikhoahoc.Enabled = false;
                    btnqthuykhoahoc.Enabled = false;


                    txtqtmakhoahoc.Enabled = false;
                    txtqttenkhoahoc.Enabled = false;
                    txtqtkyhoc.Enabled = false;
                    break;
                case "insert":
                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;


                    txtqtmakhoahoc.Enabled = true;
                    txtqttenkhoahoc.Enabled = true;
                    txtqtkyhoc.Enabled = true;


                    txtqtmakhoahoc.Text = "";
                    txtqttenkhoahoc.Text = "";
                    txtqtkyhoc.Text = "";


                    txtqtmakhoahoc.Focus();
                    break;
                case "edit":

                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;

                    txtqtmakhoahoc.Enabled = false;
                    txtqttenkhoahoc.Enabled = true;
                    txtqtkyhoc.Enabled = true;

                    txtqttenkhoahoc.Focus();
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
                string query = "SELECT * FROM KhoaHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoahoc.DataSource = ds.Tables[0];

                    txtqtmakhoahoc.Text = ds.Tables[0].Rows[0]["MaKhoaHoc"].ToString();
                    txtqttenkhoahoc.Text = ds.Tables[0].Rows[0]["TenKhoaHoc"].ToString();
                    txtqtkyhoc.Text = ds.Tables[0].Rows[0]["KyHoc"].ToString();

                }
                else
                {
                    dgvqtkhoahoc.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemkhoahoc_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuakhoahoc_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoakhoahoc_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.KhoaHoc WHERE KhoaHoc='" + txtqtmakhoahoc.Text.Trim() + "'";
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

        private void btnqthuykhoahoc_Click(object sender, EventArgs e)
        {
            txtqtmakhoahoc.Text = "";
            txtqttenkhoahoc.Text = "";
            txtqtkyhoc.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghikhoahoc_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO KhoaHoc (KhoaHoc,TenKhoaHoc,KyHoc) VALUES ('" + txtqtmakhoahoc.Text.Trim() + "',N'" + txtqttenkhoahoc.Text.Trim()+ "','" + txtqtkyhoc.Text.Trim()+"')";
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
                    string query = "UPDATE dbo.KhoaHoc SET TenKhoaHoc=N'" + txtqttenkhoahoc.Text.Trim()+ "',KyHoc='" + txtqtkyhoc.Text.Trim()+"' WHERE KhoaHoc='" + txtqtmakhoahoc.Text.Trim() + "'";
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

        private void dgvqtkhoahoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqtkhoahoc.Rows[e.RowIndex];
            txtqtmakhoahoc.Text = row.Cells["MaKhoaHoc"].Value.ToString();
            txtqttenkhoahoc.Text = row.Cells["TenKhoaHoc"].Value.ToString();
            txtqtkyhoc.Text = row.Cells["KyHoc"].Value.ToString();
        }
    }
}
