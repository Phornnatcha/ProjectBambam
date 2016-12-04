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
    public partial class Form7 : Form
    {
        public bool a, b, c, d;
        DataTable datatable = new DataTable();

        public Form7()
        {
            InitializeComponent();
            DataColumn column1 = new DataColumn();
            DataColumn column2 = new DataColumn();
            DataColumn column3 = new DataColumn();


            column1.ColumnName = "รายการที่ซื้อ";
            column2.ColumnName = "จำนวนที่ซื้อ";
            column3.ColumnName = "จำนวนเงิน";


            datatable.Columns.Add(column1);
            datatable.Columns.Add(column2);
            datatable.Columns.Add(column3);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            try

            { double x = double.Parse(textBox5.Text);
            double n = double.Parse(label8.Text);
            if (x >= n)
            {
                double total = x - n;
                string show = "เงินทอน : " + total.ToString("#.00") + "  บาท ";
                MessageBox.Show(show);
            }
            else if (x < n)
            {
                MessageBox.Show("เงินของคุณไม่พอ");
                return;
            }
            else
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                return;
            }

        }
        catch
            {
                
            }
        }


    private void button1_Click(object sender, EventArgs e)
        {

            double lb1 = 23900;
            double lb2 = 7900;
            double lb3 = 19490;
            double lb4 = 12900;

            double n = 0;

            try
            {
                if (textBox1.Visible == true)
                {

                    n = double.Parse(textBox1.Text);
                    if (n > 100)
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");
                        return;
                    }
                    if (n >= 0)
                    {
                        double sum = n * lb1;
                        label9.Text = sum.ToString("#.00");
                    }
                    else
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                        return;
                    }
                }
                else
                {
                    double sum = 0;
                    label9.Text = sum.ToString("#.00");
                }
            }
            catch
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                return;
            }



            try
            {
                if (textBox2.Visible == true)
                {
                    n = double.Parse(textBox2.Text);
                    if (n > 100)
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");
                        return;
                    }
                    if (n >= 0)
                    {
                        double sum = n * lb2;
                        label10.Text = sum.ToString("#.00");
                    }
                    else
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                        return;
                    }
                }
                else
                {
                    double sum = 0;
                    label10.Text = sum.ToString("#.00");
                }
            }
            catch
            {
               MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
               return;
            }





            try
            {
                if (textBox3.Visible == true)
                {
                    n = double.Parse(textBox3.Text);
                    if (n > 100)
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");
                        return;
                    }
                    if (n >= 0)
                    {
                        double sum = n * lb3;
                        label11.Text = sum.ToString("#.00");
                        
                    }
                    else
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                        return;
                    }

                }
                else
                {
                    double sum = 0;
                    label11.Text = sum.ToString("#.00");
                }
            }
            catch
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                return;
            }



            try
            {
                if (textBox4.Visible == true)
                {
                    n = double.Parse(textBox4.Text);
                    if (n > 100)
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");
                        return;
                    }
                    if (n >= 0)
                    {
                        double sum = n * lb4;
                        label12.Text = sum.ToString("#.00");
                    }
                    else
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                        return;
                    }
                }
                else
                {
                    double sum = 0;
                    label12.Text = sum.ToString("#.00");
                }
            }
            catch
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");
                return;
            }



              double sum1 = double.Parse(label9.Text);
              double sum2 = double.Parse(label10.Text);
              double sum3 = double.Parse(label11.Text);
              double sum4 = double.Parse(label12.Text);

              double total = sum1 + sum2 + sum3 + sum4;
              label8.Text = total.ToString("#.00");

            
            if (label2.Visible == true)     
            {
                DataRow newRow1 = datatable.NewRow();
                newRow1["รายการที่ซื้อ"] = "Galaxy S7";         
                newRow1["จำนวนที่ซื้อ"] = textBox1.Text;       
                newRow1["จำนวนเงิน"] = label9.Text;          
                datatable.Rows.Add(newRow1);              
            }

            if (label3.Visible == true)     
            {
                DataRow newRow2 = datatable.NewRow();
                newRow2["รายการที่ซื้อ"] = "Galaxy J7";         
                newRow2["จำนวนที่ซื้อ"] = textBox2.Text;       
                newRow2["จำนวนเงิน"] = label10.Text;         
                datatable.Rows.Add(newRow2);              
            }

            if (label4.Visible == true)       
            {
                DataRow newRow3 = datatable.NewRow();
                newRow3["รายการที่ซื้อ"] = "Galaxy Note5";        
                newRow3["จำนวนที่ซื้อ"] = textBox3.Text;         
                newRow3["จำนวนเงิน"] = label11.Text;           
                datatable.Rows.Add(newRow3);                
            }

            if (label5.Visible == true)       
            {
                DataRow newRow4 = datatable.NewRow();
                newRow4["รายการที่ซื้อ"] = "Galaxy A7";           
                newRow4["จำนวนที่ซื้อ"] = textBox4.Text;          
                newRow4["จำนวนเงิน"] = label12.Text;           
                datatable.Rows.Add(newRow4);                 

            }

            this.dataGridView1.DataSource = datatable;


        }


        private void Form7_Load(object sender, EventArgs e)
        {
             textBox1.Visible = false;
             textBox2.Visible = false;
             textBox3.Visible = false;
             textBox4.Visible = false;

             label2.Visible = false;
             label3.Visible = false;
             label4.Visible = false;
             label5.Visible = false;
             label9.Visible = false;
             label10.Visible = false;
             label11.Visible = false;
             label12.Visible = false;

             textBox1.Visible = a;
             textBox2.Visible = b;
             textBox3.Visible = c;
             textBox4.Visible = d;

             label2.Visible = a;
             label3.Visible = b;
             label4.Visible = c;
             label5.Visible = d;
             label9.Visible = a;
             label10.Visible = b;
             label11.Visible = c;
             label12.Visible = d;


        }
    }
}
