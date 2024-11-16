using System;
using System.Reflection;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.AdressHandlers;
using MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using MultiShop.Order.Application.Features.Interfaces;
using MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers;
using MultiShop.Order.Domain.Entities;
using MultiShop.Order.Persistence.Context;
using MultiShop.Order.Persistence.Repositories;


namespace MultiShop.Order.WebAPI
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<OrderContext>();

            // MediatR'ı ve handler'ları kaydedin
            services.AddMediatR(typeof(GetOrderingQueryHandler).Assembly);

            services.AddMediatR(typeof(CreateAddressCommandHandler).Assembly);


            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<CreateAddressCommandHandler>();
            services.AddScoped<GetAddressByIdQueryHandler>();
            services.AddScoped<GetAddressQueryHandler>();
            services.AddScoped<RemoveAddressCommandHandler>();
            services.AddScoped<UpdateAddressCommandHandler>();


            services.AddScoped<CreateOrderDetailCommandHandler>();
            services.AddScoped<GetOrderDetailByIdQueryHandler>();
            services.AddScoped<GetOrderDetailQueryHandler>();
            services.AddScoped<RemoveOrderDetailCommandHandler>();
            services.AddScoped<UpdateOrderDetailCommandHandler>();


        }
    }
}

