namespace CarRentalService.Core.Entities;

public class RentCarReservationInfo
{
    public RentCarReservationInfo(DriverLicense driverLicense, DateOnly rentFrom, DateOnly rentTo)
    {
        DriverLicense = driverLicense;
        RentFrom = rentFrom;
        RentTo = rentTo;
    }
    public DateOnly RentFrom { get; set; }
    public DateOnly RentTo { get; set; }
    public DriverLicense DriverLicense { get; }
    public long Mileage { get; set; }
}