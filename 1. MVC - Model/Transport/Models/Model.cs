using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    public class Model
    {
        private double km;
        private string time;
        private double startPrice;

        public Model(double km, string time)
        {
            this.Km = km;
            this.Time = time;
        }

        public double Km
        {
            get { return km; }
            set { km = value; }
        }       

        public double StartPrice
        {
            get { return startPrice; }
            set { startPrice = value; }
        }        
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public double ClaculateCheapest()
        {
            double PricePerKm = 0;

            if (km <= 20)
            {
                //Taxi
                startPrice = 0.70;
                if (time=="day")
                {
                    PricePerKm = 0.79;
                }
                else
                {
                    PricePerKm = 0.90;
                }
            }
            else if (km>20 && km<=100)
            {
                //Bus
                startPrice = 0;
                PricePerKm = 0.09;
            }
            else
            {
                //Train
                startPrice = 0;
                PricePerKm = 0.06;
            }
            return PricePerKm;
        }

        public double CalculatePrice()
        {
            return km * ClaculateCheapest() + startPrice;
        }


    }
}
