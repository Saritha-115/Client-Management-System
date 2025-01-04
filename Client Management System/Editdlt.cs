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

    public partial class Editdlt : Form
    {
        public Editdlt()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        private void btn_display_Click(object sender, EventArgs e)
        {
          
        }

        public void Clear()
        {
            txt_cID.Text = "";
            txt_Name.Text = "";
            txt_vehicle_num.Text = "";
            txt_email.Text = "";
            txt_cn.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
            populate();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Customer_Details3 set Name='" + txt_Name.Text + "',Vehicle_Num='" + txt_vehicle_num.Text + "',Email='" + txt_email.Text + "',Contact_num='" + txt_cn.Text + "'where C_ID='" + key + "'", con);
            cmd.ExecuteNonQuery();
           
           
            //    string edit = "update Customer_Details1 set Name='" + txt_Name.Text + "',Age='" + txt_age.Text + "',Email='" + txt_email.Text + "',Contact_num='" + txt_cn.Text + "'where C_ID='" + txt_cID.Text + "'";
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
            else if (!match.Success || txt_email.Text.Any(Char.IsUpper))
            {
                MessageBox.Show("Please enter the email properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_cn.Text.Any(char.IsLetter) || txt_cn.Text.Length == 0 || txt_cn.Text.Length != 10)
            {
                MessageBox.Show("Please enter the contact number properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                MessageBox.Show("Data edited successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                Clear();
            }
            con.Close();
        }
        SqlCommand cmd;
        private void btn_dlt_Click(object sender, EventArgs e)
        {
            con.Open();
            string dlt = "delete from Customer_Details3 where C_ID='" + txt_cID.Text + "'";
            cmd = new SqlCommand(dlt, con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Data deleted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populate();
                Clear();
            }
            else
            {
                MessageBox.Show("Data cannot delete, You must enter the C_ID and delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void gdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void populate()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");

            con.Open();
            da = new SqlDataAdapter("select * from Customer_Details3", con);
            dt = new DataTable();
            da.Fill(dt);
            gdv.DataSource = dt;
            con.Close();
        }
        private void Editdlt_Load(object sender, EventArgs e)
        {
            
        }
       
        private void Editdlt_Load_1(object sender, EventArgs e)
        {
            populate();
            //this.Show();
            //gdv.Hide();
        }
        int key;
        private void gdv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gdv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            key = Convert.ToInt32(gdv.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = gdv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_vehicle_num.Text = gdv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_email.Text = gdv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_cn.Text = gdv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_cID_TextChanged(object sender, EventArgs e)
        {
            //txt_cID.ReadOnly = true;
           // searchData(txt_cID.Text);
        }
        public void searchData(string search)
        {
           
        }
        private void txt_cID_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
           // searchData(txt_Name.Text);

        }

        private void txt_vehicle_num_TextChanged(object sender, EventArgs e)
        {
          //  searchData(txt_vehicle_num.Text);

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
          // searchData(txt_email.Text);

        }

        private void txt_cn_TextChanged(object sender, EventArgs e)
        {
            
          //  searchData(txt_cn.Text);
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GDQHQDB;Initial Catalog=Center;Integrated Security=True");

            if (txt_cID.Text == "" && txt_Name.Text == "" && txt_vehicle_num.Text == "" && txt_email.Text == "" && txt_cn.Text == "")
            {
                MessageBox.Show("Enter details before searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt = new DataTable();
                if (txt_cID.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Customer_Details3 where C_ID like '%" + txt_cID.Text + "%'", con);
                    da.Fill(dt);
                }
                if (txt_Name.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Customer_Details3 where Name like '%" + txt_Name.Text + "%'", con);
                    da.Fill(dt);
                }
                if (txt_vehicle_num.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Customer_Details3 where Vehicle_Num like '%" + txt_vehicle_num.Text + "%'", con);
                    da.Fill(dt);
                }
                if (txt_email.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Customer_Details3 where Email like '%" + txt_email.Text + "%'", con);
                    da.Fill(dt);
                }
                if (txt_cn.Text.Length > 0)
                {
                    da = new SqlDataAdapter("select * from Customer_Details3 where Contact_num like '%" + txt_cn.Text + "%'", con);
                    da.Fill(dt);
                }
                gdv.DataSource = dt;
            }
          
        }
    }
}
