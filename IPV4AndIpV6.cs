using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class IPV4AndIpV6 : IpValid
    {
        public override bool ipValidatorIpV4(string ip)
        {

            string pattern = "^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(ip))
            {

                DisplayMessageIpV4(true,ip);
                return true;

            }
            else
            {
                DisplayMessageIpV4(false,ip);
                return false;
            }

           
        }

        public override bool ipValidatorIpV6(string ip)
        {
            string pattern = @"^(([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|([0-9a-fA-F]{1,4}:){1,7}:|::([0-9a-fA-F]{1,4}:){1,7}|([0-9a-fA-F]{1,4}:){1,7}::)$";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(ip))
            {

                DisplayMessageIpV6(true,ip);
                return true;

            }
            else
            {
                DisplayMessageIpV6(false,ip);
                return false;
            }
        }
    }
}
