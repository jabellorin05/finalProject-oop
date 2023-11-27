using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
   abstract public class ipValid
    {
       public  abstract string ipValidator(string ip);

        public void DisplayMessageIpV4(bool status)
        {
            if (status)
            {

                MessageBox.Show("The ip Adress is correct");


            }
            else
            {
                MessageBox.Show("The ip Adress with invalid format.. The correct format is 255.255.255.255");
            }

        }
        //hago la clase que erede de ipvalid
        //override string validatorip()

    }
}
