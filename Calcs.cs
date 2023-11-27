using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Calcs
    {
        //private varibles
        float value,cad, usd, eur, gpb, jpy, cny;



        //constructor with 1 parameter
       public Calcs(float value) { 
        
        this.Value = value;
        }

        public float Cad { get => cad; set => cad = value; }
        public float Usd { get => usd; set => usd = value; }
        public float Euro { get => eur; set => eur = value; }
        public float Gpb { get => gpb; set => gpb = value; }
        public float Jpy { get => jpy; set => jpy = value; }
        public float Cny { get => cny; set => cny = value; }
        public float Value { get => value; set => this.value = value; }

        public Currencies FromCad()
        {
            Currencies currencies = new Currencies();

            this.Cad = Value;
            currencies.Cad = Value;   
            currencies.Usd = Cad* 0.73f;
            currencies.Gpb = Cad * 0.59f;
            currencies.Euro = Cad * 0.67f;
            currencies.Jpy = Cad * 110.54f;
            currencies.Cny = Cad * 5.30f;



            return currencies;


        }

        public Currencies FromUSD()
        {
            Currencies currencies = new Currencies();


            this.Usd = Value;
            currencies.Usd = Usd;
            currencies.Cad = Usd * 1.37f;
            currencies.Gpb = Usd * 0.81f;
            currencies.Euro = Usd * 0.92f;
            currencies.Jpy = Usd * 151.29f;
            currencies.Cny = Usd * 7.26f;



            return currencies;

            
        }

        public Currencies FromGpb()
        {
            Currencies currencies = new Currencies();


           
            currencies.Cad = Value * 1.70f;
            currencies.Usd = Value * 1.24f;
            currencies.Gpb = Value;
            currencies.Euro = Value * 1.14f;
            currencies.Jpy = Value * 187.41f;
            currencies.Cny = Value * 8.99f;



            return currencies;


        }


        public Currencies FromEur()
        {
            Currencies currencies = new Currencies();



            currencies.Cad = Value * 1.48f;
            currencies.Usd = Value * 1.08f;
            currencies.Gpb = Value* 0.87f;
            currencies.Euro = Value;
            currencies.Jpy = Value * 163.90f;
            currencies.Cny = Value * 7.87f;



            return currencies;


        }

        public Currencies FromJpy()
        {
            Currencies currencies = new Currencies();



            currencies.Cad = Value * 0.0091f;
            currencies.Usd = Value * 0.0066f;
            currencies.Gpb = Value * 0.0053f;
            currencies.Euro = Value* 0.0061f;
            currencies.Jpy = Value;
            currencies.Cny = Value * 0.048f;



            return currencies;


        }




    }
}
