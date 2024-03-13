using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Infrastructure;

public class CarCreateRequest
{
    public VehicleType VehicleType { get; set; }
}