using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string std = ( "คำตอบที่คุณเลือก คือ : "+Environment .NewLine) ;
            std = std + "คุณใช้บริการคาเฟ่อะเมซอน บ่อยเพียงใด : ";
            
            if (radioButton1.Checked == true )
            {
                std =std + "ทุกวัน" + Environment.NewLine;
            }
            else if (radioButton2.Checked == true)
            {
                std =std + "อาทิตย์ละ 2-3 ครั้ง" + Environment.NewLine;
            }
            else if (radioButton3.Checked == true)
            {
                std = std + "เดือนละ 2-3 ครั้ง" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {

                std = std +"เดือนละครั้ง" + Environment.NewLine;
            }
            else
            {
                std =std+ "ไม่แน่นอน" + Environment.NewLine;
            }
            std = std + "คุณทราบข่าวโปรโมชั่นหรือสินค้าใหม่ๆของคาเฟ่ อะเมซอนจากที่ใด : ";
            if (radioButton6.Checked == true)
            {
                std = std + "TV / วิทยุ"+Environment .NewLine ;
            }
            else if (radioButton7.Checked == true)
            {
                std = std + "Magazine / สื่อโฆษณา" + Environment.NewLine;
            }
            else if (radioButton8.Checked == true)
            {
                std = std + "สถานีน้ำมัน ปตท"+ Environment .NewLine ;
            }
            else if (radioButton9.Checked == true)
            {
                std = std + "ครอบครัว / เพื่อนฝูง" + Environment.NewLine;
               
            }
            else if (radioButton10.Checked == true)
            {
                std = std + "พบเห้นด้วยตัวเอง" + Environment.NewLine;
            }
            else
            {
                std = std + "Website" + Environment.NewLine;
            }
            std = std + "คุณชอบสินค้าประเภทใดมากที่สุด? : ";
            if (radioButton12.Checked == true)
            {
                std = std + "กาแฟ"+ Environment .NewLine ;
            }
            else if (radioButton13.Checked == true)
            {
                std = std + "Smoothies "+Environment .NewLine ;

            }
            else if (radioButton14.Checked == true)
            {
                std = std + "เบเกอรี่"+ Environment .NewLine ;

            }
            else if (radioButton15.Checked == true)
            {
                std = std + "เครื่องดื่มอื่นๆ";
            }
            else if (radioButton16.Checked == true)
            {
                std = std + "ไอศกรีม" + Environment.NewLine;
            }
            else
            {
                std = std + "ของสมนาคุณ"+ Environment .NewLine ;
            }
            std = std + "คุณชอบสิ่งอำนวยความสะดวกใดมากที่สุด ? : ";
            if (radioButton18.Checked == true)
            {
                std = std + "Internet"+ Environment .NewLine ;
            }
            else if (radioButton19.Checked == true)
            {
                std = std + "นิตยสาร" + Environment.NewLine;
            }
            else if (radioButton20.Checked == true)
            {
                std = std + "ข้อมูลเกี่ยวกับสาขาต่างๆ"+Environment .NewLine ;
            }
            else
            {
            std = std + "บรรยากาศ/ การตกแต่งร้าน"+ Environment .NewLine ;
            }
            MessageBox.Show(std,"คำตอบของคุณ" );
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
