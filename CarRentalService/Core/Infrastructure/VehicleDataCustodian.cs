using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using CarRentalService.Core.Domain;

namespace CarRentalService.Core.Infrastructure;

public class VehicleDataCustodian: IDataCustodian<IVehicle>
{
    private readonly IDictionary<Guid,IVehicle> _data;

    public VehicleDataCustodian()
    {
        _data = new ConcurrentDictionary<Guid, IVehicle>();
    }

    public Guid Add(IVehicle vehicle)
    {
        var guid = Guid.NewGuid();
        _data.Add(guid, vehicle);
        return guid;
    }

    public bool Remove(Guid vehicleId)
    {
        return _data.Remove(vehicleId);
    }

    public IVehicle? Get(Guid vehicleId)
    {
        return _data.TryGetValue(vehicleId, out var vehicle) ? vehicle : null;
    }

    public List<IVehicle> GetAll()
    {
        return _data.Values.ToList();
    }
}