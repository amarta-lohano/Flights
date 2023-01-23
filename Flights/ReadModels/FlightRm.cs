namespace Flights.ReadModels
{
    public record FlightRm(
        
        Guid Id,
        string airline,
        string Price,
        TimePlaceRm Departure,
        TimePlaceRm Arrival,
        int RemainingNumberOfSeats
        );

   
}
