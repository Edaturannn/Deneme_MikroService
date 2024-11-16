using AutoMapper;
using Microsoft.Extensions.Options;
using MultiShop.Catalog;
using MultiShop.Catalog.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices(); //ServiceRegistration class ile harici olarak serviceleri classın içine yazdım burada çağırıdm. yazdığım methodu çağırıdm.

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings")); //DatabaseSettings key ismi ben buraya istediğim şeyi yazabilirin appsetting.json içine.

builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});


builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings")); //DatabaseSettings key ismi ben buraya istediğim şeyi yazabilirin appsetting.json içine.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

