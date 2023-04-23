using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformlab3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a;
        private double b;
        private MyCalc MyCalc1 = new MyCalc(); //Занимаем место для нового класса
        
        private void button1_Click(object sender, EventArgs e)
        {


            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            
            
                try
                {
                    MyCalc1.a = a;
                    MyCalc1.b = b;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка: " + exception.Message);
                    textBox1.Focus();
                    return;
                }

                MessageBox.Show("Параметры считаны!");
            

            //Вызов метода для расчета
            double Rez = MyCalc1.calc();

            textBox3.Text = Rez.ToString("F4");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}