using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class ipV4 : IpValid
    {
        public override bool ipValidatorIpV4(string ip)
        {

            string pattern = "^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(ip))
            {

                DisplayMessageIpV4(true);
                return true;

            }
            else
            {
                DisplayMessageIpV4(false);
                return false;
            }

           
        }

        public override bool ipValidatorIpV6(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
