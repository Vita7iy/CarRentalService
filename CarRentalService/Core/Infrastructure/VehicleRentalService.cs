using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;
using CarRentalService.Core.Infrastructure.Requests;

namespace CarRentalService.Core.Infrastructure;

public class VehicleRentalService : IVehicleRentalService
{
    private readonly IDataManager _dataManager;

    public VehicleRentalService(IDataManager dataManager)
    {
        _dataManager = dataManager;
    }

    public Guid ReserveCar(RentCarReservationRequestInfo rentCarReservationInfo)
    {
        return _dataManager.ReserveCar(rentCarReservationInfo.VehicleType, rentCarReservationInfo);
    }

    public RentCarReservationInfo? GetReservationInfo(Guid reservationId)
    {
        return _dataManager.GetReservation(reservationId)?.RentCarReservationInfo;
    }

    public VehicleReservation ModifyReservation(Guid reservationId, RentCarReservationInfo rentCarReservationInfo)
    {
        var reservation = _dataManager.GetReservation(reservationId);
        if (reservation == null)
        {
            throw new InvalidOperationException("Reservation not found");
        }
        reservation.RentCarReservationInfo = rentCarReservationInfo;
        return reservation;
    }

    public bool CancelReservation(Guid reservationId)
    {
        return _dataManager.DeleteReservation(reservationId);
    }

    public List<VehicleReservation> GetReservationOptions()
    {
        return _dataManager.GetReservations();
    }
}