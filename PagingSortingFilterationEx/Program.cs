using Microsoft.EntityFrameworkCore;
using PagingSortingFilterationEx.Models;
using PagingSortingFilterationEx.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<CompanyContext>(
     opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomer, CustomerRepo>();
var app = builder.Build();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
