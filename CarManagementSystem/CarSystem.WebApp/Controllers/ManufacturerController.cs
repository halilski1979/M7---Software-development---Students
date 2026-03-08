using Microsoft.AspNetCore.Mvc;
using CarSystem.Services;
namespace CarSystem.WebApp.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly CarService service;

        public ManufacturerController(CarService service)
        {
            this.service = service;
        }

        // Показва всички марки и техните модели
        public IActionResult Index()
        {
            var manufacturers = service.GetAll();
            return View(manufacturers);
        }
        // Форма за добавяне на марка
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(string name, string country)
        {
            service.CreateManufacturer(name, country);
            return RedirectToAction("Index");
        }

        // GET: Manufacturer/AddModel
        public IActionResult AddModel()
        {
            // Вземаме всички производители, за да ги покажем в падащото меню
            var manufacturers = service.GetAll();
            return View(manufacturers);
        }

        // POST: Manufacturer/AddModel
        [HttpPost]
        public IActionResult AddModel(int manufacturerId, string name, int year)
        {
            // Използваме съществуващия метод от твоя CarService
            service.AddModel(manufacturerId, name, year);

            // Връщаме се към основния списък
            return RedirectToAction("Index");
        }

    }
}
