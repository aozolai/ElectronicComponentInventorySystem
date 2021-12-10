using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem.UI.Models
{
    public class ElectronicComponents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; } //drop-down with values
        public string StorageLocation { get; set; } //drop-down with values
        public string Footprint { get; set; } // radio-button (none + dropdown)
        public int StockLevel { get; set; } // number managing field
        public string StockUser { get; set; }
    }
}
