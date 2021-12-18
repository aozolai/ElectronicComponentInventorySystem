using ElectronicComponentInventSyst.BLL.Context;
using ElectronicComponentInventSyst.Entity;
using Microsoft.EntityFrameworkCore;
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
            return _context.ElectronicComponents.Include(x => x.Category).Include(x => x.StorageLocation).Include(x => x.Footprint);
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
        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public IEnumerable<Footprint> GetFootprints()
        {
            return _context.Footprints;
        }
        public void AddFootprint(Footprint footprint)
        {
            _context.Footprints.Add(footprint);
            _context.SaveChanges();
        }
        public IEnumerable<StoragaLocation> GetStoragaLocations()
        {
            return _context.StoragaLocations;
        }
        public void AddStorageLocation(StoragaLocation storagaLocation)
        {
            _context.StoragaLocations.Add(storagaLocation);
            _context.SaveChanges();
        }
    }
}
