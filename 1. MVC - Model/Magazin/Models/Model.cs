using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Models
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

        public double KgFr
		{
			get { return kgFr; }
			set { kgFr = value; }
		}
		public double PriceVeg
		{
			get { return priceVeg; }
			set { priceVeg = value; }
		}	
		public double PriceFr
		{
			get { return priceFr; }
			set { priceFr = value; }
		}	
		public double KgVeg
		{
			get { return kgVeg; }
			set { kgVeg = value; }
		}	
		
		public double CalculateTotal()
		{
			return (PriceFr*KgFr+PriceVeg*KgVeg)/1.94;
		}


	}
}
