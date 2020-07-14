using System;
using System.Windows.Forms;

namespace calculator_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void summary_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result = firstNumber + secondNumber;
            textBox3.Text = result.ToString();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result = firstNumber - secondNumber;
            textBox3.Text = result.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result = firstNumber * secondNumber;
            textBox3.Text = result.ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result = firstNumber / secondNumber;
            textBox3.Text = result.ToString();
        }
    }
}
