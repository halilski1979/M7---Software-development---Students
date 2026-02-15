using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin1.Views
{
    public class View
    {
        public double PriceVEG { get; set; }
        public double PriceFR { get; set; }
        public double KgVEG { get; set; }
        public double KgFR { get; set; }
        public double Total { get; set; }


       

        public void Input()
        {
            Console.Write("Price vegetable: ");
            this.PriceVEG=double.Parse(Console.ReadLine());
            Console.Write("Price fruit: ");
            this.PriceFR = double.Parse(Console.ReadLine());

            Console.Write("KG vegetable: ");
            this.KgVEG = double.Parse(Console.ReadLine());

            Console.Write("KG fruit: ");
            this.KgFR = double.Parse(Console.ReadLine());
        }

        public void ShowTotal()
        {
            Console.WriteLine($"Total in Euro = {Total:f2}");
        }

        public void ShowTotalBGN()
        {
            Console.WriteLine($"Total in Bgn = {Total:f2}");
        }
    }
}
