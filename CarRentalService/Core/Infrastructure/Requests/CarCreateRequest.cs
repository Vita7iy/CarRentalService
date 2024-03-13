using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Infrastructure.Requests;

public class CarCreateRequest
{
    public VehicleType VehicleType { get; set; }
}