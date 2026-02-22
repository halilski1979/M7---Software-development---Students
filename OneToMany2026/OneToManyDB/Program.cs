using OneToManyDB.Data.Views;

namespace OneToManyDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manuView = new ManufacturerView();
            var modView= new ModelView();

            while (true)
            {
                Console.WriteLine("1. Add Manufacturer");
                Console.WriteLine("2. Show Manufacturer");
                Console.WriteLine("3. Delete Manufacturer");
                Console.WriteLine("4. Add Model");
                Console.WriteLine("5. Show Models");
                Console.WriteLine("6. Delete Model");
                Console.WriteLine("0. EXIT");

                Console.Write("Choice: ");
                string choice=Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": manuView.CreateManufacturer(); break;
                    case "2": manuView.ShowAll(); break;
                    case "3": manuView.DeleteManufacturer(); break;
                    case "4": modView.CreateModel(); break;
                    case "5": modView.ShowAll(); break;
                    case "6": modView.DeleteModel(); break;
                    case "0": return; 
                }
            }
        }
    }
}
