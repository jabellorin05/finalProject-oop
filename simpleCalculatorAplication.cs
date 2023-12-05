using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class simpleCalculatorAplication : Form
    {
        double result=0,currentValue=0,valueBefore=0;
        string currentNumber = "";
        string currentOperation = "";
        int count = 0;
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
            textBox2.Text += "1";
            currentNumber += "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            Operations operations = new Addition();
            currentValue= Convert.ToDouble(textBox2.Text);

            if (count<1)
            {
                textBox1.Text += "+";
            }
          
           
            count++;
            currentOperation = "+";
           
            if (count==1)
            {
                textBox2.Text = "";
                valueBefore = currentValue;
            }
            if (count==2)
            {
                textBox1.Text += "=";
                currentValue = Convert.ToDouble(textBox2.Text);
                result = operations.Calculate(valueBefore,currentValue);
                textBox2.Text = result.ToString();
                textBox1.Text += result;
                count = 0;
            }

         

           
           
           
           
          

            
            
            currentOperation = "+";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "=";

           
            if (currentOperation.Equals("+"))
            {
              //  double valueBefore = currentValue;
                Operations operations = new Addition();
                //currentValue = Convert.ToDouble(textBox2.Text);

                if (count >=1 )
                {
                   
                        textBox1.Text += "=";
                        currentValue = Convert.ToDouble(textBox2.Text);
                        result = operations.Calculate(valueBefore, currentValue);
                        textBox2.Text = result.ToString();
                        textBox1.Text += result;
                        count = 0;
                }


            }
            else if (currentOperation.Equals("-"))
            {
                Operations operations = new Subtraction();
                if (count >= 1)
                {

                    textBox1.Text += "=";
                    currentValue = Convert.ToDouble(textBox2.Text);
                    result = operations.Calculate(valueBefore, currentValue);
                    textBox2.Text = result.ToString();
                    textBox1.Text += result;
                    count = 0;
                }

            }
          


            //textBox1.Text += result.ToString();
          //  textBox2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
            currentNumber += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
            currentNumber += 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            currentNumber += 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Operations operations = new Subtraction();
            currentValue = Convert.ToDouble(textBox2.Text);

            if (count < 1)
            {
                textBox1.Text += "-";
            }


            count++;
            currentOperation = "-";

            if (count == 1)
            {
                textBox2.Text = "";
                valueBefore = currentValue;
            }
            if (count == 2)
            {
                textBox1.Text += "=";
                currentValue = Convert.ToDouble(textBox2.Text);
                result = operations.Calculate(valueBefore, currentValue);
                textBox2.Text = result.ToString();
                textBox1.Text += result;
                count = 0;
            }



        }
    }
}
