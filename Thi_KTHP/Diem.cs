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
    public partial class frmqtdiem : Form
    {
        public frmqtdiem()
        {
            InitializeComponent();
            Loadcboboxmasv("select * from SinhVien", "MaSinhVien", "MaSinhVien");
            Loadcboboxmahp("SELECT * FROM NhomHP", "MaNhomHP", "MaNhomHP");
            Setstatus("reset");
            BindingData();
        }

        public static string status = "";
        public static string connectionsString =
            "data source = LAPTOP-2LQNMVB4; database = Demo_QLD; user id = sa; password = 1;";
        public void Loadcboboxmasv(string query, string dis, string valu)
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
            cboqtmasv.DataSource = ds.Tables[0];
            cboqtmasv.DisplayMember = dis;
            cboqtmasv.ValueMember = valu;
        }
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
            cboqtnhomhocphan.DataSource = ds.Tables[0];
            cboqtnhomhocphan.DisplayMember = dis;
            cboqtnhomhocphan.ValueMember = valu;
        }
        public void Setstatus(String state)
        {
            switch (state)
            {
                case "reset":
                    btnqtthemdiem.Enabled = true;
                    btnqtsuadiem.Enabled = true;
                    btnqtxoadiem.Enabled = true;
                    btnqtghidiem.Enabled = false;
                    btnqthuydiem.Enabled = false;


                    txtqtdiemcc.Enabled = false;
                    txtqtdiemgk.Enabled = false;
                    txtqtdiemth.Enabled = false;
                    txtqtdiemkt.Enabled = false;
                    txtqtdiemtl.Enabled = false;
                    txtqtdiemtongket.Enabled = false;
                    txtqtdiemchu.Enabled = false;
                    cboqtmasv.Enabled = false;
                    cboqtnhomhocphan.Enabled = false;
  

                    break;
                case "insert":
                    btnqtthemdiem.Enabled = false;
                    btnqtsuadiem.Enabled = false;
                    btnqtxoadiem.Enabled = false;
                    btnqtghidiem.Enabled = true;
                    btnqthuydiem.Enabled = true;


                    txtqtdiemcc.Enabled = true;
                    txtqtdiemgk.Enabled = true;
                    txtqtdiemth.Enabled = true;
                    txtqtdiemkt.Enabled = true;
                    txtqtdiemtl.Enabled = true;
                    txtqtdiemtongket.Enabled = true;
                    txtqtdiemchu.Enabled = true;
                    cboqtmasv.Enabled = true;
                    cboqtnhomhocphan.Enabled = true;



                    txtqtdiemcc.Text = "";
                    txtqtdiemgk.Text = "";
                    txtqtdiemth.Text = "";
                    txtqtdiemkt.Text = "";
                    txtqtdiemtl.Text = "";
                    txtqtdiemtongket.Text = "";
                    txtqtdiemchu.Text = "";

                    txtqtdiemcc.Focus();
                    break;
                case "edit":
                    btnqtthemdiem.Enabled = false;
                    btnqtsuadiem.Enabled = false;
                    btnqtxoadiem.Enabled = false;
                    btnqtghidiem.Enabled = true;
                    btnqthuydiem.Enabled = true;


                    txtqtdiemcc.Enabled = true;
                    txtqtdiemgk.Enabled = true;
                    txtqtdiemth.Enabled = true;
                    txtqtdiemkt.Enabled = true;
                    txtqtdiemtl.Enabled = true;
                    txtqtdiemtongket.Enabled = true;
                    txtqtdiemchu.Enabled = true;
                    cboqtmasv.Enabled = false;
                    cboqtnhomhocphan.Enabled = true;

                    txtqtdiemcc.Focus();
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
                string query = "SELECT * FROM Diem";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvqtdiem.DataSource = ds.Tables[0];

                    txtqtdiemcc.Text = ds.Tables[0].Rows[0]["ChuyenCan"].ToString();
                    txtqtdiemgk.Text = ds.Tables[0].Rows[0]["KiemTraGK"].ToString();
                    txtqtdiemth.Text = ds.Tables[0].Rows[0]["ThucHanh"].ToString();
                    txtqtdiemkt.Text = ds.Tables[0].Rows[0]["ThiKetthuc"].ToString();
                    txtqtdiemtl.Text = ds.Tables[0].Rows[0]["ThaoLuan"].ToString();
                    txtqtdiemtongket.Text = ds.Tables[0].Rows[0]["TongKetHP"].ToString();
                    txtqtdiemchu.Text = ds.Tables[0].Rows[0]["DiemChu"].ToString();

                    cboqtmasv.SelectedValue = ds.Tables[0].Rows[0]["MaSinhVien"].ToString();
                    cboqtnhomhocphan.SelectedValue = ds.Tables[0].Rows[0]["MaNhomHP"].ToString();
                }
                else
                {
                    dgvqtdiem.DataSource = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnqtthemdiem_Click(object sender, EventArgs e)
        {
            status = "insert";
            Setstatus(status);
        }

        private void btnqtsuadiem_Click(object sender, EventArgs e)
        {
            status = "edit";
            Setstatus(status);
        }

        private void btnqtxoadiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionsString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "DELETE dbo.Diem WHERE MaSinhVien='" + cboqtmasv.SelectedValue.ToString() + "'";
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

        private void btnqthuydiem_Click(object sender, EventArgs e)
        {
            txtqtdiemcc.Text = "";
            txtqtdiemgk.Text = "";
            txtqtdiemth.Text = "";
            txtqtdiemkt.Text = "";
            txtqtdiemtl.Text = "";
            txtqtdiemtongket.Text = "";
            txtqtdiemchu.Text = "";

            status = "reset";
            Setstatus(status);
            BindingData();
        }

        private void btnqtghidiem_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO Diem (ChuyenCan,KiemTraGK,ThucHanh,ThiKetthuc,ThaoLuan,TongKetHP,DiemChu,MaSinhVien,MaNhomHP) VALUES ('" +float.Parse(txtqtdiemcc.Text.ToString()) + "','" + float.Parse(txtqtdiemgk.Text.Trim()) + "','" + float.Parse(txtqtdiemth.Text.Trim()) + "','" + float.Parse(txtqtdiemkt.Text.Trim()) + "','" + float.Parse(txtqtdiemtl.Text.Trim()) + "','" + float.Parse(txtqtdiemtongket.Text.Trim()) + "','" + txtqtdiemchu.Text.Trim() + "','" + cboqtmasv.SelectedValue.ToString() + "','" + cboqtnhomhocphan.SelectedValue.ToString() + "')";
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
                    string query = "UPDATE dbo.SinhVien SET ChuyenCan='" + float.Parse(txtqtdiemcc.Text.Trim()) + "',KiemTraGK='" + float.Parse(txtqtdiemgk.Text.Trim()) + "',ThucHanh='" + float.Parse(txtqtdiemth.Text.Trim()) + "',ThiKetThuc='" + float.Parse(txtqtdiemkt.Text.Trim()) + "',ThaoLuan='" + float.Parse(txtqtdiemtl.Text.Trim()) + "',TongKetHP='" + float.Parse(txtqtdiemtongket.Text.Trim()) + "',DiemChu='" + txtqtdiemchu.Text.Trim() + "',MaNhomHP='" + cboqtnhomhocphan.SelectedValue.ToString() + "' WHERE MaSinhVien = '" + cboqtmasv.SelectedValue.ToString() + "'";
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

        private void dgvqtdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvqtdiem.Rows[e.RowIndex];
                txtqtdiemcc.Text = row.Cells["ChuyenCan"].Value.ToString();
                txtqtdiemgk.Text = row.Cells["KiemTraGK"].Value.ToString();
                txtqtdiemth.Text = row.Cells["ThucHanh"].Value.ToString();
                txtqtdiemkt.Text = row.Cells["ThiKetthuc"].Value.ToString();
                txtqtdiemtl.Text = row.Cells["ThaoLuan"].Value.ToString();
                txtqtdiemtongket.Text = row.Cells["TongKetHP"].Value.ToString();
                txtqtdiemchu.Text = row.Cells["DiemChu"].Value.ToString();

                cboqtmasv.SelectedValue = row.Cells["MaSinhVien"].Value.ToString();
                cboqtnhomhocphan.SelectedValue = row.Cells["MaNhomHP"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Arranged");
            }
        }
    }
}
