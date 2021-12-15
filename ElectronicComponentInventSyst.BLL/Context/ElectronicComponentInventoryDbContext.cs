using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicComponentInventSyst.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ElectronicComponentInventSyst.BLL.Context
{
    public class ElectronicComponentInventoryDbContext : DbContext
    {
        private string connectionString;
        public ElectronicComponentInventoryDbContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("ComponetsDatabase");
        }

        public DbSet<ElectronicComponents> ElectronicComponents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(connectionString);
    }
}
