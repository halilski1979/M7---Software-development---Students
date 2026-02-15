using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin1.Models
{
    public class Model
    {
		private double priceVeg;
        private double priceFr;
        private double kgVeg;
        private double kgFr;

        public Model(double priceVeg, double priceFr, double kgVeg, double kgFr)
        {
            this.PriceVeg = priceVeg;
            this.PriceFr = priceFr;
            this.KgVeg = kgVeg;
            this.KgFr = kgFr;
        }

        public double PriceVeg
		{
			get { return priceVeg; }
			set 
			{
                if (value<0)
                {
					throw new ArgumentException("Ne moje da byde otricatelno");
                }
				else
				{
                    priceVeg = value;
                }
              
			}
		}
				

		public double PriceFr
		{
			get { return priceFr; }
			set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Ne moje da byde otricatelno");
                }
                else
                {
                    priceFr = value;
                }
            }
		}

		public double KgFr
		{
			get { return kgFr; }
			set { kgFr = value; }
		}
				

		public double KgVeg
		{
			get { return kgVeg; }
			set { kgVeg = value; }
		}

		public double CalculateTotal()
		{
			return ((this.PriceVeg * this.KgVeg) + (this.PriceFr * this.KgFr)) / 1.94;
		}

        public double CalculateTotalBG()
        {
            return ((this.PriceVeg * this.KgVeg) + (this.PriceFr * this.KgFr));
        }

    }
}
