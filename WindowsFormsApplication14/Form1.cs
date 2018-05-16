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


        ///
        double q;
        double a;
        double b;
        int c;
        int zpt = 0;
        double Oyaeby;
        int aRn = 0;





        ///Текстбокс
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (textBox1.Text == "0" + i)
                {
                    textBox1.Text = Convert.ToString(i);
                }
            }
             

            
            try
            {
                Oyaeby = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                textBox1.Clear();
            }
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
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            c = 1;
            zpt = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
                a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            c = 2;
            zpt = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
                a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            c = 3;
            zpt = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
                a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            c = 4;
            zpt = 0;
        }
        
        
        
        
        ///Процент
        private void button4_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((a / 100) * (100 + b));
            }

            else if (c == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((a / 100) * (100 - b));
            }

            else if (c == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((a / 100) * (100 * b));
            }

            else if (c == 4)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((a / 100) * (100 / b));
            }

            else if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            else
            {
                textBox1.Clear();
            }
        }
        
        
        
        ///Корень
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
                a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(a));
        }
        
        
        
        ///Равно
        private void button12_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = a + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
                zpt = 0;
            }

            else if (c == 2)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = a - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
                zpt = 0;
            }

            else if (c == 3)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = a * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
                zpt = 0;
            }

            else if (c == 4)
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                }
            }

            else if (c == 5)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(a, b));
                zpt = 0;
            }

            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                else
                    b = a / Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(b);
            }
                zpt = 0;
            }
        
        
        
        
        ///C
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            c = 0;
        }






        ///Знак -
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            else if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }

            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "0";
            }


            if (Convert.ToString(textBox1.Text[0]) != "-")
            {
                double min = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "-" + min;
                if (textBox1.Text == "-0")
                {
                    textBox1.Text = "0";
                }
            }

            else if (Convert.ToString(textBox1.Text[0]) == "-")
            {
                string vag = textBox1.Text.Remove(0,1);
                textBox1.Text = vag;
                if (textBox1.Text == "-0")
                {
                    textBox1.Text = "0";
                }
            }
        }







        private void button1_Click(object sender, EventArgs e)
        {
            zpt = zpt + 1;
            textBox1.Text = textBox1.Text + ",";
            if (textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            if (zpt > 1)
            {
                textBox1.Clear();
                zpt = 0;
            }
            
            
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            int posl = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.Remove(posl-1);

        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            c = 5;
        }
    }
}
