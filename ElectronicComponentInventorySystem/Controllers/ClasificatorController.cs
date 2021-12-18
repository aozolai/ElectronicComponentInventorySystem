using AutoMapper;
using ElectronicComponentInventSyst.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem.UI.Controllers
{
    public class ClasificatorController : Controller
    {
        private readonly ILogger<ClasificatorController> _logger;
        private readonly DbOperations _operations;
        private readonly IMapper _mapper;

        public ClasificatorController(ILogger<ClasificatorController> logger, DbOperations operations, IMapper mapper)
        {
            _logger = logger;
            _operations = operations;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AddNewCategory(UI.Models.CategoryModel viewModel)
        {
            var category = _mapper.Map<ElectronicComponentInventSyst.Entity.Category>(viewModel);
            _operations.AddCategory(category);
            return RedirectToAction("AddPartForm", "Home");
        }
        [HttpPost]
        public IActionResult AddNewFootprint(UI.Models.FootprintModel viewModel)
        {
            var footprint = _mapper.Map<ElectronicComponentInventSyst.Entity.Footprint>(viewModel);
            _operations.AddFootprint(footprint);
            return RedirectToAction("AddPartForm", "Home");
        }
        [HttpPost]
        public IActionResult AddNewStorageLocation(UI.Models.StorageLocationModel viewModel)
        {
            var storageLocation = _mapper.Map<ElectronicComponentInventSyst.Entity.StoragaLocation>(viewModel);
            _operations.AddStorageLocation(storageLocation);
            return RedirectToAction("AddPartForm", "Home");
        }
    }
}
