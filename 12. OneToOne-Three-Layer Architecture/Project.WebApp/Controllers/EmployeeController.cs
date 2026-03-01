using Microsoft.AspNetCore.Mvc;
using Project.Services;

namespace Project.WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService service;

        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        // Показване на всички (Read)
        public IActionResult Index()
        {
            var list = service.GetAll();
            return View(list);
        }

        // Форма за добавяне (Create - GET)
        public IActionResult Create() => View();

        // Записване (Create - POST)
        [HttpPost]
        public IActionResult Create(string firstName, string lastName, string cardNumber)
        {
            service.Create(firstName, lastName, cardNumber);
            return RedirectToAction("Index");
        }
    }
}
