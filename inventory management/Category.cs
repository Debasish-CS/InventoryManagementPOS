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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEBASISH\Documents\Inventory_Manage_user.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                con.Open();
                string MYquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(MYquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datagridviewMC.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
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

        private void Category_Load(object sender, EventArgs e)
        {
            populate();
            label10.Text = LoginForm.Userlvl;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorised to make changes");
            }
            else
            {
                try
                {
                    if ( CategorynameMC.Text == "")
                    {
                        MessageBox.Show(" Fill all the fields");
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into CategoryTbl(categoryname) values('" + CategorynameMC.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Successfully Added");
                        con.Close();
                    }
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the Category has an Unique name");
                    con.Close();

                }
            }   
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (LoginForm.Userlvl == "guest")
            {
                MessageBox.Show("You are not authorised to make changes");
            }
           else if (CategorynameMC.Text == "")
            {
                MessageBox.Show("Please Select a Category!");

            }
            else
            {
                con.Open();
                string myquery = "delete from CategoryTbl where categoryid='" + datagridviewMC.SelectedRows[0].Cells[0].Value.ToString() + "'; ";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void datagridviewMC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategorynameMC.Text = datagridviewMC.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(datagridviewMC.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < datagridviewMC.Columns.Count +1; i++)
                {
                    xcelApp.Cells[1, i] = datagridviewMC.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < datagridviewMC.Rows.Count ; i++)
                {
                    for(int j = 0; j < datagridviewMC.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = datagridviewMC.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
