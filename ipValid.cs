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

        public void DisplayMessageIpV4(bool status,string ip)
        {
            if (status)
            {

                MessageBox.Show($"{ip} The ip Adress is correct");


            }
            else
            {
                MessageBox.Show($"{ip} ip must have 4 bytes. \n integer number between 0 to 255"+"\n"+"separated by a dot (255.255.255.255)");
            }

        }


        public void DisplayMessageIpV6(bool status,string ipv6)
        {
            if (status)
            {

                MessageBox.Show("The ip Adress is correct");


            }
            else
            {
                MessageBox.Show($"{ipv6}\n The ip must have 16 bytes. The correct format is 2340:1111:AAAA:0001:1234:5678:9ABC:1234");
            }

        }
        //hago la clase que erede de ipvalid
        //override string validatorip()

    }
}
