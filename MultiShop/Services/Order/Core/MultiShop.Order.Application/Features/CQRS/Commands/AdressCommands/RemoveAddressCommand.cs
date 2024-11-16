using System;
namespace MultiShop.Order.Application.Features.CQRS.Commands.AdressCommands
{
	public class RemoveAddressCommand
	{
        public int Id { get; set; }

        public RemoveAddressCommand(int id)
        {
            Id = id;
        }
    }
}

