using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class The_Temperature_application : Form
    {
        //Jose Bellorin
        //Description: Temperature
        //2023/12/05 


        //variables

        DateTime iniTime;
        static string dirFile = @".\Files\";
        string path = dirFile + "TempConversions.txt";
        FileStream fs = null;


        public The_Temperature_application()
        {
            if (!Directory.Exists(dirFile))
            Directory.CreateDirectory(path);


            InitializeComponent();
            iniTime=DateTime.Now;
        }

        private void The_Temperature_application_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan currenttime = DateTime.Now - iniTime;

            int minutes = currenttime.Minutes;
            int seconds = currenttime.Seconds;

            if (MessageBox.Show($"Do you wanna quit? you decided to quit de app? you have been here {minutes} sec {seconds}", " Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString().Equals("Yes"))
            {


                System.Windows.Forms.Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool empty = true;


            try
            {

                if (!validateData(textBox1.Text.Trim()) && textBox1.Text!="")
                {
                    MessageBox.Show("Sorry, the field must contain only numbers for C or F.");
                    empty = false;
                  //  return;
                }
                
                




                    if (radioBFromC.Checked && textBox1.Text.Trim() != "")
                    {



                        float celsius = float.Parse(textBox1.Text);
                        Temperature obj = new CtoF();


                        textBox2.Text = obj.ConvertTemp(celsius).ToString("0.00");


                        setMessasge();
                        ChangeCelsiusColor();
                        SaveDataTextFile();
                        SaveDataBinaryFile();


                        empty = false;


                    }



                    if (radioBFromF.Checked && textBox1.Text.Trim() != "")
                    {




                        int Fahrenheit = int.Parse(textBox1.Text);

                    Temperature obj2 = new FtoC();


                        textBox2.Text = obj2.ConvertTemp(Fahrenheit).ToString("0.00");
                       
                        setMessasge();
                        ChangeFarenheitColor();
                        SaveDataTextFile();
                       
                    empty = false;

                    }

                }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
         
            if (empty)
            {
                MessageBox.Show("Sorry, the field C or F cannot be empty");
            }

          
            
          



        }

        private void setMessasge()
        {
            string temp="",message="";
            temp=textBox1.Text;


            if (textBox1.Text!="")
            {


                switch (temp)
                {
                    case "100":
                    case "212":

                    message = "Water boils";
                     break;

                    case "104":
                    case "40":
                        message = "Hot Bath";

                        break;

                    case "37":
                    case "98.6":
                        message = "Body temperature";

                        break;

                    case "30":
                    case "86":
                        message = "Beach weather";

                        break;

                    case "21":
                    case "70":
                        message = "Room temperature";

                        break;


                    case "-18":
                    case "0":
                        message = "Very Cold Day";

                        break;

                    case "-40":
                   
                        message = "Extremely Cold Day";

                        break;






                }

                textMessage.Text = message;
            }

           

        }

        private void SaveDataTextFile()
        {
            // Currencies currencies = new Currencies();
            path = dirFile + "TempConversions.txt";
            string  textToSave="", date, formattedDate,farenheit,celsius,time,message;
           
            time = DateTime.Now.ToShortTimeString() + "\t\t";
            date = DateTime.Now.ToShortDateString();
            formattedDate = date.Replace('-', '/') + "\t";


            //100 C = 212 F, 2023/7/22 01:01:33 PM Water Boils
            // 104 F = 40 C, 2023 / 7 / 22 10:07:03 PM Hot Bath

            try
            {

                celsius = textBox1.Text.Trim() + "C =";
                farenheit = textBox2.Text.Trim() + "F," + "\t";
                message = textMessage.Text.Trim() + "\t";

                if (radioBFromC.Checked)
                {
                    textToSave = $"{celsius} {farenheit} {formattedDate} {time} {message} \n";
                }
                else
                {
                    celsius = textBox2.Text.Trim();
                    farenheit = textBox1.Text.Trim();

                    textToSave = $"{farenheit}F = {celsius}C ,  {formattedDate}  {time} {message} \n";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
           

            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter objSw = new StreamWriter(fs);

                if (textBox1.Text != "")
                {


                   
                    objSw.Write(textToSave + "\n\n");
                    objSw.Close();
                }






            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(dirFile + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }


        private void SaveDataBinaryFile()
        {
           

          
            path = dirFile + "TempConversionsB.txt.";
            
            string textToSave, date, formattedDate, farenheit, celsius, time, message;
            celsius = textBox1.Text.Trim();
            farenheit = textBox2.Text.Trim();
            message = textMessage.Text.Trim() + "\t";
            time = DateTime.Now.ToShortTimeString() + "\t\t";
            date = DateTime.Now.ToShortDateString();
            formattedDate = date.Replace('-', '/');

            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                BinaryWriter objWb = new BinaryWriter(fs);

                if (textBox1.Text != "")
                {


                    if (radioBFromC.Checked)
                    {
                        textToSave = $"{celsius} C =  {farenheit} F , {formattedDate} {time} {message} \n";
                    }
                    else
                    {
                        celsius = textBox2.Text.Trim();
                        farenheit = textBox1.Text.Trim();

                        textToSave = $"{farenheit}  F = {celsius} C ,  {formattedDate}  {time} {message} \n";
                    }

                    objWb.Write(textToSave);
                   
                    objWb.Close();

                }






            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(dirFile + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }

        private void ChangeCelsiusColor()
        {
            float value=float.Parse(textBox1.Text.Trim());

            if (radioBFromC.Checked)
            {

                if (value>=40 )
                {
                    
                    textBox1.ForeColor=Color.Red;
                  

                }
                if (value>+30 && value <= 39)
                {
                    textBox1.ForeColor = Color.Orange;
                   
                }
                if (value > 10 && value <= 21)
                {
                    textBox1.ForeColor = Color.Green;

                }
                if (value >= 0 && value <= 10)
                {
                    textBox1.ForeColor = Color.Blue;

                }
                if (value < 0 )
                {
                    textBox1.ForeColor = Color.Black;
                }
             






            }
        }


        private bool validateData(string data)
        {
            string patter = @"^-?[0-9]+(\.[0-9]+)?$";
            Regex regex = new Regex(patter);

            if (regex.IsMatch(data))
            {
                return true;
            }

            return false;
        }



        private void ChangeFarenheitColor()
        {
            float value = float.Parse(textBox1.Text.Trim());

            if (radioBFromF.Checked)
            {

                if (value >= 104)
                {

                    textBox1.ForeColor = Color.Red;


                }
                if (value > 85 && value < 99)
                {
                    textBox1.ForeColor = Color.Orange;

                }
                if (value >= 31 && value <= 85)
                {
                    textBox1.ForeColor = Color.Green;

                }
                if (value >= 32 && value <= 50)
                {
                    textBox1.ForeColor = Color.Blue;

                }
                if (value < 32)
                {
                    textBox1.ForeColor = Color.Black;
                }







            }
        }


    








        private void radioBFromF_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = "C";

        }

        private void radioBFromC_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "C";
            label3.Text = "F";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = "Temperature" + "\t" +  "   Date" + "\t" + "\t" + "Time" + "\t\t" + "Message" + "\n";
            string name = "Jose Bellorin";
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                string row = "";
                StreamReader objR = new StreamReader(fs);

                while (objR.Peek() != -1)
                {

                    row += objR.ReadLine() + "\n";

                }

                MessageBox.Show(name+"\n\n\n"+title+"\n"+row);
            
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(dirFile + " not found.", "File Not Found");
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
}
