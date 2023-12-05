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
    //Jose Bellorin
    //Description: simple Calculator
    //2023/12/05

    public partial class simpleCalculatorAplication : Form
    {
        double result=0,currentValue=0,valueBefore=0;
        string currentNumber = "";
        string currentOperation = "";
        int count = 0;
        bool dec = true;
        Addition addition = new Addition();
        Subtraction subtraction = new Subtraction();

        List<double> ValuesList = new List<double>();
        
        public simpleCalculatorAplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            String value = "1";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
                 }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button10_Click(object sender, EventArgs e)
        {
           
            Operations operations = new Addition();
            currentValue= Convert.ToDouble(textBox2.Text);
            dec = true;
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

            dec = true;
            if (currentOperation.Equals("+"))
            {
                //  double valueBefore = currentValue;
                Operations operations = new Addition();
                //currentValue = Convert.ToDouble(textBox2.Text);

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
            else if (currentOperation.Equals("*"))
            {
                Operations operations = new Multiplication();
                if (count >= 1)
                {

                    textBox1.Text += "=";
                    currentValue = Convert.ToDouble(textBox2.Text);
                    result = operations.Calculate(valueBefore, currentValue);
                    textBox2.Text = result.ToString();
                    textBox1.Text += result;
                    count = 0;
                    dec = true;
                }


            }
            else if (currentOperation.Equals("/"))
            {
                IOtherOperations operations = new Division();
                if (count >= 1)
                {

                    textBox1.Text += "=";
                    currentValue = Convert.ToDouble(textBox2.Text);
                    result = operations.DivisionI(valueBefore, currentValue);
                    textBox2.Text = result.ToString();
                    textBox1.Text += result;
                    count = 0;
                }



            }
        }
            

        private void button2_Click(object sender, EventArgs e)
        {
            
            String value = "2";
            try {
                textBox1.Text += value;
                textBox2.Text += value;
                currentNumber += Convert.ToDouble(value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            String value = "3";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button14_Click(object sender, EventArgs e)
        {
            Operations operations = new Multiplication();
            currentValue = Convert.ToDouble(textBox2.Text);

            if (count < 1)
            {
                textBox1.Text += "*";
            }


            count++;
            currentOperation = "*";

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

        private void button5_Click(object sender, EventArgs e)
        {
            String value = "5";
            try { 
            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            String value = "6";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button9_Click(object sender, EventArgs e)
        {
            try { 
            String value = "7";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            String value = "8";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
                 }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
            String value = "9";

            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button12_Click(object sender, EventArgs e)
        {
            String value = "0";
            try { 
            textBox1.Text += value;
            textBox2.Text += value;
            currentNumber += Convert.ToDouble(value);
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void button11_Click(object sender, EventArgs e)
        {
           
           
            if (dec && textBox2.Text != "")
            {
                String value = ".";
                textBox1.Text += value;
                textBox2.Text += value;
                dec = false;
            }
           
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IOtherOperations Interface = new Division();
            currentValue = Convert.ToDouble(textBox2.Text);

            if (count < 1)
            {
                textBox1.Text += "/";
            }


            count++;
            currentOperation = "/";

            if (count == 1)
            {
                textBox2.Text = "";
                valueBefore = currentValue;
            }
            if (count == 2)
            {
                textBox1.Text += "=";
                currentValue = Convert.ToDouble(textBox2.Text);
                result = Interface.DivisionI(valueBefore, currentValue);
                textBox2.Text = result.ToString();
                textBox1.Text += result;
                count = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Clean();
        }

      

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                String value = "4";

                textBox1.Text += value;
                textBox2.Text += value;
                currentNumber += Convert.ToDouble(value);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you wanna quit?", " Exit", MessageBoxButtons.YesNoCancel).ToString().Equals("Yes"))
            {

                MessageBox.Show("you decided to quit de app", $"{DateTime.Now.ToShortDateString()} at {DateTime.Now.ToShortTimeString()}");
                Application.Exit();
            }

        


 

    }

        private void simpleCalculatorAplication_Load(object sender, EventArgs e)
        {

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


        private void Clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }



    }
}
