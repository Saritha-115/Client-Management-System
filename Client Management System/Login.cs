using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Client_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");
        SqlCommand cmd;
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "select * from User_Login where Username='" + txt_Usern.Text + "'and Password_U='" + txt_Passw.Text + "'";
            cmd= new SqlCommand(login,con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                Dashboard admin_Dashboard = new Dashboard();
                admin_Dashboard.Show();
                this.Hide();
            }
            else if (txt_Usern.Text == "" || txt_Passw.Text == "")
            {
                MessageBox.Show("Cannot login with empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usern.Focus();
            }
            else
            {
                
                MessageBox.Show("invalid username or password, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usern.Text = "";
                txt_Passw.Text = "";
                txt_Usern.Focus();
            }
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Usern.Text = "";
            txt_Passw.Text = "";
            txt_Usern.Focus();
        }

        private void check_passw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_passw.Checked)
            {
                txt_Passw.PasswordChar = '\0';
            }
            else
            {
                txt_Passw.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
