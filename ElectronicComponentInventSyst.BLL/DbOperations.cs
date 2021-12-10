using ElectronicComponentInventSyst.BLL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicComponentInventSyst.BLL
{
    public class DbOperations
    {
        private readonly ElectronicComponentInventoryDbContext _context;
        public DbOperations(ElectronicComponentInventoryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ElectronicComponents> GetComponents()
        {
            return _context.ElectronicComponents;
        }
    }
}
