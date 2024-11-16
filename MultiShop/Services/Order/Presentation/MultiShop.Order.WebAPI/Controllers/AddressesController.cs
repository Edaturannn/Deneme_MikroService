using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.CQRS.Commands.AdressCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.AdressHandlers;
using MultiShop.Order.Application.Features.CQRS.Queries.AdressQueries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MultiShop.Order.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AddressesController : Controller
    {
        private readonly GetAddressQueryHandler _getAddressQueryHandler;

        private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;

        private readonly CreateAddressCommandHandler _createAddressCommandHandler;

        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;

        private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

        public AddressesController(GetAddressQueryHandler getAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler, RemoveAddressCommandHandler removeAddressCommandHandler)
        {
            _getAddressQueryHandler = getAddressQueryHandler;
            _getAddressByIdQueryHandler = getAddressByIdQueryHandler;
            _createAddressCommandHandler = createAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
            _removeAddressCommandHandler = removeAddressCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var values = await _getAddressQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AddressListById(int id)
        {
            var values = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> AddressCreate(CreateAddressCommand createAddressCommand)
        {
            await _createAddressCommandHandler.Handle(createAddressCommand);
            return Ok("Başarılı Bir Şekilde Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> AddressUpdate(UpdateAddressCommand updateAddressCommand)
        {
            await _updateAddressCommandHandler.Handle(updateAddressCommand);
            return Ok("Başarılı Bir Şekilde Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> AddressDelete(RemoveAddressCommand removeAddressCommand)
        {
            await _removeAddressCommandHandler.Handle(removeAddressCommand);
            return Ok("Başarılı Bir Şekilde Silindi");
        }
    }
}

