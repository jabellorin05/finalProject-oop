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
        double result=0;
        string currentValue = "0";
        string currentOperation = "";
        Addition addition = new Addition();
        Addition subtraction = new Addition();

        List<double> ValuesList = new List<double>();
        
        public simpleCalculatorAplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            currentValue += "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "+";
            double val1 = Convert.ToDouble( currentValue);
            
            addition.ListValues(val1);
            ValuesList=addition.GetList();
           
           
          

            
            currentValue = "0";
            currentOperation = "+";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";

           
            if (currentOperation.Equals("+"))
            {
                Operations operations = new Addition();
                addition.ListValues(Double.Parse(currentValue));
                ValuesList = addition.GetList();
                currentValue = "0";
                // double LastValue = Convert.ToDouble(currentValue);
               

               
                result = operations.Calculate(ValuesList);
                textBox2.Text = result.ToString();  
            }
            else if (currentOperation.Equals("-"))
            {
                Operations operations = new Subtraction();
                subtraction.ListValues(Double.Parse(currentValue));
                ValuesList =subtraction.GetList();
                currentValue = "0";
               
                result = operations.Calculate(ValuesList);
                textBox2.Text = result.ToString();

            }
          


            textBox1.Text += result.ToString();
            textBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            currentValue += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            currentValue += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            currentValue += 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            double val1 = Convert.ToDouble(currentValue);
           
          
            addition.ListValues(val1);
            ValuesList = addition.GetList();


            currentValue = "0";
            currentOperation = "-";
        }
    }
}
