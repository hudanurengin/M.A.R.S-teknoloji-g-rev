using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.domain.Entities.Common;
using FirmaSiparisYonetimServisAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity

    {
        private readonly FirmaSiparisAPIDbContext _context;

        public ReadRepository(FirmaSiparisAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(int id)
            => await Table.FirstOrDefaultAsync(data =>data.Id == id);
        //=> await Table.FindAsync(Guid.Parse(id));

        public async Task<T> GetRMADataByRMACode(int CargoBarcode)
        {
            var id = _context.Orders.FromSql($"SELECT Id FROM dbo.Orders").Where(m => m.CargoBarcode == CargoBarcode).First();
            //var id = _context.Orders.FromSql($"SELECT Id FROM dbo.Orders").Where(x => x.RMACode == rmacode).FirstOrDefault();
            return await Table.FindAsync(id);
        }
    }
}
