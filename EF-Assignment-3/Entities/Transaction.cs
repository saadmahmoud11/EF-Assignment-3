namespace EF_Assignment_3.Entities;

public class Transaction
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int AirLineId { get; set; }
    public AirLine AirLine { get; set; }
}
