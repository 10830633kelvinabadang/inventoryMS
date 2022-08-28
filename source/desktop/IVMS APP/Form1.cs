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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\IVMSdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if(Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter The Username and Password");

            }
            else
            {
                if(Role.SelectedItem.ToString() =="ADMIN")
                {
                    if (Username.Text == "Admin" && Password.Text == "Admin")
                    {
                        Form3 Prod = new Form3();
                        Prod.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("If You are the Admin, Enter the Correct Id and Password");
                    }
                } else if(Role.SelectedItem.ToString() == "CASHIER")

                {

                    //MessageBox.Show("You are a Cashier");
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from CashierTbl where CashierName='"+Username.Text+"'and CashierPassword='"+Password.Text+"'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Form5 sell  = new Form5();
                        sell.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
                Con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
