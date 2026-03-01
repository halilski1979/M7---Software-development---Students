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

        //Показване на списъка
        public IActionResult Index()
        {
            var list=service.GetAll();
            return View(list);
        }

        //Добавяне 
        public IActionResult Create() => View();
        public IActionResult Create(string firstName, string lastName, int cardNumber)
        {
            service.Create(firstName, lastName, cardNumber);
            return RedirectToAction("Index");
        }

    }
}
