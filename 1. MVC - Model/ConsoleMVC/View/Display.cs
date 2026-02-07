using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.View
{
    public class Display
    {
        public Display()
        {            
            GetValues();
        }
        public double Amount { get; set; }
        public  double Percent { get; set; }
        public double TipAmount { get; set; }
        public double Total { get; set; }

        
        //Входни данни
        public void GetValues()
        {
            Console.Write("Amount: ");
            this.Amount = double.Parse(Console.ReadLine());

            Console.Write("Percent: ");
            this.Percent = double.Parse(Console.ReadLine());
        }

        //Изходни данни
        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Tip: {this.TipAmount}");
            Console.WriteLine($"Total: {this.Total}");
        }






    }
}
