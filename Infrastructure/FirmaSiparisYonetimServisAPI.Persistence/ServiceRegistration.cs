using Microsoft.EntityFrameworkCore;
using FirmaSiparisYonetimServisAPI.Application.Abstractions;
using FirmaSiparisYonetimServisAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using FirmaSiparisYonetimServisAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.Persistence.Repositories;

namespace FirmaSiparisYonetimServisAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddDbContext<FirmaSiparisAPIDbContext>(options => options.UseSqlServer("Server=DESKTOP-90EA4VD;Database=FirmaSiparisAPIDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddDbContext<FirmaSiparisAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString),ServiceLifetime.Singleton);
            services.AddScoped<ICompanyReadRepository,CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository,CompanyWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
