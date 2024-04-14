using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Winforms_e_Selenium
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormConfirm frm = new FormConfirm();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormSocin frm = new FormSocin();
            frm.Show();
        }

        private void picElgin_Click(object sender, EventArgs e)
        {
            FormElgin frm = new FormElgin();
            frm.Show();
        }

        private void picSimus_Click(object sender, EventArgs e)
        {
            FormPortalSimus frm = new FormPortalSimus();
            frm.Show();
        }

        private void picContako_Click(object sender, EventArgs e)
        {
            FormContako frm = new FormContako();
            frm.Show();
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            FormBigData frm = new FormBigData();
            frm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormAdminAutosky frm = new FormAdminAutosky();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPortalSkyone frm = new FormPortalSkyone();
            frm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FormSimplificacao frm = new FormSimplificacao();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormConfirm frm = new FormConfirm();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormSocin frm = new FormSocin();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormContako frm = new FormContako();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormElgin frm = new FormElgin();
            frm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormPortalSimus frm = new FormPortalSimus();
            frm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormBigData frm = new FormBigData();
            frm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormAdminAutosky frm = new FormAdminAutosky();
            frm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormSimplificacao frm = new FormSimplificacao();
            frm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FormPortalSkyone frm = new FormPortalSkyone();
            frm.Show();
        }
    }
}
