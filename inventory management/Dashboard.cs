using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label10.Text = LoginForm.Userlvl;
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            Category cw = new Category();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            if(LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                Customers cw = new Customers();
                cw.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                ManageUser cw = new ManageUser();
                cw.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Product cw = new Product();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                Order cw = new Order();
                cw.Show();
                this.Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                supplier cw = new supplier();
                cw.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Category cw = new Category();
            cw.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                Customers cw = new Customers();
                cw.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                ManageUser cw = new ManageUser();
                cw.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Product cw = new Product();
            cw.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                Order cw = new Order();
                cw.Show();
                this.Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorise to access this option");
            }
            else
            {
                supplier cw = new supplier();
                cw.Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}


