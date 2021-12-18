using System;
using System.ComponentModel.DataAnnotations;

namespace ElectronicComponentInventSyst.Entity
{
    public class ElectronicComponents
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; } //drop-down with values
        public int? StorageLocationId { get; set; }
        public StoragaLocation StorageLocation { get; set; } //drop-down with values
        public int? FootprintId { get; set; }
        public Footprint Footprint { get; set; } // radio-button (none + dropdown)
        public int StockLevel { get; set; } // number managing field
        public string StockUser { get; set; }
    }
}
