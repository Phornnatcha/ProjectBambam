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
        public bool a, b, c, d;    // ตัวเรียก ค่า checkbox ข้ามฟอร์ม ให้เชื่อม กับ textbox อีกฟอร์มนึง

        DataTable datatable = new DataTable();  //ตั้งชื่อตัวแปร DataTable ชื่อ datatable

        public Form7()
        {
            InitializeComponent();
            DataColumn column1 = new DataColumn();   // สร้าง DataColumn ให้ชื่อ column1
            DataColumn column2 = new DataColumn();   // สร้าง DataColumn ให้ชื่อ column2
            DataColumn column3 = new DataColumn();   // สร้าง DataColumn ให้ชื่อ column3


            column1.ColumnName = "รายการที่ซื้อ";     // ให้คอลัมน์1 ชื่อ"รายการที่ซื้อ"
            column2.ColumnName = "จำนวนที่ซื้อ";     // ให้คอลัมน์2 ชื่อ "จำนวนที่ซื้อ"
            column3.ColumnName = "จำนวนเงิน";      // ให้คอลัมน์3 ชื่อ "จำนวนเงิน"


            datatable.Columns.Add(column1);    // เพิ่มคอลัมน์ใน datatable ใช้ชื่อว่า column1
            datatable.Columns.Add(column2);    // เพิ่มคอลัมน์ใน datatable ใช้ชื่อว่า column2
            datatable.Columns.Add(column3);    // เพิ่มคอลัมน์ใน datatable ใช้ชื่อว่า column3


        }
        private void button2_Click(object sender, EventArgs e)
        {
            try           //ดักจักไม่ให้ eror

            {
            double x = double.Parse(textBox5.Text);    // รับค่่าจำนวนเงินที่จ่ายจาก textBox5 มาเก็บไว้ใน x
            double n = double.Parse(label8.Text);        // รับค่าจำนวนเงินราคาของจาก label8 มาเก็บไว้ใน n
            if (x >= n)                                  // ในกรณีที่หนึ่ง ที่จำนวนเงินที่จ่ายมากกว่าจำนวนเงินราคาของ
            {
                double total = x - n;                    // จำนวนเงินที่จ่าย ลบ จำนวนเงินราคาของ แล้วเก็บไว้ใน total
                string show = "เงินทอน : " + total.ToString("#.00") + "  บาท ";   // จะขึ้น MessageBox จำนวนเงินทอน เป็นจำนวนเต็มจุดทศนิยม ตามด้วยบาท
                MessageBox.Show(show);
            }
            else if (x < n)                             // ในกรณีที่สอง จำนวนเงินที่จ่ายน้อยกว่าจำนวนเงินราคาของ
            {
                MessageBox.Show("เงินของคุณไม่พอ");         // จะขึ้น MessageBox ว่าเงินของคุณไม่พอ
                    return;          //ทำการวนซ้ำ
                }
            else                                       // ไม่ตรงกับกรณีดังกล่าวที่ว่ามา
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");    // จะขึ้น MessageBox ว่า"คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                    return;           //ทำการวนซ้ำ
                }

        }
            catch             //ดักจักไม่ให้ eror
            {
                
            }
        }


    private void button1_Click(object sender, EventArgs e)
        {

            double lb1 = 23900;           // ราคาโทรศัพท์ซัมซุง S7 = 23900 เก็บไว้ใน lb1
            double lb2 = 7900;            // ราคาโทรศัพท์ซัมซุง J7 = 7900 เก็บไว้ใน lb2
            double lb3 = 19490;           // ราคาโทรศัพท์ซัมซุง Note5 = 19490 เก็บไว้ใน lb3
            double lb4 = 12900;           // ราคาโทรศัพท์ซัมซุง A7 = 12900 เก็บไว้ใน lb4

            double n = 0;                 // ราคาของ = 0

            try                           // ดักจับไม่ให้ eror
            {
                if (textBox1.Visible == true)     // กรณีที่ textBox1 เปิดใช้งาน
                {

                    n = double.Parse(textBox1.Text);    // รับค่าจาก  textBox1 เก็บไว้ใน n
                    if (n > 100)                        // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 1oo เครื่อง
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");    //จะขึ้น MessageBox ว่า "ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น"
                        return;         //ทำการวนซ้ำ
                    }
                    if (n >= 0)                        // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 0 เครื่อง
                    {
                        double sum = n * lb1;          // จำนวนเครื่อง คูณ ราคาของ เก็บไว้ใน sum
                        label9.Text = sum.ToString("#.00");      // แสดงผลใน label9
                    }
                    else                               // ไม่ตรงกับกรณีทั้งสองที่ผ่านมา
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");    // จะขึ้น MessageBox ว่า "คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                        return;            //ทำการวนซ้ำ
                    }
                }
                else
                {
                    double sum = 0;
                    label9.Text = sum.ToString("#.00");      // ผลรวม sum แสดงผลใน label9 เป็นจำนวนเต็มจุดทศนิยม
                }
            }
            catch             //ดักจักไม่ให้ eror
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");      //ถ้าใส่ข้อความลงไปที่ทำให้ eror จะ MessageBox แสดงคำว่า"คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                return;             //ทำการวนซ้ำ
            }



            try             //ดักจักไม่ให้ eror
            {
                if (textBox2.Visible == true)           // กรณีที่ textBox2 เปิดใช้งาน
                {
                    n = double.Parse(textBox2.Text);    // รับค่าจาก  textBox2 เก็บไว้ใน n
                    if (n > 100)                         // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 1oo เครื่อง
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");     //จะขึ้น MessageBox ว่า "ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น"
                        return;       //ทำการวนซ้ำ
                    }
                    if (n >= 0)                       // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 0 เครื่อง
                    {
                        double sum = n * lb2;         // จำนวนเครื่อง คูณ ราคาของ เก็บไว้ใน sum
                        label10.Text = sum.ToString("#.00");        // แสดงผลใน label9
                    }
                    else                              // ไม่ตรงกับกรณีทั้งสองที่ผ่านมา
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");         // จะขึ้น MessageBox ว่า "คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                        return;        //ทำการวนซ้ำ
                    }
                }
                else
                {
                    double sum = 0;
                    label10.Text = sum.ToString("#.00");          // ผลรวม sum แสดงผลใน label9 เป็นจำนวนเต็มจุดทศนิยม
                }
            }
            catch              //ดักจักไม่ให้ eror
            {
               MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");      //ถ้าใส่ข้อความลงไปที่ทำให้ eror จะ MessageBox แสดงคำว่า"คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                return;               //ทำการวนซ้ำ
            }





            try             //ดักจักไม่ให้ eror
            {
                if (textBox3.Visible == true)          // กรณีที่ textBox3 เปิดใช้งาน
                {
                    n = double.Parse(textBox3.Text);    // รับค่าจาก  textBox3 เก็บไว้ใน n
                    if (n > 100)                         // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 1oo เครื่อง
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");    //จะขึ้น MessageBox ว่า "ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น"
                        return;              //ทำการวนซ้ำ
                    } 
                    if (n >= 0)                      // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 0 เครื่อง
                    {
                        double sum = n * lb3;         // จำนวนเครื่อง คูณ ราคาของ เก็บไว้ใน sum
                        label11.Text = sum.ToString("#.00");       // แสดงผลใน label9

                    }
                    else                             // ไม่ตรงกับกรณีทั้งสองที่ผ่านมา
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");      // จะขึ้น MessageBox ว่า "คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                        return;              //ทำการวนซ้ำ
                    }

                }
                else
                {
                    double sum = 0;
                    label11.Text = sum.ToString("#.00");             // ผลรวม sum แสดงผลใน label9 เป็นจำนวนเต็มจุดทศนิยม
                }
            }
            catch                   //ดักจักไม่ให้ eror
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");      //ถ้าใส่ข้อความลงไปที่ทำให้ eror จะ MessageBox แสดงคำว่า"คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                return;        //ทำการวนซ้ำ
            }



            try              //ดักจักไม่ให้ eror
            {
                if (textBox4.Visible == true)         // กรณีที่ textBox4 เปิดใช้งาน
                {
                    n = double.Parse(textBox4.Text);     // รับค่าจาก  textBox4 เก็บไว้ใน n
                    if (n > 100)                          // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 1oo เครื่อง
                    {
                        MessageBox.Show("ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น");     //จะขึ้น MessageBox ว่า "ทางร้านจำกัดการซื้อมือถือรุ่นละ 100 เครื่องต่อครั้งเท่านั้น"
                        return;          //ทำการวนซ้ำ
                    }
                    if (n >= 0)                   // ในกรณีที่ จำนวนเครื่องที่ซื้อมากกว่า 0 เครื่อง
                    {
                        double sum = n * lb4;        // จำนวนเครื่อง คูณ ราคาของ เก็บไว้ใน sum
                        label12.Text = sum.ToString("#.00");       // แสดงผลใน label9
                    }
                    else                         // ไม่ตรงกับกรณีทั้งสองที่ผ่านมา
                    {
                        MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");    // จะขึ้น MessageBox ว่า "คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                        return;         //ทำการวนซ้ำ
                    }
                }
                else
                {
                    double sum = 0;                                        
                    label12.Text = sum.ToString("#.00");                // ผลรวม sum แสดงผลใน label9 เป็นจำนวนเต็มจุดทศนิยม
                }
            }
            catch                                                          //ดักจักไม่ให้ eror
            {
                MessageBox.Show("คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง");        // ถ้าใส่ข้อความลงไปที่ทำให้ eror จะ MessageBox แสดงคำว่า"คุณทำรายการไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง"
                return;           //ทำการวนซ้ำ
            }



              double sum1 = double.Parse(label9.Text);          // ผลรวมใน sum1 จะแสดงผลใน label9
              double sum2 = double.Parse(label10.Text);         // ผลรวมใน sum2 จะแสดงผลใน label10
              double sum3 = double.Parse(label11.Text);         // ผลรวมใน sum3 จะแสดงผลใน label11
              double sum4 = double.Parse(label12.Text);         // ผลรวมใน sum4 จะแสดงผลใน labe12

              double total = sum1 + sum2 + sum3 + sum4;          // sum1 + sum2 + sum3 + sum4 จะแสดงผลเเล้วเก็บไว้ใน total
              label8.Text = total.ToString("#.00");              // total รับค่ามาแสดงผลใน label8เป็นจำนวนเต็มจุดทศนิยม

            
            if (label2.Visible == true)                     // ถ้า label2 เป็นจริง
            {
                DataRow newRow1 = datatable.NewRow();       // เพิ่ม data newrow ใหม่ ชื่อ Data newrow1
                newRow1["รายการที่ซื้อ"] = "Galaxy S7";          // ให้ newrow1 รายการที่ซื้อ คือ "Galaxy S7"
                newRow1["จำนวนที่ซื้อ"] = textBox1.Text;        // ให้ newrow1 จำนวนที่ซื้อ รับค่ามาจาก textbox1
                newRow1["จำนวนเงิน"] = label9.Text;           // ให้ newrow1 จำนวนเงิน รับค่ามาจาก label9
                datatable.Rows.Add(newRow1);                //เพิ่มคอลัมน์ใน newrow1   

            }

            if (label3.Visible == true)                   // ถ้า label3 เป็นจริง
            {
                DataRow newRow2 = datatable.NewRow();      // เพิ่ม data newrow ใหม่ ชื่อ Data newrow2
                newRow2["รายการที่ซื้อ"] = "Galaxy J7";         // ให้ newrow2 รายการที่ซื้อ คือ "Galaxy J7"
                newRow2["จำนวนที่ซื้อ"] = textBox2.Text;       // ให้ newrow2 จำนวนที่ซื้อ รับค่ามาจาก textBox2
                newRow2["จำนวนเงิน"] = label10.Text;         // ให้ newrow2 จำนวนเงิน รับค่ามาจาก label10
                datatable.Rows.Add(newRow2);              // เพิ่มคอลัมน์ใน newrow2  

            }

            if (label4.Visible == true)               // ถ้า label4 เป็นจริง
            {
                DataRow newRow3 = datatable.NewRow();        // เพิ่ม data newrow ใหม่ ชื่อ Data newrow3
                newRow3["รายการที่ซื้อ"] = "Galaxy Note5";        // ให้ newrow3 รายการที่ซื้อ คือ "Galaxy Note 5"
                newRow3["จำนวนที่ซื้อ"] = textBox3.Text;         // ให้ newrow3 จำนวนที่ซื้อ รับค่ามาจาก textBox3
                newRow3["จำนวนเงิน"] = label11.Text;           // ให้ newrow3 จำนวนเงิน รับค่ามาจาก label11
                datatable.Rows.Add(newRow3);                // เพิ่มคอลัมน์ใน newrow3  

            }

            if (label5.Visible == true)                   // ถ้า label5 เป็นจริง
            {
                DataRow newRow4 = datatable.NewRow();     // เพิ่ม data newrow ใหม่ ชื่อ Data newrow4
                newRow4["รายการที่ซื้อ"] = "Galaxy A7";        // ให้ newrow4 รายการที่ซื้อ คือ "Galaxy A7"
                newRow4["จำนวนที่ซื้อ"] = textBox4.Text;      //  ให้ newrow4 จำนวนที่ซื้อ รับค่ามาจาก textBox4
                newRow4["จำนวนเงิน"] = label12.Text;        //  ให้ newrow4 จำนวนเงิน รับค่ามาจาก label12
                datatable.Rows.Add(newRow4);              //เพิ่มคอลัมน์ใน newrow4   

            }

            this.dataGridView1.DataSource = datatable;   // ใส่ข้อมูล datatable ลงใน  gridview


        }


        private void Form7_Load(object sender, EventArgs e)
        {
             textBox1.Visible = false;      // ปิดการแสดงของtextbox1
            textBox2.Visible = false;       // ปิดการแสดงของtextbox2
            textBox3.Visible = false;       // ปิดการแสดงของtextbox3
            textBox4.Visible = false;       // ปิดการแสดงของtextbox4

            label2.Visible = false;       //ปิดการแสดงของ label2            
            label3.Visible = false;        //ปิดการแสดงของ label3
            label4.Visible = false;        //ปิดการแสดงของ label4
            label5.Visible = false;        //ปิดการแสดงของ label5
            label9.Visible = false;        //ปิดการแสดงของ label9
            label10.Visible = false;       //ปิดการแสดงของ label10
            label11.Visible = false;       //ปิดการแสดงของ label11
            label12.Visible = false;       //ปิดการแสดงของ label12

            textBox1.Visible = a;          // ส่งค่า bool หรือ ถูก/ผิด ไปที่ textbox1 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            textBox2.Visible = b;         // ส่งค่า bool หรือ ถูก/ผิด ไปที่ textbox2 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            textBox3.Visible = c;         // ส่งค่า bool หรือ ถูก/ผิด ไปที่ textbox3 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            textBox4.Visible = d;         // ส่งค่า bool หรือ ถูก/ผิด ไปที่ textbox4 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด

            label2.Visible = a;           // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label2 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
             label3.Visible = b;           // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label3 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label4.Visible = c;           // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label4 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label5.Visible = d;           // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label5 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label9.Visible = a;           // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label9 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label10.Visible = b;          // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label10 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label11.Visible = c;          // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label11 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด
            label12.Visible = d;          // ส่งค่า bool หรือ ถูก/ผิด ไปที่ label12 ถ้าถูกจะเปิด ถ้าผิดจะไม่เปิด


        }
    }
}
