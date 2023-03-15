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
    public partial class FrmMesure : Form
    {
        public FrmMesure()
        {
            InitializeComponent();
        }

        private void FrmMesure_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            FrmModel mod = new FrmModel();
            mod.Show();
            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FrmClient c = new FrmClient();
            c.Visible = true;
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FrmFacturation fac = new FrmFacturation();
            fac.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmConnexion con = new FrmConnexion();
            con.Show();
            this.Hide();
        }
    }
}
