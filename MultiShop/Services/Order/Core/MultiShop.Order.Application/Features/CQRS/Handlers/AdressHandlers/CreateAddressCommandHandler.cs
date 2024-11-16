using System;
using MultiShop.Order.Application.Features.CQRS.Commands.AdressCommands;
using MultiShop.Order.Application.Features.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AdressHandlers
{
	public class CreateAddressCommandHandler
	{
		private readonly IRepository<Address> _repository;
		public CreateAddressCommandHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}
		public async Task Handle(CreateAddressCommand createAddressCommand)
		{
            await _repository.CreateAsync(new Address
            {
                City = createAddressCommand.City,
                Detail = createAddressCommand.Description,
                District = createAddressCommand.District,
                UserId = createAddressCommand.UserId
            });
        }
    }
}

