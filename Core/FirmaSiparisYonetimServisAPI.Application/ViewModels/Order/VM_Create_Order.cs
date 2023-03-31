using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Application.ViewModels.Order
{
    public class VM_Create_Order
    {
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string OrdersName { get; set; }
    }
}
