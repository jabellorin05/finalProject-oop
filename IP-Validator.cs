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
using System.Xml;

namespace FinalProject
{
    public partial class The_IP4___IP6_Validator : Form
    {
        static string dir = @".\Files\";
        static string path = dir + "ipB.txt";
        FileStream fs = null;
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
           saveData();
           readFileAndWriteXml();

        }

        private void saveData()
        {
            string ipV4 = textBox1.Text;
            string ipV6 = textBox2.Text;
            bool error = false;

            string currentDate = DateTime.Now.ToShortDateString();
            string currentTime = DateTime.Now.ToShortTimeString();


            if (ipV4.Equals("") && ipV6.Equals(""))
            {

                MessageBox.Show("sorry, the fields  cannot be empty");
            }
            else
            {
                try
                {

                    if (ipV4 != "")
                    {
                        IPV4AndIpV6 ip4 = new IPV4AndIpV6();

                        if (ip4.ipValidatorIpV4(ipV4))
                        {
                            fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                            BinaryWriter bw = new BinaryWriter(fs);

                            bw.Write(currentDate.ToString());
                            bw.Write(currentTime.ToString());
                            bw.Write( ipV4);
                            

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
                    if (ipV6 != "")
                    {
                        IPV4AndIpV6 ip6 = new IPV4AndIpV6();

                        if (ipV6 != "")
                        {


                            if (ip6.ipValidatorIpV6(ipV6))
                            {
                                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

                                BinaryWriter bw = new BinaryWriter(fs);

                                bw.Write(currentDate.ToString());
                                bw.Write(currentTime.ToString());
                                bw.Write(ipV6.ToString());

                                fs.Close();
                                bw.Close();
                            }
                        }
                    }



                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(path + " not found.", "File Not Found");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(path + " not found.", "Directory Not Found");
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }
                finally { if (fs != null) fs.Close(); }
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

        void readFileAndWriteXml()
        {

            string title = "Date\t\t time:\t\t Ip:\n";
            try
            {
               
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                string row = "";
                BinaryReader br = new BinaryReader(fs);


                // create the XmlWriterSettings object
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true; settings.IndentChars = (" ");

                // create the XmlWriter object
                XmlWriter xmlOut = XmlWriter.Create(dir +"ipB.xml" , settings);

                // write the start of the document
                xmlOut.WriteStartDocument();

            
                xmlOut.WriteStartElement("IpV4_AndI_pV6");//Create the root element

                while (br.PeekChar() != -1)
                {
                    
              
                    xmlOut.WriteStartElement("Ips");//create child element

                    xmlOut.WriteElementString("Date", br.ReadString());
                    xmlOut.WriteElementString("time", br.ReadString());
                    xmlOut.WriteElementString("IP", br.ReadString());

                    xmlOut.WriteEndElement();//close child element */
                }

                xmlOut.WriteEndElement();//Close the root element
               
                xmlOut.Close();
                br.Close();//close binary object
                fs.Close();



                //while (br.PeekChar() != -1)
                //{

                //    row += br.ReadString() + "\n";
                //}

                //MessageBox.Show(title+row);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //read from XML file and display data
            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(dir + "ipB.xml", settings);

            string tempStr = "", date = "", time = "", ip = "";

            // read past all nodes to the first UseName node
            if (xmlIn.ReadToDescendant("Ips"))
            {   // create FN and LN string for each UseName node
                do
                {
                    xmlIn.ReadStartElement("Ips");
                    date = xmlIn.ReadElementContentAsString();
                    time = xmlIn.ReadElementContentAsString();
                    ip = xmlIn.ReadElementContentAsString();
                    tempStr += date + ", " + time + ", " + ip + "\n";
                } while (xmlIn.ReadToNextSibling("Ips"));
                MessageBox.Show(tempStr);
            }
            else { MessageBox.Show("No data"); }
            // close the XmlReader object
            xmlIn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wanna quit?", " Exit", MessageBoxButtons.YesNoCancel).ToString().Equals("Yes"))
            {

                MessageBox.Show("you decided to quit de app", $"{DateTime.Now.ToShortDateString()} at {DateTime.Now.ToShortTimeString()}");
                Application.Exit();
            }




 

    }
}
}






    
    

