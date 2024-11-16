using System;
namespace MultiShop.Order.Application.Features.CQRS.Queries.AdressQueries
{
	public class GetAddressByIdQuery
	{
		public GetAddressByIdQuery(int id)
		{
			Id = id;
		}
		public int Id { get; set; }
    }
}

