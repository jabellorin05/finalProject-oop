using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Subtraction : Operations
    {
        public override double Calculate(List<double> list)
        {
            double result = 0;
            foreach (var value in list)
            {

                result -= value;


            }
            return result;
        }

        public override List<double> ListValues(double values)
        {
            List<double> list = new List<double>();

            list.Add(values);


            return list;
        }
    }
}
