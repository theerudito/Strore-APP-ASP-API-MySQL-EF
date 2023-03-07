using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.DB_Context;
using Strore_APP_ASP_API_MySQL.Repositories;
using Strore_APP_ASP_API_MySQL.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
  options.UseMySQL(builder.Configuration.GetConnectionString("MyConnection"));
});

builder.Services.AddScoped<IClients, MClientsRepositories>();
builder.Services.AddScoped<IProducts, MProductsRepositories>();



builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

