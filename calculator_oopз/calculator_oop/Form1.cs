﻿using System;
using System.Windows.Forms;

namespace calculator_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate (object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.calculate(firstNumber, secondNumber);
            textBox3.Text = result.ToString();
        }

    }
}
