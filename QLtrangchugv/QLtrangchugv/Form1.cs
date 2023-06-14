using System.Security.Cryptography;

namespace QLtrangchugv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentformchild;
        private void Openformchild(Form childform)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }
            currentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlqlgv.Controls.Add(childform);
            pnlqlgv.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnsttcn_Click(object sender, EventArgs e)
        {
            Openformchild(new frmttcn());
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmqlsinhvien());
        }

        private void thôngTinKhoáHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Openformchild(new frmtthp());
        }
    }
}