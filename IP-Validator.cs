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
    public partial class The_IP4___IP6_Validator : Form
    {
        public The_IP4___IP6_Validator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ipV4 = textBox1.Text;

            if (ipV4 == "")
            {
                MessageBox.Show("sorry, the field cannot be empty");
            }
            else
            {
                try
                {
                    ipV4 ip4 = new ipV4();

                    ip4.ipValidatorIpV4(ipV4);
                }
                catch (Exception)
                {

                    throw;
                }
            }
               

           
        }
    }
}
