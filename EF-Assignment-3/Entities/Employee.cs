using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_3.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public DateTime BirthDay { get; set; }
    public List<EmployeeQualification> Qualifications { get; set; } = new();

    public int AirLineId { get; set; }
    public AirLine AirLine { get; set; }

    [InverseProperty(nameof(Crew.MajorPilot))]
    public List<Crew> MajorPilots { get; set; } = new();
    [InverseProperty(nameof(Crew.AssistPilot))]

    public List<Crew> AssistPilots { get; set; } = new();
    [InverseProperty(nameof(Crew.Host1))]

    public List<Crew> Host1s { get; set; } = new();
    [InverseProperty(nameof(Crew.Host2))]
    public List<Crew> Host2s { get; set; } = new();



}
