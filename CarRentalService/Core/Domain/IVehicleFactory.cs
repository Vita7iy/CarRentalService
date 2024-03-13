using CarRentalService.Core.Infrastructure;
using CarRentalService.Core.Infrastructure.Requests;

namespace CarRentalService.Core.Domain;

public interface IVehicleFactory
{
    IVehicle CreateCar(CarCreateRequest carCreateRequest);
}