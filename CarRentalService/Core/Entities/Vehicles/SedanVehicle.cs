using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities.Vehicles;

public class SedanVehicle: BaseVehicle
{
    public SedanVehicle(string id) : base(id)
    {
    }
    public override VehicleType VehicleType => VehicleType.Sedan;

    public override decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo)
    {
        var days = DaysBetweenRentDates(rentCarReservationInfo);
        return days > 10 ? days * 15M : days * 20M;
    }
}