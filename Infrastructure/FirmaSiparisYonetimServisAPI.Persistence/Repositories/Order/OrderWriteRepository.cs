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
    internal class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(FirmaSiparisAPIDbContext context) : base(context)
        {
        }
    }
}
