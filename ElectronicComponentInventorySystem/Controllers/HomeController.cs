using ElectronicComponentInventorySystem.Models;
using ElectronicComponentInventSyst.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbOperations _operations;

        public HomeController(ILogger<HomeController> logger, DbOperations operations)
        {
            _logger = logger;
            _operations = operations;
        }

        public IActionResult Index()
        {
            var components= _operations.GetComponents();
            return View(components);
        }

        public IActionResult AddPartForm()
        {
            return View();
        }

        public IActionResult ComponentList()
        {
            var components = _operations.GetComponents();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ModifyViewData(string name, string description, string category, string storageLocation, string footprint, int stockLevel, string stockUser)
        {
            return RedirectToAction("AddPartForm");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
