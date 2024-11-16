using System;
namespace MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
	public class GetOrderingByIdQuery
	{
		//Girilen parametre yani ID'ye göre getirir.
		public int Id { get; set; }
		public GetOrderingByIdQuery(int id)
		{
			Id = id;
		}
    }
}

