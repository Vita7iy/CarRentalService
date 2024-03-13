using CarRentalService.Core.Entities;
using CarRentalService.Core.Infrastructure;
using CarRentalService.Core.Infrastructure.Requests;

namespace CarRentalService.Core.Domain;

public interface IVehicleRentalService
{
        Guid ReserveCar(RentCarReservationRequestInfo rentCarReservationInfo);
        
        RentCarReservationInfo? GetReservationInfo(Guid reservationId);
        VehicleReservation ModifyReservation(Guid reservationId, RentCarReservationInfo rentCarReservationInfo);
        bool CancelReservation(Guid reservationId);
        List<VehicleReservation> GetReservationOptions();
}