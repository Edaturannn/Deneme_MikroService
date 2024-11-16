using System;
using MultiShop.Order.Application.Features.CQRS.Commands.AdressCommands;
using MultiShop.Order.Application.Features.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AdressHandlers
{
	public class UpdateAddressCommandHandler
	{
		private readonly IRepository<Address> _repository;
		public UpdateAddressCommandHandler(IRepository<Address> repository)
		{
			_repository = repository;
		}
		public async Task Handle(UpdateAddressCommand updateAddressCommand)
		{
			var values = await _repository.GetByIdAsync(updateAddressCommand.AddressId);
			values.Detail = updateAddressCommand.Detail;
			values.District = updateAddressCommand.District;
			values.City = updateAddressCommand.City;
			values.UserId = updateAddressCommand.UserId;
			await _repository.UpdateAsync(values);

        }
    }
}

