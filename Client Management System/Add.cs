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
using System.Text.RegularExpressions;


namespace Client_Management_System
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
           
        }
        SqlConnection con= new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
         
        public void GetCustomerId()
        {

            string custid;
            string custdetails = "select C_ID from Customer_Details3 order by C_ID Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(custdetails, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                custid = id.ToString("000");
            }
            else if (Convert.IsDBNull(dr))
            {
                custid = ("100");
            }
            else
            {
                custid = ("100");

            }
            con.Close();
            txt_cID.Text = custid.ToString();


        }
        private void populate()
        {
            con.Open();
            da = new SqlDataAdapter("select * from Customer_Details3", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gdv.DataSource = dt;
            con.Close();
        }
        private void Add_Load(object sender, EventArgs e)
        {
            GetCustomerId();
            populate();
            //this.Show();
            //gdv.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            string add = "insert into Customer_Details3 values ('" + txt_Name.Text+ "','" + txt_vehicle_num.Text + "','" + txt_email.Text + "','" + txt_cn.Text + "')";

            if (txt_Name.Text.Length == 0)
            {
                MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Cannot include Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_vehicle_num.Text.Length == 0)
            {
                MessageBox.Show("Vehicle number cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!match.Success||txt_email.Text.Any(Char.IsUpper))
            {
                MessageBox.Show("Please enter the email properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_cn.Text.Any(char.IsLetter) || txt_cn.Text.Length == 0 || txt_cn.Text.Length != 10)
            {
                MessageBox.Show("Please enter the contact number properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(add, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data save successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                Clear();
            }
            GetCustomerId();
        }
        public void Clear()
        {
            
            txt_Name.Text = "";
            txt_vehicle_num.Text = "";
            txt_email.Text = "";
            txt_cn.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            
        }

        private void gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
