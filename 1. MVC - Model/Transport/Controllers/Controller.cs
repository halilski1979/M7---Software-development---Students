using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models;
using Transport.Views;

namespace Transport.Controllers
{
    public class Controller
    {
        public View view { get; set; }
        public Model model { get; set; }

        public Controller()
        {
            view = new View();
            model = new Model(view.KM,view.TIME);

            view.TotalPRICE=model.CalculatePrice();
            view.ShowTotalPrice();
        }
    }
}
