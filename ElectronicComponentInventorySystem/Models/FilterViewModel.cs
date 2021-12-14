using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem.UI.Models
{
    public class FilterViewModel
    {
        public string Search { get; set; }
        public IEnumerable<ElectronicComponentsModel> FoundComponents { get; set; }
    }
}
