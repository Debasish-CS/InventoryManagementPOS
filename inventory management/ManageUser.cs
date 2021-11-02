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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEBASISH\Documents\Inventory_Manage_user.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void populate()
        {
            try
            {
                con.Open();
                if(LoginForm.Userlvl == "admin")
                {
                    string MYquery = "select userid,username,userlevel,telephone from UserTbl";
                    SqlDataAdapter da = new SqlDataAdapter(MYquery, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewmu.DataSource = ds.Tables[0];
                    Userlevelmu.Visible = true;
                }
                else
                {
                    string MYquery = "select userid,username,userlevel,telephone from UserTbl where username = '"+ LoginForm.Username +"'";
                    SqlDataAdapter da = new SqlDataAdapter(MYquery, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dataGridViewmu.DataSource = ds.Tables[0];
                    Usernamemu.ReadOnly = true;
                    Userlevelmu.Visible = false;
                }
                
                con.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populate();
            label10.Text = LoginForm.Userlvl;
        }
        private void passwordMu_TextChanged(object sender, EventArgs e)
        {
            
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(LoginForm.Userlvl == "staff")
            {
                MessageBox.Show("You are not authorise to add user ");
            }
            else
            {
                try
                {
                    if (Usernamemu.Text == "" || Fullnamemu.Text == "" || Userlevelmu.SelectedItem.ToString() == "" || passwordMu.Text == "" || Telephonemu.Text == "")
                    {
                        MessageBox.Show(" Fill all the fields");
                    }
                    else
                    {
                        con.Open();
                        string pass = passwordMu.Text;
                        SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + Usernamemu.Text + "','" + Fullnamemu.Text + "','" + Userlevelmu.SelectedItem.ToString() + "','" + (pass.GetHashCode()).GetHashCode() + "','" + Telephonemu.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Successfully Added");
                        con.Close();
                    }
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure the User Id and Telephone no. are unique!");
                    con.Close();

                }
            }
            
        }

        private void dataGridViewmu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        { 
            if(LoginForm.Userlvl == "staff")
            {
                MessageBox.Show("You are not authorised to delete your own Account.\n Please ask the admin to do so.");
            }
            else
            {
                try
                {


                    if (Usernamemu.Text == "")
                    {
                        MessageBox.Show("Enter select the user ");

                    }
                    else
                    {
                        con.Open();
                        string myquery = "delete from UserTbl where userid='" + dataGridViewmu.SelectedRows[0].Cells[0].Value.ToString() + "'; ";
                        SqlCommand cmd = new SqlCommand(myquery, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Successfully Deleted");
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

        private void dataGridViewmu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            Usernamemu.Text = dataGridViewmu.SelectedRows[0].Cells[1].Value.ToString();
            Userlevelmu.SelectedItem = dataGridViewmu.SelectedRows[0].Cells[2].Value.ToString();
            Telephonemu.Text = dataGridViewmu.SelectedRows[0].Cells[3].Value.ToString();
            Fullnamemu.Text = "";
            passwordMu.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (Fullnamemu.Text == "" && passwordMu.Text == "")
                {
                    string pass = "1234";
                    SqlCommand cmd = new SqlCommand("update UserTbl set username='"+Usernamemu.Text+"',fullname='"+Usernamemu.Text+"',userlevel='"+Userlevelmu.SelectedItem.ToString()+"',password='" +(pass.GetHashCode()).GetHashCode()+"', telephone='"+Telephonemu.Text+"' where userid='"+ dataGridViewmu.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");

                }
                else if(Fullnamemu.Text == "" && passwordMu.Text != "")
                {
                    string pass = passwordMu.Text;
                    SqlCommand cmd = new SqlCommand("update UserTbl set username='" + Usernamemu.Text + "',fullname='" + Usernamemu.Text + "',userlevel='" + Userlevelmu.SelectedItem.ToString() + "',password='" + (pass.GetHashCode()).GetHashCode() + "', telephone='" + Telephonemu.Text + "' where userid='" + dataGridViewmu.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                }
                else if(passwordMu.Text =="" && Fullnamemu.Text != "")
                {
                    string pass = "1234";
                    SqlCommand cmd = new SqlCommand("update UserTbl set username='" + Usernamemu.Text + "',fullname='" + Fullnamemu.Text + "',userlevel='" + Userlevelmu.SelectedItem.ToString() + "',password='" + (pass.GetHashCode()).GetHashCode() + "', telephone='" + Telephonemu.Text + "' where userid='" + dataGridViewmu.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                }
                else
                {
                    string pass = passwordMu.Text;
                    SqlCommand cmd = new SqlCommand("update UserTbl set username='" + Usernamemu.Text + "',fullname='" + Fullnamemu.Text + "',userlevel='" + Userlevelmu.SelectedItem.ToString() + "',password='" + (pass.GetHashCode()).GetHashCode() + "', telephone='" + Telephonemu.Text + "' where userid='" + dataGridViewmu.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                }
                con.Close();
                populate();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show("Please ensure the user has an unique name and telephone");
                con.Close();
            }
        }

        private void Telephonemu_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewmu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridViewmu.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridViewmu.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewmu.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewmu.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridViewmu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
