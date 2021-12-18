using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem.UI.Models
{
    public class ElectronicComponentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? StorageLocationId { get; set; } //drop-down with values
        public string StorageLocationName { get; set; }
        public int? FootprintId { get; set; } // radio-button (none + dropdown)
        public string FootprintName { get; set; }
        public int StockLevel { get; set; } // number managing field
        public string StockUser { get; set; }

        public List<CategoryModel> Categories { get; set; }
        public List<FootprintModel> Footprints { get; set; }
        public List<StorageLocationModel> StorageLocations { get; set; }

    }
}
