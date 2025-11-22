namespace EF_Assignment_3.Entities;

public class EmployeeQualification
{
    public int Id { get; set; }
    public string Qualification { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}
