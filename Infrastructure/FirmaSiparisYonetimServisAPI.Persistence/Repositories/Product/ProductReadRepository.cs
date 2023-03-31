using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.domain.Entities;
using FirmaSiparisYonetimServisAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(FirmaSiparisAPIDbContext context) : base(context)
        {
        }
    }
}
