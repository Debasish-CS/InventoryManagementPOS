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
                string myquery = "select custid, custname, custphoneno, custaddress  from CustTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridMC.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void BackToHomeLinkMc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void CustomerPhoneNoMc_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButtonMc_Click(object sender, EventArgs e)
        {
            if(CustomerNameMc.Text == "" || CustomerPhoneNoMc.Text == "" || CustomerAddressMc.Text== "")
            {
                MessageBox.Show("Please fill all fields!");
            }
            else {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustTbl values('" + CustomerNameMc.Text + "','" + CustomerPhoneNoMc.Text + "','" + CustomerAddressMc.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Customer Added Successfully!");

                    con.Close();
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the Customer name and Customer no.are unique");
                    con.Close();
                }
            }
            

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();

            userLvlLabel.Text = LoginForm.userLvl;

        }

        private void DeleteButtonMc_Click(object sender, EventArgs e)
        {
            try
            {

                if (CustomerNameMc.Text == "")
                {
                    MessageBox.Show("Please provide Customer!");
                }
                else
                {
                    con.Open();
                    string myquery = "delete from CustTbl where custid = '" + dataGridMC.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully!");
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

        private void dataGridMC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerNameMc.Text = dataGridMC.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneNoMc.Text = dataGridMC.SelectedRows[0].Cells[2].Value.ToString();
            CustomerAddressMc.Text = dataGridMC.SelectedRows[0].Cells[3].Value.ToString();
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrdersTbl where Custid='" + dataGridMC.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            orders.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmt) from OrdersTbl where Custid='" + dataGridMC.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            amount.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(Orderdate) from OrdersTbl where Custid='" + dataGridMC.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            date.Text = dt2.Rows[0][0].ToString();

            con.Close();
        }

        private void EditButtonMc_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update CustTbl set custname='" + CustomerNameMc.Text + "', custphoneno= '" + CustomerPhoneNoMc.Text + "', custaddress ='" + CustomerAddressMc.Text + "' where custid='"+ dataGridMC.SelectedRows[0].Cells[0].Value.ToString() +"';", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Edited Successfully!");

                con.Close();
                populate();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }

        }

        private void excelExport_Click(object sender, EventArgs e)
        {
            if (dataGridMC.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridMC.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridMC.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridMC.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridMC.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridMC.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }
    }
}
