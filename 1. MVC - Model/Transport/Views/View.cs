using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Views
{
    public class View
    {
        public double KM { get; set; }
        public string TIME { get; set; }
        public double TotalPRICE { get; set; }

        public View()
        {
            Console.Write("Enter km: ");
            this.KM = double.Parse(Console.ReadLine());

            Console.Write("Enter time: ");
            this.TIME= Console.ReadLine();
        }

        public void ShowTotalPrice()
        {
            Console.WriteLine($"Total price: {TotalPRICE:f2}");
        }

    }
}
