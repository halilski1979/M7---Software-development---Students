using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazin1.Models;
using Magazin1.Views;

namespace Magazin1.Controllers
{
    public class Controller
    {
        public Model model  { get; set; }
        public View view { get; set; }

        public Controller()
        {
            view = new View();
            view.Input();
            model = new Model(view.PriceVEG,view.PriceFR,view.KgVEG,view.KgFR);

            view.Total=model.CalculateTotal();
            view.ShowTotal();

            view.Total = model.CalculateTotalBG();
            view.ShowTotalBGN();
        }

       
    }

}
