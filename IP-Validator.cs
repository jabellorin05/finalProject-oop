using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class The_IP4___IP6_Validator : Form
    {
        static string dir = @".\Files\";
        static string path = dir + "ipB.txt";
        public The_IP4___IP6_Validator()
        {
            InitializeComponent();
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ipV4 = textBox1.Text;
            string ipV6 = textBox2.Text;
            bool error = false;
            FileStream fs = null;
            DateTime currentDate = DateTime.Now;
            string currentTime = DateTime.Now.ToShortTimeString();


            if (ipV4.Equals("") && ipV6.Equals(""))
            {

                MessageBox.Show("sorry, the fields  cannot be empty");
            }
            else
            {
                try
                {

                    if (ipV4!="")
                    {
                        IPV4AndIpV6 ip4 = new IPV4AndIpV6();

                      if(ip4.ipValidatorIpV4(ipV4))
                        {
                           fs = new FileStream(path, FileMode.Append,FileAccess.Write);

                            BinaryWriter bw = new BinaryWriter(fs) ;

                            bw.Write(currentDate.ToString() +" "+ipV4) ;

                            fs.Close();
                            bw.Close();
                        }
                    }
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                try
                {
                    if (ipV6!="")
                    {
                        IPV4AndIpV6 ip6 = new IPV4AndIpV6();

                        if (ipV6 != "")
                        {
                          

                            if (ip6.ipValidatorIpV6(ipV6))
                            {
                                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                                BinaryWriter bw = new BinaryWriter(fs);

                                bw.Write(currentDate.ToString() + " " + ipV6);

                                fs.Close();
                                bw.Close();
                            }
                        }
                    }
                   


                }
                catch (Exception ex2)
                {

                    MessageBox.Show(ex2.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanInput();
        }



        void CleanInput()
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void The_IP4___IP6_Validator_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}






    
    

