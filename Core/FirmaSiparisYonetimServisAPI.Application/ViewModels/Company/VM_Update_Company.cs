using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimServisAPI.Application.ViewModels.Company
{
    public class VM_Update_Company
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStartTime { get; set; }
        public string OrderFinishTime { get; set; }
    }
}
