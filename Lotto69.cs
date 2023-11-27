using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    //name:jose bellorin
    //description:version section 1 Lotto Max of final project
    //date:23/11/03

    public partial class Lotto69 : Form
    {
        static string dir = @"./Files/";
        string path = dir + "LottoNumbers.txt";
        FileStream fs = null;
        DateTime startTime;
        public Lotto69()
        {
            InitializeComponent();
        }




        private void Lotto69_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
           
            startTime = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dir = @"C:\Files\";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);



            //create a instance of the clase Data to generate de random number
            Data data = new Data();
            data.GenerateLottoNumber();



          
            textBox1.Text = data.NumberTodisplay.ToString();
           
            
            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter objW = new StreamWriter(fs);
                objW.WriteLine(data.NumberToPrint);
                objW.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dir + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }



    




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //  fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "Numbers \n";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();

                    textToPrint += row + "\n";
                }
                MessageBox.Show(textToPrint);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(dir+ " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }




    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DateTime closeTime= DateTime.Now;


            TimeSpan loginTime = closeTime - startTime;
            int minutes=loginTime.Minutes;
            int seconds=loginTime.Seconds;  


            if (MessageBox.Show($"Do you wanna exit? You have been here for {minutes} minutes and {seconds} seconds " , " Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString().Equals("Yes"))
            {

                // MessageBox.Show("you decided to quit de app", $"{DateTime.Now.ToShortDateString()} at {DateTime.Now.ToShortTimeString()}");
                this.Close();

            }

               
            }
        }
    }

