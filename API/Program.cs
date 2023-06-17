using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. The order it is not important
builder.Services.AddControllers();
builder.Services.addApplicationServices(builder.Configuration);  // we get from extensions follder
builder.Services.AddIdentityServices(builder.Configuration); // we get from extensions follder

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

//We need to put authentication middleware before mapcontroller and after useCors
app.UseAuthentication(); //Do you have a valid token
app.UseAuthorization(); //what are you allowed to do

app.MapControllers();

app.Run();
