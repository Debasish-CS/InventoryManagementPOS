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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");

        void populatecust()
        {
            try
            {
                con.Open();
                string myquery = "select * from CustTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customerdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show("popcust!");
                MessageBox.Show(E.Message);
            }
        }

        void populateprod()
        {
            try
            {
                con.Open();
                string myquery = "select * from ProdTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show("popprod!");
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
                
                CatSelect.ValueMember = "catname";
                CatSelect.DataSource = dt;

                con.Close();

            }
            catch (Exception E)
            {
                //MessageBox.Show("fillcat!");
                MessageBox.Show(E.Message);
            }
        }
        public static int newqty;

        void updateproduct()
        {
            
            
            newqty = stock - Convert.ToInt32(QuantityTb.Text);
            if (newqty < 0)
            {
                MessageBox.Show("Quantity of Product Exceeded Stock");
            }
            else
            {
                productdgv.SelectedRows[0].Cells[2].Value = newqty;
            }
            
        }
        
        private void Order_Load(object sender, EventArgs e)
        {
            
        }

        int slno = 0;
        double uprice, totalprice;
        int qty;
        string product;
        public static DataTable table = new DataTable();
        //public static DataTable D = new DataTable();
        public static int i = 1;
        private void Order_Load_1(object sender, EventArgs e)
        {
            fillcategory();
            populatecust();
            populateprod();
            if (i == 1) 
                {
                    table.Columns.Add("Num", typeof(int));
                    table.Columns.Add("Product", typeof(string));
                    table.Columns.Add("Quantity", typeof(int));
                    table.Columns.Add("PriceperPiece", typeof(int));
                    table.Columns.Add("TotalPrice", typeof(int));
                    i += 1;
                }
            

            orderdgv.DataSource = table;

            userLvlLabel.Text = LoginForm.userLvl;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToHomeMo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(flag2 == 1)
            {
                MessageBox.Show("You've Added products in Order, Please Insert it before Leaving!");
            }
            else
            {
                Dashboard home = new Dashboard();
                home.Show();
                this.Visible = false;
            }
            
        }

        private void customerdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            custidTb.Text = customerdgv.SelectedRows[0].Cells[0].Value.ToString();
            
        }

        void fillcat()
        {
            try
            {
                con.Open();
                string query = "select * from CatTbl where catname = '" + CatSelect.SelectedValue.ToString() + "';";
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
                string myquery = "select *  from ProdTbl where prodcatid='" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                productdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                
                MessageBox.Show(E.Message);
            }

        }

        int flag = 0;
        int flag2 = 0;
        int stock;
        private void productdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = productdgv.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QuantityTb.Text);
            uprice = Convert.ToDouble(productdgv.SelectedRows[0].Cells[3].Value.ToString());
            //totalprice = qty * uprice;
            stock = Convert.ToInt32(productdgv.SelectedRows[0].Cells[2].Value.ToString());
            flag = 1;


        }

        double sum = 0;
        private void AddToOrderButtonMo_Click(object sender, EventArgs e)
        {
            
            if(QuantityTb.Text == "")
            {
                MessageBox.Show("Please provide Quantity of the product!");
            }
            
            else if(flag == 0)
            {
                MessageBox.Show("Please Select a Product to add!");
            }
            else
            {
               
                slno = slno + 1;
                qty = Convert.ToInt32(QuantityTb.Text);
                totalprice = qty * uprice;
                table.Rows.Add(slno, product, qty, uprice, totalprice);
                orderdgv.DataSource = table;
                sum = sum + totalprice;
                sumamttb.Text = sum.ToString();
                flag = 0;
                flag2 = 1;
                updateproduct();


            }
            

        }

        private void InsertButtonMo_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow dr in productdgv.Rows)
            {
                con.Open();
                int idd = Convert.ToInt32(dr.Cells[0].Value);

                string query4 = "update ProdTbl set prodquantity='" + dr.Cells[2].Value + "' where prodid='" + idd + "';";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                cmd4.ExecuteNonQuery();
                con.Close();
            }
           
            populateprod();
            if ( custidTb.Text == "" || sumamttb.Text == "")
            {
                MessageBox.Show("Fill in all fields Properly!");
            }
            else
            {
                
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into OrdersTbl values('" + custidTb.Text + "','" + orderdate.Text + "','" + sumamttb.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    string myquery = "select * from OrdersTbl";
                    SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                    DataTable Table = new DataTable();
                    da.Fill(Table);

                    con.Close();

                    foreach (DataRow dr in table.Rows)
                    {

                        con.Open();
                        string query = "select * from ProdTbl where prodname = '" + dr.ItemArray[1] + "';";
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
                            con.Close();
                        }
                        int id = myInt;

                        SqlCommand cmd2 = new SqlCommand("insert into Order_prodTbl values('"+Table.Rows[Convert.ToInt32(Table.Rows.Count) -1][0]+"','"+dr.ItemArray[0]+"', '"+id+ "', '" + dr.ItemArray[2] + "', '" + dr.ItemArray[3] + "', '" + dr.ItemArray[4] + "' )", con);
                        cmd2.ExecuteNonQuery();
                        
                        con.Close();
                    }
                    MessageBox.Show(" Order Added Successfully!");
                    QuantityTb.Text = "";
                    sumamttb.Text = "";
                    
                    custidTb.Text = "";
                    
                   //D = table.Copy();
                    table.Clear();
                    flag2 = 0;

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    con.Close();
                }
            }
        }

        private void ViewButtonMo_Click(object sender, EventArgs e)
        {
            viewOrders vo = new viewOrders();
            vo.Visible = true;
            
        }

        private void orderdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            populateprod();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            fillcat();
        }
    }
}
