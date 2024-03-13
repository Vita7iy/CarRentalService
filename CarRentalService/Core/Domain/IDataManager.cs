using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Domain;

public interface IDataManager
{
    List<VehicleReservation> GetReservations();
    bool DeleteReservation(Guid reservationId);
    VehicleReservation? GetReservation(Guid reservationId);
    Guid ReserveCar(VehicleType vehicleType, RentCarReservationInfo rentCarReservationInfo);
}