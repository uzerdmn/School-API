
using school_api.Src.Infrastructure.Context;
using school_api.Src.Application.Common.Interfaces;
using school_api.Src.Application.Common.Services;

using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHttpContextAccessor();

builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Trace);




//  _____dependency injection


// SQL Server
builder.Services.AddDbContext<SchoolDataBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


// Services
builder.Services.AddScoped<IPasswordHasherService, PasswordHasherService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapControllers();


app.Run();
