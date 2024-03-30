using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;
using System.Globalization;
using WebApplication9;
using WebApplication9.Repository;
using WebApplication9.Repository.IRepository;
using static System.Formats.Asn1.AsnWriter;
using AutoMapper;
using WebApplication9.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IVentasRepositorio, VentaRepositorio>();
builder.Services.AddScoped<Response>();

builder.Services.AddAutoMapper(typeof(MappingConfig));


var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<MappingConfig>();
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
try
{
    config.AssertConfigurationIsValid();
    Console.WriteLine("Configuracion de AutoMapper validad");
}catch(AutoMapperConfigurationException ex)
{
    Console.WriteLine($"{ex.Message}");
}

builder.Services.AddDbContext<PuntoDeVentaDtoContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conection"));
});



var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<PuntoDeVentaDtoContext>();
    dataContext.Database.Migrate();
}

// Configurar opciones de localización

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

