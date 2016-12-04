using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 s7 = new Form3();            
            s7.Show();          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 j7 = new Form4();
            j7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 note5 = new Form5();
            note5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 a7 = new Form6();
            a7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 cashform = new Form7();
            cashform.a = checkBox1.Checked;
            cashform.b = checkBox2.Checked;
            cashform.c = checkBox3.Checked;
            cashform.d = checkBox4.Checked;
            cashform.ShowDialog();
        }

       

        
    }
}
