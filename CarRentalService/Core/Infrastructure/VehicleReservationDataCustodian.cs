using System.Collections.Concurrent;
using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;

namespace CarRentalService.Core.Infrastructure;

public class VehicleReservationDataCustodian: IDataCustodian<VehicleReservation>
{
    private readonly IDictionary<Guid, VehicleReservation> _data;

    public VehicleReservationDataCustodian()
    {
        _data = new ConcurrentDictionary<Guid, VehicleReservation>();
    }

    public Guid Add(VehicleReservation vehicle)
    {
        var guid = vehicle.Id;
        _data.Add(guid, vehicle);
        return guid;
    }

    public bool Remove(Guid vehicleId)
    {
        return _data.Remove(vehicleId);
    }

    public VehicleReservation? Get(Guid vehicleId)
    {
        return _data.TryGetValue(vehicleId, out var vehicle) ? vehicle : null;
    }

    public List<VehicleReservation> GetAll()
    {
        return _data.Values.ToList();
    }
}