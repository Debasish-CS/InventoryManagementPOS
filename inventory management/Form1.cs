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

namespace inventory_management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string userLvl = "";
        public static string userName = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userLvl = "guest";
            
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true)
            {
                PaswordTb.UseSystemPasswordChar = false;
            }
            else if(checkBox1.Checked == false)
            {
                PaswordTb.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            usernameTb.Text = "";
            PaswordTb.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            userLvl = userlevelCb.SelectedItem.ToString();
            userName = usernameTb.Text;
            try
            {
                con.Open();
                string pass = PaswordTb.Text;
                SqlDataAdapter Sda = new SqlDataAdapter("Select Count(*) from UserTbl where username='" + usernameTb.Text + "' and password='" + (pass.GetHashCode()).GetHashCode() + "' and userlevel='" + userlevelCb.SelectedItem.ToString() + "'", con);
                DataTable dt = new DataTable();
                Sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password or Userlevel!");
                }
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
