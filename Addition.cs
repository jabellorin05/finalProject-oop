using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Addition : Operations
    {
        List<double> list = new List<double>();
        public override double Calculate(double num1,double num2)
        {
           
            return num1+num2;
        }

       
      

       
    }
}
