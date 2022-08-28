using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVMS_APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            if(progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

      

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
