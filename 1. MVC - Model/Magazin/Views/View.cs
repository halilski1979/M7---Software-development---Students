using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin.Views
{
    public class View
    {
        public double PriceVeg { get; set; }
        public double PriceFr { get; set; }
        public double KgVeg { get; set; }
        public double KgFr { get; set; }
        public double Total { get; set; }

        public View()
        {
            Input();
        }

        public void Input()
        {
            Console.Write("Price Vegetable: ");
            this.PriceVeg=double.Parse(Console.ReadLine());

            Console.Write("Price Fruit: ");
            this.PriceFr = double.Parse(Console.ReadLine());

            Console.Write("Kg Vegetable: ");
            this.KgVeg = double.Parse(Console.ReadLine());

            Console.Write("Kg Fruit: ");
            this.KgFr = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"Total {Total:f2} EURO");
        }
    }
}
