using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities;

public class VanVehicle:BaseVehicle
{
    public VanVehicle(string id) : base(id)
    {
    }
    public override VehicleType VehicleType => VehicleType.Van;
    public override decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo)
    {
        return DaysBetweenRentDates(rentCarReservationInfo) * 22 * 1.1m;
    }
}