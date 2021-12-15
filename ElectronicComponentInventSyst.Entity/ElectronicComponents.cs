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
        public string Category { get; set; } //drop-down with values
        public string StorageLocation { get; set; } //drop-down with values
        public string Footprint { get; set; } // radio-button (none + dropdown)
        public int StockLevel { get; set; } // number managing field
        public string StockUser { get; set; }
    }
}
