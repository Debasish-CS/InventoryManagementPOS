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
    public partial class supplier : Form
    {
        public supplier()
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
                string myquery = "select supplierid, suppliername, supplierphoneno, supplieraddress  from SuppTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridMs.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Dashboard home = new Dashboard();
            home.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (SupplierNameTbMs.Text == "" || SupplierPhoneNoTbMs.Text == "" || SupplierAddressTbMs.Text == "")
           {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SuppTbl values('" + SupplierNameTbMs.Text + "','" + SupplierPhoneNoTbMs.Text + "','" + SupplierAddressTbMs.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Supplier Added Successfully!");
                    con.Close();
                    populate();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    MessageBox.Show("Please ensure if the supplier name and supplier no. are unique");
                    con.Close();
                }
            }


        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
        }

       

        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridMs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SupplierNameTbMs.Text = dataGridMs.SelectedRows[0].Cells[1].Value.ToString();
            SupplierPhoneNoTbMs.Text = dataGridMs.SelectedRows[0].Cells[2].Value.ToString();
           SupplierAddressTbMs.Text = dataGridMs.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            populate();

            userLvlLabel.Text = LoginForm.userLvl;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update SuppTbl set suppliername='" + SupplierNameTbMs.Text + "', supplierphoneno= '" + SupplierPhoneNoTbMs.Text + "', supplieraddress ='" + SupplierAddressTbMs.Text + "' where supplierid='" + dataGridMs.SelectedRows[0].Cells[0].Value.ToString() + "';", con);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Edited Successfully!");
                con.Close();
                populate();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (SupplierNameTbMs.Text == "")
                {
                    MessageBox.Show("Please select a Supplier !");
                }
                else
                {
                    con.Open();
                    string myquery = "delete from SuppTbl where supplierid = '" + dataGridMs.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(myquery, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Deleted Successfully!");
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

        private void excelExport_Click(object sender, EventArgs e)
        {
            if (dataGridMs.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridMs.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridMs.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < dataGridMs.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridMs.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridMs.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }
    }
}
