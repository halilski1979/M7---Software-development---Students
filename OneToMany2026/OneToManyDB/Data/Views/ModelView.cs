using OneToManyDB.Data.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDB.Data.Views
{
    public class ModelView
    {
        ModelController controller=new ModelController();

        public void CreateModel()
        {
            Console.Write("Model name: ");
            string model=Console.ReadLine();

            Console.Write("Manufacturer ID: ");
            int manuId=int.Parse(Console.ReadLine());

            controller.Create(model,manuId);
            Console.WriteLine($"Model {model} is added to id[{manuId}]");
        }

        public void DeleteModel()
        {
            Console.Write("Model ID: ");
            int modelId = int.Parse(Console.ReadLine());
            controller.Delete(modelId);
            Console.WriteLine("Deleted");
        }

        public void ShowAll()
        {
            controller.PrintAll();
        }

    }
}
