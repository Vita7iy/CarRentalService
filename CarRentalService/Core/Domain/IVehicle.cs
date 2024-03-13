using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Domain;

public enum VehicleType
{
    Sedan,
    Van,
    Suv,
    PickupTruck
}

public interface IVehicle
{
    VehicleType VehicleType { get; }
    public decimal CalculatePrice(RentCarReservationInfo rentCarReservationInfo);
}