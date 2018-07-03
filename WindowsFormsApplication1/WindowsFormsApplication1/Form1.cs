using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void radical_Click(object sender, EventArgs e)
        {
            string radicalValueText = textBox4.Text;
            double radicalValue = Convert.ToDouble(radicalValueText);
            OneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double radicalResult = calculator.Calculate(radicalValue);
            textBox4.Text = radicalResult.ToString();

        }
    }
    
}
