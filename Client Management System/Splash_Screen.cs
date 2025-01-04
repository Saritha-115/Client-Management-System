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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading_p.Width += 3;
            if(loading_p.Width >= 871)
            {
                loading_t.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {

        }

        private void panel_l_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
