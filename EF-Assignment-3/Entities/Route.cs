namespace EF_Assignment_3.Entities;

public class Route
{
    public int Id { get; set; }
    public decimal Distance { get; set; }
    public string Destination { get; set; }
    public string Orgin { get; set; }
    public string Classfication { get; set; }
    public List<AirCraftRoute> AirCraftRoutes { get; set; } = new();

}
