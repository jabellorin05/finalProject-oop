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
        public override double Calculate(List<double> list)
        {
            double result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result -= list[i];

            }
          


            
            return result;
        }

        public override List<double> ListValues(double values)
        {
           

            list.Add(values);


            return list;
        }

        public List<double> GetList()
        {

            return list;



        }
    }
}
