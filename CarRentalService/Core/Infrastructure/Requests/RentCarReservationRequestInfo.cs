using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Infrastructure;

public class RentCarReservationRequestInfo: RentCarReservationInfo
{
    public RentCarReservationRequestInfo(VehicleType vehicleType, DriverLicense driverLicense, DateOnly rentFrom, DateOnly rentTo) 
        : base(driverLicense, rentFrom, rentTo)
    {
        VehicleType = vehicleType;
    }
    
    public VehicleType VehicleType { get; }
}