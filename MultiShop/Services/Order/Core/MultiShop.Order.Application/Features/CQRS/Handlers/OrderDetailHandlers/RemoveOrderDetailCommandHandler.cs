using System;
using MultiShop.Order.Application.Features.CQRS.Commands.AdressCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.AdressHandlers;
using MultiShop.Order.Application.Features.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class RemoveOrderDetailCommandHandler
	{
        private readonly IRepository<OrderDetail> _repository;
		public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAddressCommand removeAddressCommand)
        {
            var values = await _repository.GetByIdAsync(removeAddressCommand.Id);
            await _repository.DeleteAsync(values);
        }
    }
}