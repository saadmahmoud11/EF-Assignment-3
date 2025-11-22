using System.ComponentModel.DataAnnotations;

namespace EF_Assignment_3.Entities;

public class Crew
{
    [Key]
    public int AirCraftId { get; set; }
    public int MajorPilotId { get; set; }
    public Employee MajorPilot { get; set; }

    public int AssistPilotId { get; set; }
    public Employee AssistPilot { get; set; }

    public int Host1Id { get; set; }
    public Employee Host1 { get; set; }

    public int Host2Id { get; set; }
    public Employee Host2 { get; set; }
    public AirCraft AirCraft { get; set; }
}
