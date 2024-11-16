using System;
namespace MultiShop.Order.Application.Features.Mediator.Commands.OrderingCommands
{
	public class RemoveOrderingCommand
	{
		public int Id { get; set; }
		public RemoveOrderingCommand(int id)
		{
			Id = id;
		}
    }
}

