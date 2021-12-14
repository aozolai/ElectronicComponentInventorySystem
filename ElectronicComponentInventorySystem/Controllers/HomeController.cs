using AutoMapper;
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
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, DbOperations operations, IMapper mapper)
        {
            _logger = logger;
            _operations = operations;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var components = _operations.GetComponents();
            return View(components);
        }

        public IActionResult AddPartForm()
        {
            return View();
        }

        public IActionResult ComponentList()
        {
            var components = _operations.GetComponents();
            var viewModel = new UI.Models.FilterViewModel()
            {
                FoundComponents = _mapper.Map<IEnumerable<UI.Models.ElectronicComponentsModel>>(components)
            };
            return View(viewModel);
        }

        public IActionResult DeleteComponent(int id)
        {
            _operations.RemoveComponent(id);
            return RedirectToAction("ComponentList");
        }

        public IActionResult Edit(int id)
        {
            var component = _operations.GetComponentById(id);
            var viewModel = _mapper.Map<UI.Models.ElectronicComponentsModel>(component);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(UI.Models.ElectronicComponentsModel viewModel)
        {
            var component = _mapper.Map<ElectronicComponentInventSyst.Entity.ElectronicComponents>(viewModel);
            _operations.UpdateComponent(component);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ComponentList(UI.Models.FilterViewModel viewModel)
        {
            IEnumerable<ElectronicComponentInventSyst.Entity.ElectronicComponents> components;
            if (string.IsNullOrWhiteSpace(viewModel.Search))
            {
                components = _operations.GetComponents();
            }
            else
            {
                components = _operations.GetComponentByName(viewModel.Search);
            }
            viewModel.FoundComponents = _mapper.Map<IEnumerable<UI.Models.ElectronicComponentsModel>>(components);
            return View(viewModel);
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
