using System.Text.Json.Serialization;
using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;
using CarRentalService.Core.Entities.Vehicles;
using CarRentalService.Core.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IDataCustodian<IVehicle>, VehicleDataCustodian>();
builder.Services.AddSingleton<IDataCustodian<VehicleReservation>, VehicleReservationDataCustodian>();
builder.Services.AddSingleton<IDataManager, DataManager>();
builder.Services.AddSingleton<IVehicleRentalService, VehicleRentalService>();
builder.Services.AddSingleton<IVehicleFactory,  VehicleFactory>();

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

InitializeData(app.Services.GetRequiredService<IDataCustodian<IVehicle>>());

app.Run();

void InitializeData(IDataCustodian<IVehicle> data)
{
    data.Add(new SedanVehicle(Guid.NewGuid().ToString()));
    data.Add(new SuvVehicle(Guid.NewGuid().ToString()));
    data.Add(new TruckVehicle(Guid.NewGuid().ToString()));
    data.Add(new VanVehicle(Guid.NewGuid().ToString()));
}