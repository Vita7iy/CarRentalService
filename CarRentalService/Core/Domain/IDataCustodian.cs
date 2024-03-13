namespace CarRentalService.Core.Domain;

public interface IDataCustodian<T>
{
    Guid Add(T vehicle);
    bool Remove(Guid vehicleId);
    T? Get(Guid vehicleId);
    List<T> GetAll();
}