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
    public partial class frmqthocphan : Form
    {
        public frmqthocphan()
        {
            InitializeComponent();
            Loadcboboxnganh("SELECT * FROM Nganh", "MaNganh", "MaNganh");
            Loadcboboxkyhoc("SELECT * FROM KyHoc ", "KyHoc", "KyHoc");
            Loadcboboxkhoahoc("SELECT * FROM Khoahoc", "KhoaHoc", "KhoaHoc");
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
        public void Loadcboboxkyhoc(string query, string dis, string valu)
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
            cboqtkyhoc.DataSource = ds.Tables[0];
            cboqtkyhoc.DisplayMember = dis;
            cboqtkyhoc.ValueMember = valu;
        }
        public void Loadcboboxkhoahoc(string query, string dis, string valu)
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
            cboqtkhoahoc.DataSource = ds.Tables[0];
            cboqtkhoahoc.DisplayMember = dis;
            cboqtkhoahoc.ValueMember = valu;
        }
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":


                    btnqtthemhp.Enabled = true;
                    btnqtsuahp.Enabled = true;
                    btnqtxoahp.Enabled = true;
                    btnqtghihp.Enabled = false;
                    btnqthuyhp.Enabled = false;


                    txtqtmahp.Enabled = false;
                    txtqttenhp.Enabled = false;
                    cboqtmanganh.Enabled = false;
                    cboqtsotinchi.Enabled = false;
                    cboqtkyhoc.Enabled = false;
                    cboqtkhoahoc.Enabled = false;
                    break;
                case "insert":
                    btnqtthemhp.Enabled = false;
                    btnqtsuahp.Enabled = false;
                    btnqtxoahp.Enabled = false;
                    btnqtghihp.Enabled = true;
                    btnqthuyhp.Enabled = true;

                    txtqtmahp.Enabled = true;
                    txtqttenhp.Enabled = true;
                    cboqtmanganh.Enabled = true;
                    cboqtsotinchi.Enabled = true;
                    cboqtkyhoc.Enabled = true;
                    cboqtkhoahoc.Enabled = true;

                    txtqtmahp.Text = "";
                    txtqttenhp.Text = "";

                    txtqtmahp.Focus();
                    break;
                case "edit":

                    btnqtthemhp.Enabled = false;
                    btnqtsuahp.Enabled = false;
                    btnqtxoahp.Enabled = false;
                    btnqtghihp.Enabled = true;
                    btnqthuyhp.Enabled = true;

                    txtqtmahp.Enabled = false;
                    txtqttenhp.Enabled = true;
                    cboqtmanganh.Enabled = true;
                    cboqtsotinchi.Enabled = true;
                    cboqtkyhoc.Enabled= true;
                    cboqtkhoahoc.Enabled= true;

                    txtqttenhp.Focus();
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
                string query = "SELECT * FROM HocPhan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqthp.DataSource = ds.Tables[0];

                    txtqtmahp.Text = ds.Tables[0].Rows[0]["MaHP"].ToString();
                    
                    txtqttenhp.Text = ds.Tables[0].Rows[0]["TenHP"].ToString();
                    cboqtmanganh.SelectedValue = ds.Tables[0].Rows[0]["MaNganh"].ToString();
                    if (Convert.ToInt32(ds.Tables[0].Rows[0]["SoTC"])==2)
                    {
                        cboqtsotinchi.Text = "2";
                    }else if (Convert.ToInt32(ds.Tables[0].Rows[0]["SoTC"]) == 3)
                    {
                        cboqtsotinchi.Text = "3";
                    }
                    else
                    {
                        cboqtsotinchi.Text = "4";
                    }
                    cboqtkyhoc.SelectedValue = ds.Tables[0].Rows[0]["KyHoc"].ToString();
                    cboqtkhoahoc.SelectedValue = ds.Tables[0].Rows[0]["Khoahoc"].ToString();
                }
                else
                {
                    dgvqthp.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemhp_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuahp_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoahp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.HocPhan WHERE MaHP='" + txtqtmahp.Text.Trim() + "'";
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

        private void btnqthuyhp_Click(object sender, EventArgs e)
        {
            txtqtmahp.Text = "";
            txtqttenhp.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghihp_Click(object sender, EventArgs e)
        {
            try
            {
                int sotc;
                if (cboqtsotinchi.SelectedItem.Equals("2"))
                {
                    sotc = 2;
                }
                else if (cboqtsotinchi.SelectedItem.Equals("3"))
                {
                    sotc = 3;
                }
                else
                {
                    sotc = 4;
                }

                if (status == "insert")
                {
                    SqlConnection conn = new SqlConnection(connectionsString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO HocPhan (MaHP,MaNganh,KyHoc,KhoaHoc,TenHP,SoTC) VALUES ('" + txtqtmahp.Text.Trim() + "','" + cboqtmanganh.SelectedValue.ToString() + "','"+cboqtkyhoc.SelectedValue.ToString()+ "','"+cboqtkhoahoc.SelectedValue.ToString()+"',N'" + txtqttenhp.Text.Trim() + "','" + sotc + "')";
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
                    string query = "UPDATE dbo.HocPhan SET MaNganh='" + cboqtmanganh.SelectedValue.ToString() + "',KyHoc='"+cboqtkyhoc.SelectedValue.ToString()+ "',KhoaHoc='"+cboqtkhoahoc.SelectedValue.ToString()+"',TenHP=N'" + txtqttenhp.Text.Trim() + "',SoTC='" + sotc + "' WHERE MaHP='" + txtqtmahp.Text.Trim() + "'";
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
        private void dgvqthp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvqthp.Rows[e.RowIndex];
            txtqtmahp.Text = row.Cells["MaHP"].Value.ToString();
            txtqttenhp.Text = row.Cells["TenHP"].Value.ToString();
            cboqtmanganh.SelectedValue = row.Cells["MaNganh"].Value.ToString();
            if (Convert.ToInt32(row.Cells["SoTC"].Value) == 2)
            {
                cboqtsotinchi.Text = "2";
            }
            else if (Convert.ToInt32(row.Cells["SoTC"].Value) == 3)
            {
                cboqtsotinchi.Text = "3";
            }
            else
            {
                cboqtsotinchi.Text = "4";
            }
            cboqtkyhoc.SelectedValue = row.Cells["KyHoc"].Value.ToString();
            cboqtkhoahoc.SelectedValue = row.Cells["KhoaHoc"].Value.ToString();
        }
    }
}
