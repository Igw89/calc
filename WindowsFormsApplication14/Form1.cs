using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }




        float a;
        float b;
        int c;








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




       





        ///Цифры

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }





        ///Арифмитические операции
        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            c = 1;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            c = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            c = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            c = 4;
        }






        ///Процент, корень
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 9;
            Math.Sqrt(a);
            textBox1.Text = Convert.ToString(a);
        }






        ///Равно
        private void button12_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                b = a + Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
            }

            else if (c == 2)
            {
                b = a - Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
            }

            else if (c == 3)
            {
                b = a * Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
            }

            else if (c == 4)
            {
                b = a / Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
            }
        }











        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
