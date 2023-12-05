using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class simpleCalculatorAplication : Form
    {
        double result=0,currentValue=0;
        string currentNumber = "0";
        string currentOperation = "";
        Addition addition = new Addition();
        Subtraction subtraction = new Subtraction();

        List<double> ValuesList = new List<double>();
        
        public simpleCalculatorAplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            currentNumber += "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "+";
            double val1 = Convert.ToDouble( currentNumber);
            
            addition.ListValues(val1);
            ValuesList=addition.GetList();
           
           
          

            
            currentNumber = "0";
            currentOperation = "+";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";

           
            if (currentOperation.Equals("+"))
            {
                Operations operations = new Addition();
                addition.ListValues(Double.Parse(currentNumber));
                ValuesList = addition.GetList();
                currentNumber = "0";
                // double LastValue = Convert.ToDouble(currentValue);
               

               
                result = operations.Calculate(ValuesList);
                textBox2.Text = result.ToString();
                currentValue = result;
            }
            else if (currentOperation.Equals("-"))
            {
                Operations operations = new Subtraction();
                subtraction.ListValues(Double.Parse(currentNumber));
               
                ValuesList =subtraction.GetList();
                currentNumber = "0";

                result = operations.Calculate(ValuesList);
                textBox2.Text = result.ToString();
                currentValue = result;
                
            }
          


            //textBox1.Text += result.ToString();
          //  textBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            currentNumber += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            currentNumber += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            currentNumber += 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operations op = new Subtraction();
            textBox1.Text += "-";
            double val1 = Convert.ToDouble(currentNumber);
           
            subtraction.ListValues(val1);
            currentNumber = "0";
            currentOperation = "-";
        }
    }
}
