using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Subtraction : Operations
    {
        List<double> list = new List<double>();
    

        public override List<double> ListValues(double values)
        {
           

            list.Add(values);


            return list;
        }

        public List<double> GetList()
        {

            return list;



        }

        public override double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
