using BHDSeguros.Application.Servicios.SecureApplications;
using BHDSeguros.Domain.Interfaces.Repository.Client;
using BHDSeguros.Domain.Interfaces.Repository.SecureApplication;
using BHDSeguros.Domain.Interfaces.Services.SecureApplication;
using BHDSeguros.Infrastructure.Context;
using BHDSeguros.Infrastructure.Repository.Client;
using Facturacion.Infrastructure.Repository.SecureApplication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.+
builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//IMapper mapper, ISecureApplicationRepository secureApplicationRepository ,IClientRepository clientRepository, ISecurePlansRepository securePlansRepository
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ISecureApplicationRepository, SecureApplicationRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<ISecurePlansRepository, SecurePlansRepository>();
builder.Services.AddScoped<IClientSecureRepository, ClientSecureRepository>();
builder.Services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
builder.Services.AddScoped<ISecureApplicationService, SecureApplicationService>();


builder.Services.AddControllers();

var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
