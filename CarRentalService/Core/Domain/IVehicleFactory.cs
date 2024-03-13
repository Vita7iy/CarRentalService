using CarRentalService.Core.Infrastructure;

namespace CarRentalService.Core.Domain;

public interface IVehicleFactory
{
    IVehicle CreateCar(CarCreateRequest carCreateRequest);
}