using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Infrastructure;

public class VehicleFactory: IVehicleFactory
{
    public IVehicle CreateCar(CarCreateRequest carCreateRequest)
    {
        return carCreateRequest.VehicleType switch
        {
            VehicleType.Sedan => new SedanVehicle(Guid.NewGuid().ToString()),
            VehicleType.Suv => new SuvVehicle(Guid.NewGuid().ToString()),
            VehicleType.PickupTruck => new TruckVehicle(Guid.NewGuid().ToString()),
            VehicleType.Van => new VanVehicle(Guid.NewGuid().ToString()),
            _ => throw new ArgumentOutOfRangeException(nameof(carCreateRequest.VehicleType), carCreateRequest.VehicleType, null)
        };
    }
}