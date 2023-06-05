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


                    txtqtkhoahoc.Enabled = false;
                    txtqtghichu.Enabled = false;
                    break;
                case "insert":
                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;


                    txtqtkhoahoc.Enabled = true;
                    txtqtghichu.Enabled = true;


                    txtqtkhoahoc.Text = "";
                    txtqtghichu.Text = "";


                    txtqtkhoahoc.Focus();
                    break;
                case "edit":

                    btnqtthemkhoahoc.Enabled = false;
                    btnqtsuakhoahoc.Enabled = false;
                    btnqtxoakhoahoc.Enabled = false;
                    btnqtghikhoahoc.Enabled = true;
                    btnqthuykhoahoc.Enabled = true;

                    txtqtkhoahoc.Enabled = false;
                    txtqtghichu.Enabled = true;

                    txtqtghichu.Focus();
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
                string query = "SELECT * FROM Khoahoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkhoahoc.DataSource = ds.Tables[0];

                    txtqtkhoahoc.Text = ds.Tables[0].Rows[0]["KhoaHoc"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();

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

                string query = "DELETE dbo.KhoaHoc WHERE KhoaHoc='" + txtqtkhoahoc.Text.Trim() + "'";
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
            txtqtkhoahoc.Text = "";
            txtqtghichu.Text = "";

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
                    string query = "INSERT INTO KhoaHoc (KhoaHoc,GhiChu) VALUES ('" + txtqtkhoahoc.Text.Trim() + "',N'" + txtqtghichu.Text.Trim()+"')";
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
                    string query = "UPDATE dbo.KhoaHoc SET GhiChu=N'" + txtqtghichu.Text.Trim()+"' WHERE KhoaHoc='" + txtqtkhoahoc.Text.Trim() + "'";
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
        private void dgvqtkhoahoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqtkhoahoc.Rows[e.RowIndex];
            txtqtkhoahoc.Text = row.Cells["KhoaHoc"].Value.ToString();
            txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
        }
    }
}
