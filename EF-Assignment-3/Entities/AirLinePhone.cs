namespace EF_Assignment_3.Entities;

public class AirLinePhone
{
    public int Id { get; set; }
    public string Phone { get; set; }

    public int AirLineId { get; set; }
    public AirLine AirLine { get; set; }
}
