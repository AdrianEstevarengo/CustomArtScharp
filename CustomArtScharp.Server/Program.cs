using Microsoft.EntityFrameworkCore;
using CustomArtScharp.Server.Data.Context;
using CustomArtScharp.Server.Data.Context.Repositories;
using CustomArtScharp.Server.Data.Context.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Get connection string from configuration
var connectionString = builder.Configuration.GetConnectionString("CustomArtContextConnection")
    ?? throw new InvalidOperationException("Connection string 'CustomArtContextConnection' not found.");

// Add DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Register repositories
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IArteRepositorio, ArteRepositorio>();
builder.Services.AddScoped<IQuadroRepositorio, QuadroRepositorio>();
builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
