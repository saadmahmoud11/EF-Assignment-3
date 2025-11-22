namespace EF_Assignment_3.Entities;

public class AirCraftRoute
{
    public int Id { get; set; }
    public int AirCraftId { get; set; }
    public int RouteId { get; set; }
    public int NumOfPassengers { get; set; }
    public decimal Price { get; set; }
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }
    public TimeSpan Duration { get; set; }
    public AirCraft AirCraft { get; set; }
    public Route Route { get; set; }

}
