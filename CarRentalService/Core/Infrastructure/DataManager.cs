using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Infrastructure;

public class DataManager:IDataManager
{
    private readonly IDataCustodian<IVehicle> _vehicleCustodian;
    private readonly IDataCustodian<VehicleReservation> _vehicleReservationCustodian;

    public DataManager(IDataCustodian<IVehicle> vehicleCustodian, IDataCustodian<VehicleReservation> vehicleReservationCustodian)
    {
        _vehicleCustodian = vehicleCustodian;
        _vehicleReservationCustodian = vehicleReservationCustodian;
    }

    public List<VehicleReservation> GetReservations()
    {
        return _vehicleReservationCustodian.GetAll()
            .OrderBy(x=>x.CalculatePrice)
            .ToList();
    }

    public bool DeleteReservation(Guid reservationId)
    {
        return _vehicleReservationCustodian.Remove(reservationId);
    }

    public VehicleReservation? GetReservation(Guid reservationId)
    {
        return _vehicleReservationCustodian.Get(reservationId);
    }

    public Guid ReserveCar(VehicleType vehicleType, RentCarReservationInfo rentCarReservationInfo)
    {
        var vehicle = _vehicleCustodian.GetAll().Where(x=>x.VehicleType == vehicleType).FirstOrDefault();
        if(vehicle == null)
        {
            throw new InvalidOperationException("No vehicle of the specified type is available");
        }
        
        return _vehicleReservationCustodian.Add(new VehicleReservation(Guid.NewGuid(), rentCarReservationInfo, vehicle)); 
    }
}