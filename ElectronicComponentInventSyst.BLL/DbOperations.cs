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
        public void AddPart(ElectronicComponents electronicComponent)
        {
            _context.Add(electronicComponent);
            _context.SaveChanges();
        }
        public IEnumerable<ElectronicComponents> GetComponents()
        {
            return _context.ElectronicComponents;
        }
        public ElectronicComponents GetComponentById(int id)
        {
            return _context.ElectronicComponents.Find(id);
        }
        public IEnumerable<ElectronicComponents> GetComponentByName(string name)
        {
            return _context.ElectronicComponents.Where(x => x.Name == name);
        }
        public void UpdateComponent(ElectronicComponents electronicComponent)
        {
            _context.Update(electronicComponent);
            _context.SaveChanges();
        }
        public void RemoveComponent(int id)
        {
            var electronicComponent = GetComponentById(id);
            if (electronicComponent != null)
            {
                _context.ElectronicComponents.Remove(electronicComponent);
                _context.SaveChanges();
            }
        }
    }
}
