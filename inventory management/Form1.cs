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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEBASISH\Documents\Inventory_Manage_user.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Userlvl = "";
        public static string Username = "";
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Userlvl = "guest";
            Dashboard dash = new Dashboard();
            dash.Show();
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
            else
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Userlvl = UserlevelTb.SelectedItem.ToString();
            Username = usernameTb.Text;
            con.Open();
            string pass = PaswordTb.Text;
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl where username ='" + usernameTb.Text + "' and password = '" + (pass.GetHashCode()).GetHashCode() + "' and userlevel='"+UserlevelTb.SelectedItem.ToString()+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password");
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PaswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserlevelTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
