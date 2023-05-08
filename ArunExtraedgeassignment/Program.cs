using ArunExtraedgeassignment.Data;
using Microsoft.AspNetCore.Authentication;


using Microsoft.EntityFrameworkCore;

using Microsoft.OpenApi.Models;

using ArunExtraedgeassignment.Repository;

using ArunExtraedgeassignment.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IMobileRepository, MobileRepository>();
builder.Services.AddScoped<IMobileService, MobileService>();
builder.Services.AddScoped<ISalesReportReository, SalesReportRepository>();
builder.Services.AddScoped<ISalesReportService, SalesReportService>();
builder.Services.AddScoped<ISellRepository, SellRepository>();
builder.Services.AddScoped<ISellService, SellService>();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArunExtraaEdgeAssignment", Version = "v1" });
});
var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArunExtraaEdgeAssignment v1"));

app.Run();
