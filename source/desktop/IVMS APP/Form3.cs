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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\IVMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillcomb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from Categories", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();  
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            ProductCat.ValueMember = "CatName";
            ProductCat.DataSource = dt;
            Con.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            fillcomb(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Product values(" + ProductID.Text + ",'" + ProductName.Text + "','" + ProductQuantity.Text + "','" + ProductPrice.Text+ "', '"+ProductCat.SelectedValue.ToString()+ "','"+ProductExpiry.Value.Date+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Products Added Successfully");

                Con.Close();
               // populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Cat = new Form5();
            Cat.Show();
            this.Hide();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductID.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantity.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            ProductCat.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductID.Text == "")
                {
                    MessageBox.Show("Select the Products to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Product where ProductID = " + ProductID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");

                    Con.Close();
                   // populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductID.Text == "" || ProductName.Text == "" || ProductQuantity.Text == "" || ProductPrice.Text== "" || ProductCat.SelectedValue =="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update from Product set ProductName = '" + ProductName.Text + "',ProductQuantity ='" + ProductQuantity.Text + "',ProductPrice ='"+ProductPrice.Text+"', ProductCat= '"+ProductCat.SelectedValue+"', ProductExpiry ='"+ProductExpiry.Value.Date+"' where ProductID = " + ProductID + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Products Updated Successfully");

                    Con.Close();
                    //populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
