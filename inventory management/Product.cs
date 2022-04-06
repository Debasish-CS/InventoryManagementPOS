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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select prodid, prodname, prodquantity, prodamt  from ProdTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridMS.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        void filterbycat()
        {
            try
            {
                con.Open();
                string query = "select * from CatTbl where catname = '" + catcombo.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query, con);
                SqlDataReader rdr = null;
                int myInt = 0;
                try
                {
                    rdr = cmd1.ExecuteReader();
                    while (rdr.Read())
                    {
                        myInt = rdr.GetInt32(0);
                    }
                    rdr.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                int id = myInt;
                string myquery = "select prodid, prodname, prodquantity, prodamt  from ProdTbl where prodcatid='"+ id +"'";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridMS.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        void fillcategory()
        {
            string query = "select * from CatTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("catname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                catcombo.ValueMember = "catname";
                catcombo.DataSource = dt;
                CatSelect.ValueMember = "catname";
                CatSelect.DataSource = dt; 


                con.Close();

            }catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (productnameTbMs.Text == "" || productqtyTbMs.Text == "" || productamtTbMs.Text == "" || TotAmtTbMs.Text == "" || catcombo.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else if(userLvlLabel.Text == "guest")
            {
                MessageBox.Show(" You are not authorised to make changes !!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select * from CatTbl where catname = '" + catcombo.SelectedValue.ToString() + "';";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    SqlDataReader rdr =null;
                    int myInt = 0;
                    try
                    {
                        rdr = cmd1.ExecuteReader();
                        while(rdr.Read())
                        {
                            myInt = rdr.GetInt32(0);
                        }
                        rdr.Close();
                    }
                    catch(Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                    int id = myInt;
                    SqlCommand cmd = new SqlCommand("insert into ProdTbl(prodname,prodquantity,prodamt,prodcatid) values('" + productnameTbMs.Text + "','" + productqtyTbMs.Text + "','" + productamtTbMs.Text + "','"+ id+ "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Product Added Successfully!");

                    con.Close();
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the product name and C no.are unique");
                    con.Close();

                }
            }
        }
     

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();

            userLvlLabel.Text = LoginForm.userLvl;

        }


        private void deleteBtnMs_Click(object sender, EventArgs e)
        {
            if (userLvlLabel.Text == "guest")
            {
                MessageBox.Show(" You are not authorised to make changes !!");
            }
            else {
                try
                {

                    if (productnameTbMs.Text == "")
                    {
                        MessageBox.Show("Please select Product !");
                    }


                    else
                    {
                        con.Open();
                        string myquery = "delete from ProdTbl where prodid = '" + dataGridMS.SelectedRows[0].Cells[0].Value.ToString() + "'";
                        SqlCommand cmd = new SqlCommand(myquery, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Deleted Successfully!");
                        con.Close();
                        populate();
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
            

        }
       
        

        private void dataGridMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            productnameTbMs.Text = dataGridMS.SelectedRows[0].Cells[1].Value.ToString();
            productqtyTbMs.Text = dataGridMS.SelectedRows[0].Cells[2].Value.ToString();
            productamtTbMs.Text = dataGridMS.SelectedRows[0].Cells[3].Value.ToString();

           
        }

        private void editBtnMs_Click(object sender, EventArgs e)
        {
            if (userLvlLabel.Text == "guest")
            {
                MessageBox.Show(" You are not authorised to make changes !!");
            }
            else
            {
                try
                {
                    con.Open();

                    
                    string query = "select * from CatTbl where catname = '" + catcombo.SelectedValue.ToString() + "';";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    SqlDataReader rdr = null;
                    int myInt = 0;
                    try
                    {
                        rdr = cmd1.ExecuteReader();
                        while (rdr.Read())
                        {
                            myInt = rdr.GetInt32(0);
                        }
                        rdr.Close();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                    int id = myInt;
                    
                    SqlCommand cmd = new SqlCommand("update ProdTbl set    prodname='" + productnameTbMs.Text + "', prodquantity= '" + productqtyTbMs.Text + "', prodamt ='" + productamtTbMs.Text + "', prodcatid='"+ id +"' where prodid='" + dataGridMS.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                    MessageBox.Show("Product Edited Successfully!");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
           
        }

        private void catcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            filterbycat();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void excelExport_Click(object sender, EventArgs e)
        {
            if (dataGridMS.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridMS.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridMS.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridMS.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridMS.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridMS.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void productamtTbMs_TextChanged(object sender, EventArgs e)
        {
            double calc;
            try {
                double amt = Convert.ToDouble(productamtTbMs.Text);
                int qty = Convert.ToInt32(productqtyTbMs.Text);
                calc = Convert.ToDouble(amt * qty);

                TotAmtTbMs.Text = calc.ToString();
            }
            catch
            {
                calc = 0.0;
            }
           


        }

        private void productnameTbMs_TextChanged(object sender, EventArgs e)
        {

        }

        private void productqtyTbMs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
