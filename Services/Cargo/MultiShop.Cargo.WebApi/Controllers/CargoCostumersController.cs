using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCostumersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;

        public CargoCostumersController(ICargoCustomerService cargoCustomerService)
        {
            _cargoCustomerService = cargoCustomerService;
        }

        [HttpGet]
        public IActionResult CargoCostumerList() 
        {
            var values = _cargoCustomerService.TGetAll();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoCostumerById(int id)
        {
            var value = _cargoCustomerService.TGetById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCargoCostumer(CreateCargoCostumerDto createCargoCostumerDto)
        {
            CargoCostumer cargoCostumer = new CargoCostumer()
            {
                Address = createCargoCostumerDto.Address,
                City = createCargoCostumerDto.City,
                District = createCargoCostumerDto.District,
                Email = createCargoCostumerDto.Email,
                Name =  createCargoCostumerDto.Name,
                Phone = createCargoCostumerDto.Phone,
                Surname = createCargoCostumerDto.Surname,
            };  
            _cargoCustomerService.TInsert(cargoCostumer);
            return Ok("Kargo müşteri ekleme başarıyla yapıldı");
        }

        [HttpDelete]
        public IActionResult RemoveCargoCostumer(int id)
        {
            _cargoCustomerService.TDelete(id);
            return Ok("Kargo müşteri silme işlemi başarıyla yapıldı");
        }

        [HttpPut]
        public IActionResult UpdateCargoCostumer(UpdateCargoCostumerDto updateCargoCostumerDto) 
        {
            CargoCostumer cargoCostumer = new CargoCostumer()
            {
                Address = updateCargoCostumerDto.Address,
                CargoCostumerId = updateCargoCostumerDto.CargoCostumerId,
                City = updateCargoCostumerDto.City,
                District = updateCargoCostumerDto.District,
                Email = updateCargoCostumerDto.Email,
                Name = updateCargoCostumerDto.Name,
                Phone = updateCargoCostumerDto.Phone,
                Surname = updateCargoCostumerDto.Surname,
            };
            _cargoCustomerService.TUpdate(cargoCostumer);
            return Ok("Kargo müşteri güncelleme işi başarıyla gerçekleştirildi");
        }
    }
}
