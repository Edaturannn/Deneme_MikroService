using System;
using MultiShop.Discount.Context;
using MultiShop.Discount.Services;

namespace MultiShop.Discount
{
	public static class ServiceRegistration
	{
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<DapperContext>();
            services.AddScoped<IDiscountService, DiscountService>();
        }
    }
}

