using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
   abstract public class IpValid
    {
       public  abstract bool ipValidatorIpV4(string ip);
        public abstract bool ipValidatorIpV6(string ip);

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


        public void DisplayMessageIpV6(bool status)
        {
            if (status)
            {

                MessageBox.Show("The ip Adress is correct");


            }
            else
            {
                MessageBox.Show("The ip Adress with invalid format.. The correct format is 2340:1111:AAAA:0001:1234:5678:9ABC:1234");
            }

        }
        //hago la clase que erede de ipvalid
        //override string validatorip()

    }
}
