using FirmaSiparisYonetimServisAPI.Application.Repositories;
using FirmaSiparisYonetimServisAPI.Application.ViewModels.Company;
using FirmaSiparisYonetimServisAPI.domain.Entities;
using FirmaSiparisYonetimServisAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirmaSiparisYonetimServisAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        readonly private ICompanyWriteRepository _companyWriteRepository;
        readonly private ICompanyReadRepository  _companyReadRepository;

        public CompanyController(ICompanyWriteRepository companyWriteRepository, ICompanyReadRepository companyReadRepository)
        {
            _companyWriteRepository = companyWriteRepository;
            _companyReadRepository = companyReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_companyReadRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Company model)
        {
            await _companyWriteRepository.AddAsync(new()
            {
                
                Name=model.Name,
                OrderStatus=model.OrderStatus,
                OrderStartTime=model.OrderStartTime,
                OrderFinishTime=model.OrderFinishTime,
                
                
            });
            await _companyWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Company model)
        {
            Company company = await _companyReadRepository.GetByIdAsync(model.Id);
            company.OrderStatus = model.OrderStatus;
            company.OrderStartTime=model.OrderStartTime;
            company.OrderFinishTime=model.OrderFinishTime;
            await _companyWriteRepository.SaveAsync();
            return Ok();
        }

    }


}
