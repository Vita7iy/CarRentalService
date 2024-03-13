using CarRentalService.Core.Domain;
using CarRentalService.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController: ControllerBase
{
    private readonly IDataCustodian<IVehicle> _vehicleDataCustodian;
    private readonly IVehicleFactory _vehicleFactory;

    public CarsController(IDataCustodian<IVehicle> vehicleDataCustodian, IVehicleFactory vehicleFactory)
    {
        _vehicleDataCustodian = vehicleDataCustodian;
        _vehicleFactory = vehicleFactory;
    }   
    
    [HttpGet(Name = "GetAllCars")]
    public List<IVehicle> Get()
    {
        return _vehicleDataCustodian.GetAll();
    }
    
    [HttpPost(Name = "AddCar")]
    public Guid Post(CarCreateRequest vehicle)
    {
        return _vehicleDataCustodian.Add(_vehicleFactory.CreateCar(vehicle));
    }
}