using Microsoft.EntityFrameworkCore;
using Barbearia.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

var connectionString =
    $"Host={Environment.GetEnvironmentVariable("PGHOST")};" +
    $"Port={Environment.GetEnvironmentVariable("PGPORT")};" +
    $"Database={Environment.GetEnvironmentVariable("PGDATABASE")};" +
    $"Username={Environment.GetEnvironmentVariable("PGUSER")};" +
    $"Password={Environment.GetEnvironmentVariable("PGPASSWORD")};" +
    $"SSL Mode=Require;Trust Server Certificate=true";

builder.Services.AddDbContext<BarbeariaContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();
