using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Multiplication : Operations
    {
        public override double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
