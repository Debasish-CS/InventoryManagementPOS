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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        void populate()
        {
            try
            {
                con.Open();
                if(LoginForm.userLvl == "admin") 
                {
                    string myquery = "select userid, username, userlevel, telephone from UserTbl";
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridMu.DataSource = ds.Tables[0];
                    userlevelCbMu.Visible = true;

                }
                else
                {
                    string myquery = "select userid, username, userlevel, telephone from UserTbl where username = '"+ LoginForm.userName +"'";
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridMu.DataSource = ds.Tables[0];
                    usernameTbMu.ReadOnly = true;
                    userlevelCbMu.Visible = false;
                }
                
                


                con.Close();
            }
            catch
            {

            }
        }
       /*void filluserlevel()
        {
            string query = "select distinct userlevel from UserTbl order by userlevel";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("userlevel", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                userlevelCbMu.ValueMember = "userlevel";
                userlevelCbMu.DataSource = dt;
                con.Close();
 

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }*/

        private void addBtnMu_Click(object sender, EventArgs e)
        {
            if(LoginForm.userLvl != "admin")
            {
                MessageBox.Show("You are not authorised to add an User!");
            }
            else
            {
                try
                {
                    if (usernameTbMu.Text == "" || fullnameTbMu.Text == "" || passwordTbMu.Text == "" || telephoneTbMu.Text == "")
                    {
                        MessageBox.Show("Please provide Data to all specified Fields!");

                    }
                    else
                    {
                        con.Open();
                        string pass = passwordTbMu.Text;
                        SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + usernameTbMu.Text + "','" + fullnameTbMu.Text + "','" + userlevelCbMu.SelectedItem.ToString() + "','" + (pass.GetHashCode()).GetHashCode() + "','" + telephoneTbMu.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Added Successfully!");
                        con.Close();
                        populate();
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the User has an Unique name and telephone no. ");
                    con.Close();
                }
            }
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();

            userLvlLabel.Text = LoginForm.userLvl;





        }




        private void usernameMu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void deleteBtnMu_Click(object sender, EventArgs e)
        {
            if (LoginForm.userLvl != "admin")
            {
                MessageBox.Show("You are not authorised to delete your own Account!\n Pleae ask the Admin to do so.");
            }
            else
            {
                try
                {

                    if (usernameTbMu.Text == "")
                    {
                        MessageBox.Show("Please Select an User!");
                    }
                    else
                    {
                        con.Open();
                        string myquery = "delete from UserTbl where userid = '" + dataGridMu.SelectedRows[0].Cells[0].Value.ToString() + "';";
                        SqlCommand cmd = new SqlCommand(myquery, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Deleted Successfully!");
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

        private void dataGridMu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //useridTbMu.Text = dataGridMu.SelectedRows[0].Cells[0].Value.ToString();
            usernameTbMu.Text = dataGridMu.SelectedRows[0].Cells[1].Value.ToString();
            userlevelCbMu.SelectedItem = dataGridMu.SelectedRows[0].Cells[2].Value.ToString();
            telephoneTbMu.Text = dataGridMu.SelectedRows[0].Cells[3].Value.ToString();
            fullnameTbMu.Text = "";
            passwordTbMu.Text = "";
        }

        private void editBtnMu_Click(object sender, EventArgs e)
        {
            
            try
            {

                
                con.Open();
                string pass = "1234";
                if (fullnameTbMu.Text == "" && passwordTbMu.Text == "")
                {
                    SqlCommand cmd = new SqlCommand("update UserTbl set  username='" + usernameTbMu.Text + "', userlevel='" + userlevelCbMu.SelectedItem.ToString() + "', telephone='" + telephoneTbMu.Text + "', fullname='" + usernameTbMu.Text + "', password='" + (pass.GetHashCode()).GetHashCode() + "' where userid= '" + dataGridMu.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                    MessageBox.Show("User Edited Successfully!");
                    cmd.ExecuteNonQuery();
                }
                else if(fullnameTbMu.Text == "" && passwordTbMu.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("update UserTbl set  username='" + usernameTbMu.Text + "', userlevel='" + userlevelCbMu.SelectedItem.ToString() + "', telephone='" + telephoneTbMu.Text + "', fullname='" + usernameTbMu.Text + "', password='" + ((passwordTbMu.Text).GetHashCode()).GetHashCode() + "' where userid= '" + dataGridMu.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                    MessageBox.Show("User Edited Successfully!");
                    cmd.ExecuteNonQuery();
                }else if(fullnameTbMu.Text != "" && passwordTbMu.Text == "")
                {
                    SqlCommand cmd = new SqlCommand("update UserTbl set  username='" + usernameTbMu.Text + "', userlevel='" + userlevelCbMu.SelectedItem.ToString() + "', telephone='" + telephoneTbMu.Text + "', fullname='" + fullnameTbMu.Text + "', password='" + (pass.GetHashCode()).GetHashCode() + "' where userid= '" + dataGridMu.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                    MessageBox.Show("User Edited Successfully!");
                    cmd.ExecuteNonQuery();
                }else
                {
                    SqlCommand cmd = new SqlCommand("update UserTbl set  username='" + usernameTbMu.Text + "', userlevel='" + userlevelCbMu.SelectedItem.ToString() + "', telephone='" + telephoneTbMu.Text + "', fullname='" + fullnameTbMu.Text + "', password='" + ((passwordTbMu.Text).GetHashCode()).GetHashCode() + "' where userid= '" + dataGridMu.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                    MessageBox.Show("User Edited Successfully!");
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                populate();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show("Please ensure the user has an unique name and telephone");
                con.Close();
            }

        }

        private void userlevelCbMu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void excelExport_Click(object sender, EventArgs e)
        {
            if (dataGridMu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridMu.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridMu.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridMu.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridMu.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridMu.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }
    }
}
