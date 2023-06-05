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
    public partial class frmqtkyhoc : Form
    {
        public frmqtkyhoc()
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


                    btnqtthemkyhoc.Enabled = true;
                    btnqtsuakyhoc.Enabled = true;
                    btnqtxoakyhoc.Enabled = true;
                    btnqtghikyhoc.Enabled = false;
                    btnqthuykyhoc.Enabled = false;


                    txtqtkyhoc.Enabled = false;
                    txtqtghichu.Enabled = false;
   
                    break;
                case "insert":
                    btnqtthemkyhoc.Enabled = false;
                    btnqtsuakyhoc.Enabled = false;
                    btnqtxoakyhoc.Enabled = false;
                    btnqtghikyhoc.Enabled = true;
                    btnqthuykyhoc.Enabled = true;


                    txtqtkyhoc.Enabled = true;
                    txtqtghichu.Enabled = true;
     


                    txtqtkyhoc.Text = "";
                    txtqtghichu.Text = "";


                    txtqtkyhoc.Focus();
                    break;
                case "edit":

                    btnqtthemkyhoc.Enabled = false;
                    btnqtsuakyhoc.Enabled = false;
                    btnqtxoakyhoc.Enabled = false;
                    btnqtghikyhoc.Enabled = true;
                    btnqthuykyhoc.Enabled = true;

                    txtqtkyhoc.Enabled = false;
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
                string query = "SELECT * FROM KyHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtkyhoc.DataSource = ds.Tables[0];

                    txtqtkyhoc.Text = ds.Tables[0].Rows[0]["KyHoc"].ToString();
                    txtqtghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    

                }
                else
                {
                    dgvqtkyhoc.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemkyhoc_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuakyhoc_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoakyhoc_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.KyHoc WHERE KyHoc='" + txtqtkyhoc.Text.Trim() + "'";
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

        private void btnqthuykyhoc_Click(object sender, EventArgs e)
        {
            txtqtkyhoc.Text = "";
            txtqtghichu.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghikyhoc_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO KyHoc (KyHoc,GhiChu) VALUES ('" + txtqtkyhoc.Text.Trim() + "',N'" + txtqtghichu.Text.Trim() + "')";
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
                    string query = "UPDATE dbo.KyHoc SET GhiChu=N'" + txtqtghichu.Text.Trim() + "' WHERE KyHoc='" + txtqtghichu.Text.Trim() + "'";
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

        private void dgvqtkyhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqtkyhoc.Rows[e.RowIndex];
            txtqtkyhoc.Text = row.Cells["KyHoc"].Value.ToString();
            txtqtghichu.Text = row.Cells["GhiChu"].Value.ToString();
    
        }

    }
}
