using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Entities;

public class VehicleReservation
{
    public VehicleReservation(Guid id, 
        RentCarReservationInfo rentCarReservationInfo, 
        IVehicle vehicle)
    {
        RentCarReservationInfo = rentCarReservationInfo;
        Vehicle = vehicle;
        Id = id;
    }
    
    public Guid Id { get; }

    private IVehicle Vehicle { get; }
    public RentCarReservationInfo RentCarReservationInfo { get; set; }
    
    public VehicleType VehicleType => Vehicle.VehicleType;
    
    public decimal CalculatePrice => Vehicle.CalculatePrice(RentCarReservationInfo);
}