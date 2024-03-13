using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities;

public abstract class BaseVehicle: IVehicle
{
    protected BaseVehicle(string id)
    {
        Id = id;
    }

    public string Id { get; }
    public abstract VehicleType VehicleType { get; }
    public abstract decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo);
    
    protected int DaysBetweenRentDates(RentCarReservationInfo rentCarReservationInfo)
    {
        return (rentCarReservationInfo.RentTo.DayNumber - rentCarReservationInfo.RentFrom.DayNumber) + 1;
    }
}