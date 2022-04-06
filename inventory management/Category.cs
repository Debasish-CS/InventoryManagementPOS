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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select catid, catname from CatTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridViewMc.DataSource = ds.Tables[0];


                con.Close();
            }
            catch
            {

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void addBtnMcat_Click(object sender, EventArgs e)
        {
            if(catnameTbMc.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
            }

            else if (userLvlLabel.Text == "guest")
            {
                MessageBox.Show(" You are not authorised to make changes !!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CatTbl values('" + catnameTbMc.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Category Added Successfully!");

                    con.Close();
                    populate();

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the Category name is unique");
                    con.Close();
                }
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            populate();

            userLvlLabel.Text = LoginForm.userLvl;

        }

        private void deleteBtnMcat_Click(object sender, EventArgs e)
        {

            if (userLvlLabel.Text == "guest")
            {
                MessageBox.Show(" You are not authorised to make changes !!");
            }
            else
            {
                try
                {

                    if (catnameTbMc.Text == "")
                    {
                        MessageBox.Show("Please provide Catagory!");
                    }

                    else
                    {
                        con.Open();
                        string myquery = "delete from CatTbl where catid = '" + dataGridViewMc.SelectedRows[0].Cells[0].Value.ToString()+ "';";
                        SqlCommand cmd = new SqlCommand(myquery, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Deleted Successfully!");
                        con.Close();
                        populate();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    con.Close();
                }
            }

        }

        private void dataGridViewMc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            catnameTbMc.Text = dataGridViewMc.SelectedRows[0].Cells[1].Value.ToString();
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewMc.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for(int i= 1; i<dataGridViewMc.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridViewMc.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridViewMc.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewMc.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridViewMc.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }
    }
}
