namespace EF_Assignment_3.Entities;

public class AirLine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactPerson { get; set; }
    public List<AirLinePhone> Phones { get; set; } = new();
    public List<AirCraft> AirCrafts { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();
    public List<Employee> Employees { get; set; } = new();

}