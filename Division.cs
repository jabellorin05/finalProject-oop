using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    internal class Division : IOtherOperations
    {
       

        public double DivisionI(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return 0;
        }
    }
}
