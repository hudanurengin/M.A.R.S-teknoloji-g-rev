using FirmaSiparisYonetimServisAPI.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Persistence.Contexts
{
    public class FirmaSiparisAPIDbContext : DbContext
    {
        public FirmaSiparisAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies{ get; set; }
    }
}
