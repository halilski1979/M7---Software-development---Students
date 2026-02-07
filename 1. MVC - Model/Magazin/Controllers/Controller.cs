using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazin.Models;
using Magazin.Views;

namespace Magazin.Controllers
{
    public class Controller
    {
        public Model model { get; set; }
        public View view { get; set; }


        public Controller()
        {
            view = new View();
            model = new Model(view.PriceVeg,view.PriceFr,view.KgVeg,view.KgFr);

            view.Total=model.CalculateTotal();
            view.Output();
        }

        

    }
}
