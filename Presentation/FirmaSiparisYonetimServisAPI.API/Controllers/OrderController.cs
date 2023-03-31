using FirmaSiparisYonetimServisAPI.Application.Abstractions;
using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.Application.ViewModels.Order;
using FirmaSiparisYonetimServisAPI.Application.ViewModels.Product;
using FirmaSiparisYonetimServisAPI.domain.Entities;
using FirmaSiparisYonetimServisAPI.Persistence.Contexts;
using FirmaSiparisYonetimServisAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FirmaSiparisYonetimServisAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        private readonly FirmaSiparisAPIDbContext _context;


        public OrderController(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository, FirmaSiparisAPIDbContext context)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {

            return Ok(await _orderReadRepository.GetByIdAsync(id));
        }

        //[HttpGet]
        //public async Task<IActionResult> Get(int CargoBarcode)
        //{

        //    var id = _context.Orders.FromSql($"SELECT Id FROM dbo.Orders WHERE CargoBarcode ={CargoBarcode}");

        //    return Ok(await _orderReadRepository.GetByIdAsync(id));
        //}
        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Order model)
        {
            await _orderWriteRepository.AddAsync(new()
            {
                OrdersName=model.OrdersName,
                Name=model.Name,
                ProductId=model.ProductId,
                CompanyId=model.CompanyId, 

            });
            await _orderWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}
