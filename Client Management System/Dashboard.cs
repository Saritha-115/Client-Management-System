using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void showForm(Object form)
        {
            panel_f.Show();
            panel_f.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panel_f.Controls.Add(frm);
            panel_f.Tag= frm;
            frm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.p_slide.Location = new Point(btn_editdlt.Location.X, p_slide.Location.Y);
            label_dash.Visible = false;
            showForm(new Editdlt());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.p_slide.Location = new Point(btn_home.Location.X, p_slide.Location.Y);
            label_dash.Show();
            panel_f.Hide();


        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel_f.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.p_slide.Location = new Point(btn_add.Location.X, p_slide.Location.Y);
            label_dash.Visible=false;
            showForm(new Add());
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.p_slide.Location = new Point(btn_report.Location.X, p_slide.Location.Y);
            label_dash.Visible = false;
            showForm(new Report());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.p_slide.Location=new Point(button1.Location.X, p_slide.Location.Y);
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
