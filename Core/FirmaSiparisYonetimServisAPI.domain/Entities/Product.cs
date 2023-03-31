using FirmaSiparisYonetimServisAPI.domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.domain.Entities
{
    public class Product :BaseEntity
    {
        public int CompanyId { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public Company company { get; set; }
        public ICollection<Order> Orders { get; set;}
        //public ICollection<Company> Companies { get; set; }
    }
}
