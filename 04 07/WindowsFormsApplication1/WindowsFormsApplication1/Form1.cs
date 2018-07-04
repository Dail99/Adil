using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCalculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
  
        private void ClickMain(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox3.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            ITwoArgumentCalculator calculator = TwoTwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue, secondValue);
            textBox2.Text = result.ToString();
        }

        private void ClickMainOne(object sender, EventArgs e)
        {
            string thirdValueText = textBox4.Text;
            double thirdValue = Convert.ToDouble(thirdValueText);
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double thirdValueResult = calculator.Calculate(thirdValue);
            textBox4.Text = thirdValueResult.ToString();

        }
    }
    
}
