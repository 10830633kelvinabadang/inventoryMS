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

namespace IVMS_APP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\IVMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CashierId.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            CashierName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CashierAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CashierPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            CashierPassword.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CashierTbl values(" + CashierId.Text + ",'" + CashierName.Text + "','" + CashierAge.Text + "', '"+CashierPhone.Text+"', '"+CashierPassword+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Added Successfully");

                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CashierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CashierId.Text == "")
                {
                    MessageBox.Show("Select the Cashier to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CashierTbl where CashierId= " + CashierId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Deleted Successfully");

                    Con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CashierId.Text == "" || CashierName.Text == "" || CashierAge.Text == "" || CashierPhone.Text == "" || CashierPassword.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update from CashierTbl set CashierName = '" + CashierName.Text + "',CashierAge ='" + CashierAge.Text + "' , cashierPhone ='"+CashierPhone+"', CashierPassword ='"+CashierPassword+"' where CashierId = " + CashierId + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Updated Successfully");

                    Con.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
