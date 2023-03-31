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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(FirmaSiparisAPIDbContext context) : base(context)
        {
        }
    }
}
