using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITI2022
{
    public partial class FrmFacturation : Form
    {
        public FrmFacturation()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmClient client = new FrmClient();
            client.Show();
            this.Hide();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FrmMesure mes = new FrmMesure();
            mes.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmModel mes = new FrmModel();
            mes.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmConnexion con = new FrmConnexion();
            con.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FrmClient c = new FrmClient();
            c.Visible = true;
            this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            FrmMesure c = new FrmMesure();
            c.Visible = true;
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            FrmModel mod = new FrmModel();
            mod.Show();
            this.Hide();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            FrmConnexion con = new FrmConnexion();
            con.Show();
            this.Hide();
        }
    }
}
