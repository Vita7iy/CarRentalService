# Car Rental Service

Implement a **Car Rental application using the C#
programming language**. The application must allow users to
reserve/unreserve vehicles belonging to different categories. The 4
categories of available vehicles are: SEDAN, SUV, VAN and PICKUP TRUCK.

Following are the functional requirements for the application:

1.  Public interface must expose the following 4 methods

    a.  Reserve a single car
    b.  Modify the reservation for a single car
    c.  Cancel the reservation for a single car
    d.  Get Options for reserving

Details for **Get Options for reserving**:

-   There are 4 categories of vehicles available to rent: SEDAN, VAN,
    SUV and PICKUP TRUCK

-   The pricing structure is as follows:

    -   SEDAN

        -   If the booking is for less than 10 days, then the daily
            price is \$20
        -   Else, the daily price is \$15

    -   VAN

        -   Daily base price is \$22
        -   There's an additional cleaning fees of 10% of the total
            booking amount

    -   SUV

        -   Daily base price is \$15
        -   Additionally, \$0.50/mile is added to the booking amount.
            Approximate daily mileage is supplied to the program

    -   PICKUP TRUCK

        -   Daily base price is \$30
        -   If the driver has been licensed for less than 3 years,
            there's a surcharge of 10% of the total booking amount

**Get Options** must return all available vehicle types with the total
amount, sorted in ascending order of the amount, based on the booking's
duration, daily mileage and the user's license.

**Please use OO design principles & C# programming best-practices in
your solution that's extendible in the future.**
