using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{


    //============================================================================

    //Jose Antonio Bellorin
    //Section 2 project
    //23/11/15

    //============================================================================
    public partial class Exchange : Form
    {
        string from="";
        static  string dirFile = @".\Files\";
        string path = dirFile + "MoneyConversions.txt";
        FileStream fs = null;
        DateTime iniTime;

        public Exchange()
        {
            InitializeComponent();
            iniTime=DateTime.Now;
            if (Directory.Exists(dirFile)==false)
            {
                Directory.CreateDirectory(dirFile);

            }
        }

        private void Exchange_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^[0-9]+$";

            if (textValue.Text=="")
            {
                MessageBox.Show("sorry, the field cannot be empty");
                textValue.Focus();
            }
            else
            {
                if (Regex.IsMatch(textValue.Text,pattern))
                {
                    MakeCalculations();


                    SaveDataTextFile();

                    SaveDataBinaryFile();
                }
                else
                {

                    MessageBox.Show("sorry, the value entered is invalid. Enter a valid number");
                }

              
            }





        }

      
        //functions
        private void ConvertFromCad(float cad)
        {


            Calcs calcs = new Calcs(cad);

            textCanada.Text = calcs.FromCad().Cad + " CAD";
            textUsa.Text = calcs.FromCad().Usd.ToString() + " USD";
            textUK.Text = calcs.FromCad().Gpb.ToString() + " GPB";
            textEuro.Text = calcs.FromCad().Euro.ToString() + " Eur";
            textJapan.Text = calcs.FromCad().Jpy.ToString() + " JPY";
            textChina.Text = calcs.FromCad().Cny.ToString() + "  CNY";
        }

        private void ConvertFromUsd(float usd)
        {

            Calcs calcs = new Calcs(usd);

            textCanada.Text = calcs.FromUSD().Cad + " CAD";
            textUsa.Text = calcs.FromUSD().Usd.ToString() + " USD";
            textUK.Text = calcs.FromUSD().Gpb.ToString() + " GPB";
            textEuro.Text = calcs.FromUSD().Euro.ToString() + " Eur";
            textJapan.Text = calcs.FromUSD().Jpy.ToString() + " JPY";
            textChina.Text = calcs.FromUSD().Cny.ToString() + "  CNY";
        }



        private void ConvertFromGpb(float gpb)
        {

            Calcs calcs = new Calcs(gpb);

            textCanada.Text = calcs.FromGpb().Cad + " CAD";
            textUsa.Text = calcs.FromGpb().Usd.ToString() + " USD";
            textUK.Text = calcs.FromGpb().Gpb.ToString() + " GPB";
            textEuro.Text = calcs.FromGpb().Euro.ToString() + " Eur";
            textJapan.Text = calcs.FromGpb().Jpy.ToString() + " JPY";
            textChina.Text = calcs.FromGpb().Cny.ToString() + "  CNY";
        }

        private void ConvertFromEur(float eur)
        {

            Calcs calcs = new Calcs(eur);

            textCanada.Text = calcs.FromEur().Cad + " CAD";
            textUsa.Text = calcs.FromEur().Usd.ToString() + " USD";
            textUK.Text = calcs.FromEur().Gpb.ToString() + " GPB";
            textEuro.Text = calcs.FromEur().Euro.ToString() + " Eur";
            textJapan.Text = calcs.FromEur().Jpy.ToString() + " JPY";
            textChina.Text = calcs.FromEur().Cny.ToString() + "  CNY";
        }


        private void ConvertFromJpy(float eur)
        {

            Calcs calcs = new Calcs(eur);

            textCanada.Text = calcs.FromJpy().Cad + " CAD";
            textUsa.Text = calcs.FromJpy().Usd.ToString() + " USD";
            textUK.Text = calcs.FromJpy().Gpb.ToString() + " GPB";
            textEuro.Text = calcs.FromJpy().Euro.ToString() + " Eur";
            textJapan.Text = calcs.FromJpy().Jpy.ToString() + " JPY";
            textChina.Text = calcs.FromJpy().Cny.ToString() + "  CNY";
        }


        private void MakeCalculations()
        {

            float value = 0;
            if (rBCanada.Checked)
            {
                from = rBCanada.Text;

                try
                {
                    value = float.Parse(textValue.Text.Trim());

                    ConvertFromCad(value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }




            }
            else if (rBUsa.Checked)
            {
                from = rBUsa.Text;

                try
                {
                    value = float.Parse(textValue.Text.Trim());

                    ConvertFromUsd(value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
            else if (rBGbp.Checked)
            {
                from = rBGbp.Text;
                try
                {
                    value = float.Parse(textValue.Text.Trim());

                    ConvertFromGpb(value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }




            }
            else if (rBEuro.Checked)
            {
                from = rBEuro.Text;
                try
                {
                    value = float.Parse(textValue.Text.Trim());

                    ConvertFromEur(value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
            else if (rBJapan.Checked)
            {
                from = rBJapan.Text;
                try
                {
                    value = float.Parse(textValue.Text.Trim());

                    ConvertFromJpy(value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }


        }


        private void SaveDataTextFile()
        {
            Currencies currencies = new Currencies();

            string   textToSave,date,formattedDate;

            date= DateTime.Now.ToString()+"\n" ;
           


            textToSave = textValue.Text + from + " = " + textCanada.Text + "; " + textUsa.Text + "; " + textEuro.Text + "; " + textUK.Text + "; " + textJapan.Text + ";" + textChina.Text + ";\n";
            formattedDate = date.Replace('-', '/');

            try
            {
                fs=new FileStream(path,FileMode.Append,FileAccess.Write);
                StreamWriter objSw = new StreamWriter (fs);

                if (textValue.Text!="")
                {
                   

                    objSw.Write (formattedDate);
                    objSw.Write( textToSave+"\n\n");
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
            Currencies currencies = new Currencies();

            string  textToSave, date, formattedDate;
            path = dirFile + "MoneyConversionsB.txt";

            date = DateTime.Now.ToString() ;



            textToSave = textValue.Text + from + " = " + textCanada.Text + "; " + textUsa.Text + "; " + textEuro.Text + "; " + textUK.Text + "; " + textJapan.Text + ";" + textChina.Text ;
            formattedDate = date.Replace('-', '/');

            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
               BinaryWriter objWb = new BinaryWriter(fs);

                if (textValue.Text != "")
                {


                    objWb.Write(formattedDate);
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





        private void ReadTxtField()
        {
            string path = dirFile + "MoneyConversions.txt";


            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            string row = "";
            StreamReader objR = new StreamReader(fs);

            while (objR.Peek()!=-1)
            {

                row+=objR.ReadLine()+"\n";    

            }

            MessageBox.Show(row);
            objR.Close();
        }




        // MessageBox.Show(textToSave);






        //events radiobuttons

        private void rBCanada_CheckedChanged(object sender, EventArgs e)
        {
            textValue.Focus();
        }

        private void rBUsa_CheckedChanged(object sender, EventArgs e)
        {
            textValue.Focus();
        }

        private void rBEuro_CheckedChanged(object sender, EventArgs e)
        {
            textValue.Focus();
        }

        private void rBGbp_CheckedChanged(object sender, EventArgs e)
        {
            textValue.Focus();
        }

        private void rBJapan_CheckedChanged(object sender, EventArgs e)
        {
            textValue.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan currenttime=DateTime.Now- iniTime;

            int minutes=currenttime.Minutes;
            int seconds=currenttime.Seconds;    

            if (MessageBox.Show($"Do you wanna quit? you decided to quit de app? you have been here {minutes} sec {seconds}", " Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString().Equals("Yes"))
            {

                
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ReadTxtField();




        }

  
    }
}
