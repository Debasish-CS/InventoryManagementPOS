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
    public partial class Customers : Form
    {
        public Customers()
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
                string MYquery = "select customerid, customername,customerno,customeraddress from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MYquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                datagridviewmc.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
        }
        private void BackToHomeLinkMc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void AddButtonMc_Click(object sender, EventArgs e)
        {
            try
            {
                if (  CustomerNameMc.Text == "" || CustomerPhoneNoMc.Text == "" || CustomerAddressMc.Text == "")
                {
                    MessageBox.Show(" Fill all the fields");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(customername, customerno, customeraddress) values('" + CustomerNameMc.Text + "','" + CustomerPhoneNoMc.Text + "','" + CustomerAddressMc.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    con.Close();
                }
                populate();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show("Please ensure if Customer Name and Customer phone number are unique!");
                con.Close();
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
            label10.Text = LoginForm.Userlvl;
        }

        private void DeleteButtonMc_Click(object sender, EventArgs e)
        {
            if (CustomerNameMc.Text == "")
            {
                MessageBox.Show("Please Select a Customer!");

            }
            else
            {
                con.Open();
                string myquery = "delete from CustomerTbl where customerid='" + datagridviewmc.SelectedRows[0].Cells[0].Value.ToString() + "'; ";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                con.Close();
                populate();
            }
        }

        private void EditButtonMc_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set customername='" + CustomerNameMc.Text + "',customerno='" + CustomerPhoneNoMc.Text + "',customeraddress='" + CustomerAddressMc.Text + "' where customerid = '" + datagridviewmc.SelectedRows[0].Cells[0].Value.ToString() + "';" ,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                con.Close();
                populate();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show("Please ensure if Customer Name and Customer phone number are unique!");
                con.Close();
            }


        }

        private void datagridviewmc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerNameMc.Text = datagridviewmc.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneNoMc.Text = datagridviewmc.SelectedRows[0].Cells[2].Value.ToString();
            CustomerAddressMc.Text = datagridviewmc.SelectedRows[0].Cells[3].Value.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where Custid = '" + datagridviewmc.SelectedRows[0].Cells[0].Value.ToString() + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmt) from OrderTbl where Custid = '" + datagridviewmc.SelectedRows[0].Cells[0].Value.ToString() + "' ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl where Custid = '" + datagridviewmc.SelectedRows[0].Cells[0].Value.ToString() + "' ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            con.Close();
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (datagridviewmc.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < datagridviewmc.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = datagridviewmc.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < datagridviewmc.Rows.Count; i++)
                {
                    for (int j = 0; j < datagridviewmc.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = datagridviewmc.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}   

