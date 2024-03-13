using CarRentalService.Core.Domain;
using CarRentalService.Core.Entities;
using CarRentalService.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalService.Controllers;

[ApiController]
[Route("[controller]")]
public class CarRentalServiceController : ControllerBase
{
    private readonly IVehicleRentalService _vehicleRentalService;
    private readonly ILogger<CarRentalServiceController> _logger;

    public CarRentalServiceController(ILogger<CarRentalServiceController> logger, IVehicleRentalService vehicleRentalService)
    {
        _logger = logger;
        _vehicleRentalService = vehicleRentalService;
    }
    [HttpPost(Name = "ReserveCar")]
    public Guid Post(RentCarReservationRequestInfo rentCarReservationInfo)
    {
        return _vehicleRentalService.ReserveCar(rentCarReservationInfo);
    }

    [HttpGet]
    [Route("~/[controller]/GetByReservationId/{reservationId}")]
    public RentCarReservationInfo? GetRentCarReservationInfo(Guid reservationId)
    {
        return _vehicleRentalService.GetReservationInfo(reservationId);
    }
    
    [HttpGet]
    [Route("~/[controller]/GetAllReservations")]
    public List<VehicleReservation> GetAllReservations()
    {
        return _vehicleRentalService.GetReservationOptions();
    }
   
    [HttpPut("{reservationId}", Name = "ModifyReservation")]
    public VehicleReservation Put(Guid reservationId, RentCarReservationInfo rentCarReservationInfo)
    {
        return _vehicleRentalService.ModifyReservation(reservationId, rentCarReservationInfo);
    }
    
    [HttpDelete("{reservationId}", Name = "CancelReservation")]
    public bool Delete(Guid reservationId)
    {
        return _vehicleRentalService.CancelReservation(reservationId);
    }
}