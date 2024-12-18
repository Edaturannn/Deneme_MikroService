﻿using System;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Features.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class CreateOrderDetailCommandHandler
	{
		private readonly IRepository<OrderDetail> _repository;
		public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}
		public async Task Handle(CreateOrderDetailCommand createOrderDetailCommand)
		{
			await _repository.CreateAsync(new OrderDetail
			{
				ProductAmount = createOrderDetailCommand.ProductAmount,
				OrderDetailId = createOrderDetailCommand.OrderingId,
				ProductId = createOrderDetailCommand.ProductId,
				ProductName = createOrderDetailCommand.ProductName,
				ProductPrice = createOrderDetailCommand.ProductPrice,
				ProductTotalPrice = createOrderDetailCommand.ProductTotalPrice
            });
		}
    }
}

