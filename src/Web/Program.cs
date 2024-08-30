using Core.Interfaces;
using Core.Services;
using Infrastructure.Configuration;
using Infrastructure.DatabaseSeeder;
using SQLitePCL;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);



raw.SetProvider(new SQLite3Provider_e_sqlite3());

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<Seeder>();
    seeder.SeedDatabase();  // Make sure this method is being called properly
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
