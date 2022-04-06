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
    public partial class viewOrders : Form
    {
        public viewOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");
        public static int orderid;
        public static string status = "";

        void populateprod()
        {
            try
            {
                con.Open();
                string myquery = "select distinct Orderid, Custid, Orderdate, TotalAmt, Status from OrdersTbl order by Orderid";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Orderdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show("popprod!");
                MessageBox.Show(E.Message);
            }
        }
        void fillcust()
        {
            string query = "select * from CustTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("custname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CustName.ValueMember = "custname";
                CustName.DataSource = dt;
                
                con.Close();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
        }

        void filterbycust()
        {
            try
            {
                con.Open();
                string query = "select * from CustTbl where custname = '" + CustName.SelectedValue.ToString() + "';";
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
                string myquery = "select Orderdate, TotalAmt from OrdersTbl  where Custid='" + id + "' order by Orderid";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Orderdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
        }

        void filterbydate()
        {
            try
            {
                con.Open();
                
                string myquery = "select distinct Orderid, Custid, Orderdate, TotalAmt from OrdersTbl  where Orderdate='" + OrderDate.Text + "' order by Orderid";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Orderdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void viewOrders_Load(object sender, EventArgs e)
        {
            populateprod();
            fillcust();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Orderdgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < Orderdgv.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = Orderdgv.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < Orderdgv.Rows.Count; i++)
                {
                    for (int j = 0; j < Orderdgv.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = Orderdgv.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
        
        private void orderdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderid = Convert.ToInt32(Orderdgv.SelectedRows[0].Cells[0].Value);
            status = Convert.ToString(Orderdgv.SelectedRows[0].Cells[4].Value);
            /*if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();

            }*/
            OrderProducts op = new OrderProducts();
            op.Visible = true;
            
        }

        private void FilterBtn1_Click(object sender, EventArgs e)
        {
            filterbycust();
        }

        private void FilterBtn2_Click(object sender, EventArgs e)
        {
            filterbydate();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populateprod();
        }

        /*private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Californian FB", 45, FontStyle.Bold), Brushes.Red, new Point(220));
            e.Graphics.DrawString("Order Id: "+ Orderdgv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70,150));
            e.Graphics.DrawString("Customer Id: "+ Orderdgv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 190));
            //e.Graphics.DrawString("Customer Name: " + Orderdgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 210));
            e.Graphics.DrawString("Order Date: " + Orderdgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 230));
            e.Graphics.DrawString("Order Total Amount: " + Orderdgv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 270));
            string[] Arr = { "Sl.No.", "ProductName", "Product Qty.", "PricePerUnit", "TotalPrice" };
            int x = 20;
            int g = 1;
            con.Open();
            string myquery = "select * from OrdersTbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable Table = new DataTable();
            da.Fill(Table);
            con.Close();
            foreach (string str in Arr)
            {
                
                e.Graphics.DrawString(str, new Font("Californian FB", 18, FontStyle.Underline), Brushes.SandyBrown, new Point(x, 350));
                if (g == 2)
                {
                    x += 190;
                }
                else
                {
                    x += 150;
                }
                g += 1;
            }
            int j = 365;
            con.Open();
            string query = "select * from Order_prodTbl where orderid = '"+ Orderdgv.SelectedRows[0].Cells[0].Value.ToString()+"'";
            SqlDataAdapter daa = new SqlDataAdapter(query, con);    
            DataTable Table2 = new DataTable();
            daa.Fill(Table2);
            con.Close();          
            foreach (DataRow dr in Table2.Rows)
            {
                int i = 20;
                int gap = 1;
                //MessageBox.Show("Got here!");
                j += 30;
                foreach(var item in dr.ItemArray)
                {
                    if (gap == 4)
                    {
                        con.Open();
                        string squery = "select * from ProdTbl where prodid = '" + Convert.ToInt32(item) + "';";

                        SqlCommand CMD = new SqlCommand(squery, con);
                        SqlDataReader rdr = null;
                        string prodname = "";
                        try
                        {
                            rdr = CMD.ExecuteReader();
                            while (rdr.Read())
                            {
                                prodname = rdr.GetString(1);
                            }
                            rdr.Close();
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show(E.Message);
                            con.Close();
                        }
                        con.Close();
                        string id = prodname;
                        e.Graphics.DrawString(id, new Font("Californian FB", 17, FontStyle.Bold), Brushes.Black, new Point(i, j));
                        i += 190;
                    }
                    else if(gap >= 3) 
                    {
                        e.Graphics.DrawString(item.ToString(), new Font("Californian FB", 17, FontStyle.Bold), Brushes.Black, new Point(i, j));
                        
                        i += 160;
                        
                    }
                    //MessageBox.Show("Got here!");
                    
                    gap += 1;
                }

            }
        }*/
    }
}
   
