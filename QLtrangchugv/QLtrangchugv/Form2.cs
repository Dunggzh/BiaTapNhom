﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLtrangchugv
{
    public partial class frmttcn : Form
    {
        string tk = "NguyenthiA";
        string mk = "a";
        int quyen = 1;
        public frmttcn()
        {
            InitializeComponent();
            dgvttcn.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-NVIUQTM\\SQLEXPRESS;Initial Catalog=Demo_QLD;Integrated Security=True");
        private void frmttcn_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string query = "select MaGV,TenGV,SoDT,TrinhDo,MaKhoa from GiangVien Where UseName='" + tk + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dgvttcn.DataSource = dt;
            conn.Close();
        }

        private void dgvttcn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvttcn.Rows[e.RowIndex];
            txtmagv.Text = i.Cells[0].Value.ToString();
            txttengv.Text= i.Cells[1].Value.ToString();
            txtsdt.Text = i.Cells[2].Value.ToString();
            txttrinhdo.Text = i.Cells[3].Value.ToString();
            txtmakhoa.Text = i.Cells[4].Value.ToString();
        }
    }
}
