using FirmaSiparisYonetimServisAPI.domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.domain.Entities
{
    public class Company: BaseEntity
    {
        
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStartTime { get; set; }
        public string OrderFinishTime { get; set; }

        //public Order Order { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
