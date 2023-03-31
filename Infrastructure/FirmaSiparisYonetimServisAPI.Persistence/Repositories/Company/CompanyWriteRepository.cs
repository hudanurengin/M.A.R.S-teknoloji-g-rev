using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.domain.Entities;
using FirmaSiparisYonetimServisAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Persistence.Repositories
{
    public class CompanyWriteRepository : WriteRepository<Company>, ICompanyWriteRepository
    {
        public CompanyWriteRepository(FirmaSiparisAPIDbContext context) : base(context)
        {
        }
        
    }
}
