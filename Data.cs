using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Data
    {
        private string[] lottoNumbers = new string[7];

        private string[] maxNumbers = new string[8];

        private string numberTodisplay;
        private string numberToPrint;


        public Data() {
        
        
        
        
        }

        public string[] LottoNumbers {
            get { return lottoNumbers; }
            set { lottoNumbers = value; }



        }
        public string[] MaxNumbers { get { return maxNumbers; } set { maxNumbers = value; } }
        public string NumberTodisplay { get { return numberTodisplay; } set { numberTodisplay = value; } }
        public string NumberToPrint { get { return numberToPrint; } set { numberToPrint = value; } }

        public void GenerateLottoNumber()
        {

            NumberToPrint = "649, " + DateTime.Now.ToShortDateString()
                           + "\t" + DateTime.Now.ToShortTimeString() + ", ";

            string comma = ",";
            Random random = new Random();
            int randomNumber;
            List<int> randomNumberList = new List<int>();



            for (int i = 0; i < 7; i++)
            {
            start:
                //staring generating the number randomly
                randomNumber = random.Next(1, 50); //(1, 50) 7 + 1 numbers

                //here verify if the number is not in the list. if the return is false I add it
                if (!randomNumberList.Contains(randomNumber))
                {

                    randomNumberList.Add(randomNumber); //(1, 50) 7 + 1 numbers
                }
                else
                {
                    //here I goto "start" to generate the number again and check again if the number is not repeat
                    goto start;
                }




                //Here I add number by number from the list to the variable to display it later
                NumberTodisplay += randomNumberList[i].ToString() + "\t";


                this.NumberTodisplay = NumberTodisplay;


                if (i == 6) { NumberToPrint += " Extra " + randomNumber.ToString(); }
                else
                {
                    if (i == 6)
                    {
                        comma = "";
                    }
                    NumberToPrint += randomNumberList[i].ToString() + comma;


                }
            }
            this.NumberToPrint = NumberToPrint;



        }




    





        public void  GenerateMaxNumber()
        {


         

            NumberToPrint = "Max, " + DateTime.Now.ToShortDateString()
                  + "\t" + DateTime.Now.ToShortTimeString() + ", ";
           
            string comma = ",";
            Random random = new Random();
            int randomNumber;
            List<int> randomNumberList = new List<int>();



            for (int i = 0; i < 8; i++)
            {
            start:
                //staring generating the number randomly
                randomNumber = random.Next(1, 50); //(1, 50) 7 + 1 numbers

                //here verify if the number is not in the list. if the return is false I add it
                if (!randomNumberList.Contains(randomNumber))
                {

                    randomNumberList.Add(randomNumber); //(1, 50) 7 + 1 numbers
                }
                else
                {
                    //here I goto "start" to generate the number again and check again if the number is not repeat
                    goto start;
                }




                //Here I add number by number from the list to the variable to display it later
                NumberTodisplay += randomNumberList[i].ToString() + "\t";


                this.NumberTodisplay = NumberTodisplay;


                if (i == 7) { NumberToPrint += " Extra " + randomNumber.ToString(); }
                else
                {
                    if (i == 7)
                    {
                        comma = "";
                    }
                    NumberToPrint += randomNumberList[i].ToString() + comma;
                    

                }
            }
                this.NumberToPrint = NumberToPrint;



        }




    }
}
