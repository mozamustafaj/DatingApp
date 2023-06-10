using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. The order it is not important
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); //Lifetime.scopet - lifetime of the request
}); //options are passed into a function

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
