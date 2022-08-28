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
using System.Diagnostics.Eventing.Reader;

namespace IVMS_APP
{
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\IVMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void populate()
        {
            Con.Open();
            string query = "select ProductName,ProductPrice from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
        {
            Con.Open();
            string query = "select * from Bill";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            BillDate.Text = DateTime.Today.Date.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int flag = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProductPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantity.Text = ProdDGV1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if(ProductName.Text == "" || ProductQuantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            } 
            else
            {
                int n = 0, total = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQuantity.Text);
                int Grdtotal = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDVG);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProductName.Text;
                newRow.Cells[2].Value = ProductPrice.Text;
                newRow.Cells[3].Value = ProductQuantity.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProductPrice.Text) * Convert.ToInt32(ProductQuantity.Text);
                ORDERDVG.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                TotAmt.Text = " " + Grdtotal; 

            }



        }

        private void DVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Bill values(" + BillID.Text + ",'" + CashierName.Text + "','" + BillDate.Text + "','" + TotAmt.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");

                Con.Close();
                // populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Amounttb_Click(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ProdDGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILYSUPERMARKET" ,new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(ProdDGV2.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(130,150));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 panlogin= new Form1();
            panlogin.Show();
            
        }
    }
}
