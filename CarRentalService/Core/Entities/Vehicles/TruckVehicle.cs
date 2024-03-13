using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities.Vehicles;

public class TruckVehicle: BaseVehicle
{
    public TruckVehicle(string id) : base(id)
    {
    }

    public override VehicleType VehicleType => VehicleType.PickupTruck;

    public override decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo)
    {
        var baseSum = DaysBetweenRentDates(rentCarReservationInfo) * 30M;
        var years = (DateOnly.FromDateTime(DateTime.Now).DayNumber -
                     rentCarReservationInfo.DriverLicense.DateOfIssue.DayNumber) / 365;
        return years < 3 ? baseSum * 1.1M : baseSum;
    }
}