using MarketProject.Datas.Context;
using MarketProject.DependencyInjections;
using MarketProject.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MarketDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("defaultServer"));
});
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddRepositoryLayer();
builder.Services.AddServiceLayer();
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
