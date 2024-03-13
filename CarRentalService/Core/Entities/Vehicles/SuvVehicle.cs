using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities;

public class SuvVehicle: BaseVehicle
{
    public SuvVehicle(string id) : base(id)
    {
    }

    public override VehicleType VehicleType => VehicleType.Suv;

    public override decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo)
    {
        var baseSum = DaysBetweenRentDates(rentCarReservationInfo) * 15M;
        return rentCarReservationInfo.Mileage > 0 ? baseSum + rentCarReservationInfo.Mileage * 0.5M : baseSum;
    }
}