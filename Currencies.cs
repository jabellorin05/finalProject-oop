using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Currencies
    {
        float cad, usd, eur, gpb, jpy, cny;





        public Currencies() { 
        
        }

        public float Cad { get => cad; set => cad = value; }
        public float Usd { get => usd; set => usd = value; }
        public float Euro { get => eur; set => eur = value; }
        public float Gpb { get => gpb; set => gpb = value; }
        public float Jpy { get => jpy; set => jpy = value; }
        public float Cny { get => cny; set => cny = value; }
    }
}
