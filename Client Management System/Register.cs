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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");
        SqlCommand cmd;

        private void btn_cross_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txt_usern.Text=="" || txt_passw.Text=="" || txt_confirmp.Text=="")
            {
                MessageBox.Show("Cannot register with empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_passw.Text.Length<=5)
            {
                MessageBox.Show("Password must be more than four letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_passw.Text == txt_confirmp.Text)
            {
                con.Open();
                string register = "insert into User_Login values ('" + txt_usern.Text + "','" + txt_passw.Text + "')";
                cmd = new SqlCommand(register,con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_usern.Text = "";
                txt_passw.Text = "";
                txt_confirmp.Text = "";

                MessageBox.Show("Your Account has created successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password doesn't match, please Re-enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_passw.Text = "";
                txt_confirmp.Text = "";
                txt_passw.Focus();
            }
        }

        private void check_passw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_passw.Checked)
            {
                txt_passw.PasswordChar = '\0';
                txt_confirmp.PasswordChar = '\0';
            }
            else
            {
                txt_passw.PasswordChar = '*';
                txt_confirmp.PasswordChar = '*';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_usern.Text = "";
            txt_passw.Text = "";
            txt_confirmp.Text = "";
            txt_passw.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
