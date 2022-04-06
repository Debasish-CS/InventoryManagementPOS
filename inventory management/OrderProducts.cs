using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace inventory_management
{
    public partial class OrderProducts : Form
    {
        public OrderProducts()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ARS\Documents\inventorytb.mdf;Integrated Security=True;Connect Timeout=30");
        public static int id;
        void populateOrderProducts()
        {
            try
            {
                con.Open();
                string myquery = "select num, prodid, qty, prodperpiece, totalamt  from Order_prodTbl where orderid = '"+viewOrders.orderid+"'";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderProductsdgv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception E)
            {
                //MessageBox.Show("popprod!");
                MessageBox.Show(E.Message);
            }
        }
        private void OrderProducts_Load(object sender, EventArgs e)
        {
            Status.Text = viewOrders.status;
            if (Status.Text == "Paid")
            {
                Status.ForeColor = Color.Green;
            }
            else
            {
                Status.ForeColor = Color.Red;
            }
            OrderId.Text = "OrderId : " + Convert.ToString(viewOrders.orderid);
            con.Open();
            string squery = "select * from OrdersTbl where Orderid = '" +viewOrders.orderid + "';";

            SqlCommand CMD = new SqlCommand(squery, con);
            SqlDataReader rdr = null;
            int custid = 0;
            try
            {
                rdr = CMD.ExecuteReader();
                while (rdr.Read())
                {
                    custid = rdr.GetInt32(1);
                }
                rdr.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
            con.Close();
            id = custid;
            CustId.Text = "Customer Id: " + Convert.ToString(id);
            populateOrderProducts();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(Status.Text == "Paid") 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update OrdersTbl set Status='" + Status.Text + "' where Orderid='" + viewOrders.orderid + "';", con);
                MessageBox.Show("Order Paid");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
            this.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (OrderProductsdgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                xcelApp.Cells[1, 1] = OrderId.Text;
                xcelApp.Cells[2, 1] = CustId.Text;

                for (int i = 1; i < OrderProductsdgv.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[3, i] = OrderProductsdgv.Columns[i - 1].HeaderText;

                }

                for (int i = 0; i < OrderProductsdgv.Rows.Count; i++)
                {
                    for (int j = 0; j < OrderProductsdgv.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 4, j + 1] = OrderProductsdgv.Rows[i].Cells[j].Value.ToString();

                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;

            }
        }

        private void OrderProductsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public static string prodname;
        public static string ProdName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new System.Drawing.Font("Californian FB", 25, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(120));
            e.Graphics.DrawString(OrderId.Text, new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 50));
            e.Graphics.DrawString(CustId.Text, new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 90));
            //e.Graphics.DrawString("Customer Name: " + Orderdgv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Cambria", 20, FontStyle.Regular), Brushes.Green, new Point(70, 210));
            
                con.Open();
            string squery = "select * from OrdersTbl where Orderid = '" + viewOrders.orderid + "';";

            SqlCommand CMD = new SqlCommand(squery, con);
            SqlDataReader rdr = null;
            string orderdate = "";
            string totalamt = "";
            try
            {

                rdr = CMD.ExecuteReader();
                while (rdr.Read())
                {
                    orderdate = Convert.ToString(rdr.GetDateTime(2));
                    totalamt = Convert.ToString(rdr.GetValue(3));
                }
                con.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                con.Close();
            }
            con.Close();
            string id1 = orderdate;
            string id2 = totalamt;
            e.Graphics.DrawString("Order Date: " + id1 , new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 130));
            e.Graphics.DrawString("Order Total Amount: " +id2 , new System.Drawing.Font("Cambria", 10, FontStyle.Regular), Brushes.Green, new System.Drawing.Point(70, 170));
            string[] Arr = { "Sl.No.", "ProductName", "Product Qty.", "PricePerUnit", "TotalPrice" };
            int x = 6;
            int g = 1;
            con.Open();
            string myquery = "select * from OrdersTbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            System.Data.DataTable Table = new System.Data.DataTable();
            da.Fill(Table);
            con.Close();
            foreach (string str in Arr)
            {

                e.Graphics.DrawString(str, new System.Drawing.Font("Californian FB", 8, FontStyle.Underline), Brushes.SandyBrown, new System.Drawing.Point(x, 220));
                if (g == 2)
                {
                    x += 140;
                }
                else
                {
                    x += 100;
                }
                g += 1;
            }
            int j = 235;
            con.Open();
            string query = "select * from Order_prodTbl where orderid = '" + viewOrders.orderid + "'";
            SqlDataAdapter daa = new SqlDataAdapter(query, con);
            System.Data.DataTable Table2 = new System.Data.DataTable();
            daa.Fill(Table2);
            con.Close();
            foreach (DataRow dr in Table2.Rows)
            {
                int i = 20;
                int gap = 1;
                //MessageBox.Show("Got here!");
                j += 30;
                foreach (var item in dr.ItemArray)
                {
                    if (gap == 4)
                    {
                        con.Open();
                        string Query = "select * from ProdTbl where prodid = '" + Convert.ToInt32(item) + "';";

                        SqlCommand Cmd = new SqlCommand(Query, con);
                        SqlDataReader reader = null;
                        
                        try
                        {
                            reader = Cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                prodname = reader.GetString(1);
                            }
                            reader.Close();
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show(E.Message);
                            con.Close();
                        }
                        con.Close();
                        ProdName = prodname;
                        e.Graphics.DrawString(ProdName, new System.Drawing.Font("Californian FB", 7, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(i, j));
                        i += 140;
                    }
                    else if (gap >= 3)
                    {
                        e.Graphics.DrawString(item.ToString(), new System.Drawing.Font("Californian FB", 7, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(i, j));

                        i += 100;

                    }
                    //MessageBox.Show("Got here!");

                    gap += 1;
                }

            }
        }

        private void PrintPreview_Click(object sender, EventArgs e)
        {
            Status.Text = "Paid";
            Status.ForeColor = Color.Green;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void GenerateBarcodes_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in OrderProductsdgv.Rows)
            {
                string prn1 = @"
^Q25,3
^W80
^H8
^P1
^S4
^AT
^C1
^R160
~Q+0
^O0
^D0
^E18
~R255
^L
Dy2-me-dd
Th:m:s
AA,164,10,1,1,0,0E,OrderId:
AA,162,40,1,1,0,0E,CustId: 
AA,168,70,1,1,0,0E,ProdId: 
AA,164,102,1,1,0,0E,ProdName:";
                con.Open();
                string Query = "select * from ProdTbl where prodid = '" + Convert.ToInt32(dr.Cells[1].Value) + "';";

                SqlCommand Cmd = new SqlCommand(Query, con);
                SqlDataReader reader = null;

                try
                {
                    reader = Cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        prodname = reader.GetString(1);
                    }
                    reader.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    con.Close();
                }
                con.Close();
                ProdName = prodname;
                string productname = ProdName;

                string prn2 = @"
R152,0,389,99,1,1
Lo,152,32,389,32
Lo,152,66,389,66
Lo,270,0,270,99

B050,148,122,2,5,34,0,1,1,";
                //Barcodepos
                string prn3 = @"
AA,294,6,1,1,0,0E,Qty: 
AA,354,8,1,1,0,0E,";
                string Qty = dr.Cells[2].Value.ToString();
                string prn4 = @"
AA,278,74,1,1,0,0E,TotalAmt:
AA,226,38,1,1,0,0E,";
                string CustomerId = id.ToString();
                string prn5 = @"
AA,228,8,1,1,0,0E,";
                string orderId = viewOrders.orderid.ToString();
                string prn6 = @"
AA,228,70,1,1,0,0E,";
                string productId = dr.Cells[1].Value.ToString();
                string prn7 = @"
AA,274,38,1,1,0,0E,Price/Unit:
AA,352,38,1,1,0,0E,";
                string priceu = dr.Cells[3].Value.ToString();
                string prn8 = @"
AA,354,76,1,1,0,0E,";
                string Total = dr.Cells[4].Value.ToString();
                MessageBox.Show("Printing...");
                string prn9 = @"
E";

                string barcode = (orderId + CustomerId + productId).PadLeft(11,'0');
                string finalPRN = prn1 + productname + prn2 + barcode + prn3 + Qty + prn4 + CustomerId + prn5 + orderId + prn6 + productId + prn7 + priceu + prn8 + Total + prn9;
                StreamWriter sw = new StreamWriter("C:\\Users\\ARS\\Desktop\\sample.txt");
                sw.Write(finalPRN);
                sw.Close();


                /*var processStartInfo = new ProcessStartInfo();
                processStartInfo.WorkingDirectory = Windows.Storage.ApplicationData.Current.LocalFolder.ToString();*/
                Process process1 = new Process();
                process1.StartInfo.FileName = "cmd.exe";
                process1.StartInfo.Arguments = "/C Type C:\\Users\\ARS\\Desktop\\sample.txt>\\\\Desktop\\Godex";
                Process proc = Process.Start(process1.StartInfo);
            }
            Status.Text = "Paid";
            Status.ForeColor = Color.Green;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
