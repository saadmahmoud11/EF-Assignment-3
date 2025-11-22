namespace EF_Assignment_3.Entities;

public class AirCraft
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int Capacity { get; set; }

    public int AirLineId { get; set; }
    public AirLine AirLine { get; set; }
    public List<AirCraftRoute> AirCraftRoutes { get; set; } = new();
    public Crew Crew { get; set; }
}

