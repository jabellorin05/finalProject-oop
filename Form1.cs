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
    //Name:Jose Antonio Bellorin
    //Final project section 1
    //2023/11/08
    public partial class Form1 : Form
    {
        DateTime startTime;
        public Form1()
        {
            InitializeComponent();
            startTime = DateTime.Now;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.Show(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lotto69 lotto69 = new Lotto69();
            lotto69.Show();


          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime closeTime = DateTime.Now;


            TimeSpan loginTime = closeTime - startTime;
            int minutes = loginTime.Minutes;
            int seconds = loginTime.Seconds;

            if (MessageBox.Show($"Do you wanna exit? You have been here for {minutes} minutes and {seconds} seconds ", " Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString().Equals("Yes"))
            {


                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange();
            exchange.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            The_Temperature_application the_Temperature_Application = new The_Temperature_application();
            the_Temperature_Application.Show();




        }

        private void button8_Click(object sender, EventArgs e)
        {
            The_IP4___IP6_Validator the_IP4___IP6_  = new The_IP4___IP6_Validator();
            the_IP4___IP6_.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            simpleCalculatorAplication simpleCalculatorAplication = new simpleCalculatorAplication();
            simpleCalculatorAplication.Show();  
        }
    }
    }

