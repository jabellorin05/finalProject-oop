using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class CtoF : Temperature
    {

        public override double ConvertTemp(double temp)
        {
            return temp * 9 / 5 + 32;
        }

    }
}
