using FirmaSiparisYonetimServisAPI.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Application.Abstractions
{
    //Projeye başlarken swagger uı ı ayağa kaldırmak için açılmış deneme sınıflarından biri
    public interface IProductService
    {
        List<Product> GetProducts(); 
    }
}
