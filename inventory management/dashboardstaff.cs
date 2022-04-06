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
    public partial class dashboardstaff : Form
    {
        public dashboardstaff()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            Category cw = new Category();
            cw.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Category cw = new Category();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            Customers cw = new Customers();
            cw.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customers cw = new Customers();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Product cw = new Product();
            cw.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Product cw = new Product();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            Order cw = new Order();
            cw.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Order cw = new Order();
            cw.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            supplier cw = new supplier();
            cw.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            supplier cw = new supplier();
            cw.Show();
            this.Hide();
        }
    }
    }

