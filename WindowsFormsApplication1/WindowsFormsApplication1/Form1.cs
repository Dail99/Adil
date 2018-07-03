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

        private void sum()
        {
            double firstCase = Convert.ToDouble(textBox1.Text);
            textBox1.Text = firstCase.ToString();
            double secondCase = Convert.ToDouble(textBox3.Text);
            textBox3.Text = secondCase.ToString();
            double thirdCase = firstCase + secondCase;
            textBox2.Text = Convert.ToString(thirdCase);
        }
        private void min()
        {
            double firstCase = Convert.ToDouble(textBox1.Text);
            textBox1.Text = firstCase.ToString();
            double secondCase = Convert.ToDouble(textBox3.Text);
            textBox3.Text = secondCase.ToString();
            double thirdCase = firstCase - secondCase;
            textBox2.Text = Convert.ToString(thirdCase);
        }
        private void del()
        {
            double firstCase = Convert.ToDouble(textBox1.Text);
            textBox1.Text = firstCase.ToString();
            double secondCase = Convert.ToDouble(textBox3.Text);
            textBox3.Text = secondCase.ToString();
            double thirdCase = firstCase / secondCase;
            textBox2.Text = Convert.ToString(thirdCase);
        }
        private void umn()
        {
            double firstCase = Convert.ToDouble(textBox1.Text);
            textBox1.Text = firstCase.ToString();
            double secondCase = Convert.ToDouble(textBox3.Text);
            textBox3.Text = secondCase.ToString();
            double thirdCase = firstCase * secondCase;
            textBox2.Text = Convert.ToString(thirdCase);
        }

        private void ClickMain(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "ButtonPlus":
                    sum();
                    break;
                case "ButtonMin":
                    min();
                    break;
                case "ButtonDel":
                    del();
                    break;
                case "ButtonUmn":
                    umn();
                    break;
	
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}
