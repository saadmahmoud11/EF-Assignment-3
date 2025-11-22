
using EF_Assignment_3.DbContexts;
using EF_Assignment_3.Entities;

using var db = new AirLineDbContext();
/*
var egyptAir = new AirLine
{
    Name = "EgyptAir",
    Address = "Cairo",
    ContactPerson = "Ahmed Ali",
    Phones =
    {
        new AirLinePhone { Phone = "01000000001" },
        new AirLinePhone { Phone = "01000000002" }
    }

};
db.AirLines.Add(egyptAir);
db.SaveChanges();

var model01 = new AirCraft
{
    Model = "Model01",
    Capacity = 180,
    AirLineId = egyptAir.Id
};
db.AirCrafts.Add(model01);
db.SaveChanges();
var tr = new Transaction
{
    Description = "Tickets",
    Amount = 5000,
    Date = DateTime.Now,
    AirLineId = egyptAir.Id
};
db.Transactions.Add(tr);
db.SaveChanges();
*/
/*
var egyptAirEmployees = db.Employees
    .Where(e => e.AirLine.Name == "EgyptAir")
    .ToList();
var egyptAirTransactions = db.Transactions
    .Where(t => t.AirLine.Name == "EgyptAir")
    .Select(t => new
    {
        t.Id,
        t.Amount,
        t.Date
    })
    .ToList();

var countEmployees = db.Employees
    .GroupBy(e => e.AirLine.Name)
    .Select(g => new
    {
        AirLineName = g.Key,
        EmployeeCount = g.Count()
    })
    .ToList();

var ac = db.AirCrafts
    .FirstOrDefault(a => a.Model == "Model01");
if (ac != null)
{
    ac.Capacity = 200;
    db.SaveChanges();
}

var oldTransactions = db.Transactions
    .Where(t => t.Date.Year < 2020 )
    .ToList();
db.Transactions.RemoveRange(oldTransactions);
db.SaveChanges();

var Rote = new Route
{
    Orgin = "Cairo",
    Destination = "Dubai",
    Classfication = "International",
    Distance = 2400m

};
db.Routes.Add(Rote);
db.SaveChanges();

var airCraft = db.AirCrafts
    .FirstOrDefault(a => a.Model == "Model01");
var dubaiRoute = db.Routes
    .FirstOrDefault(r => r.Destination == "Dubai" && r.Orgin == "Cairo");
if (airCraft != null && dubaiRoute != null)
{
    var assign = new AirCraftRoute
    {
        AirCraftId = airCraft.Id,
        RouteId = dubaiRoute.Id,
        Duration = TimeSpan.FromHours(4),
        Departure = DateTime.Now.AddHours(2),
        Arrival = DateTime.Now.AddHours(6),
        NumOfPassengers = 150,
        Price = 3000m
    };
    db.AirCraftRoutes.Add(assign);
    db.SaveChanges();
}
*/
//Retrieve the names of all employees who work for a specific airline.

var employees = db.Employees
    .Where(e => e.AirLine.Name == "EgyptAir")
    .Select(e => new
    {
        e.Id,
        e.Name,
        e.Position
    })
    .ToList();

// Retrieve all aircraft owned by a specific airline.
var aircrafts = db.AirCrafts
    .Where(a => a.AirLine.Name == "EgyptAir")
    .Select(a => new
    {
        a.Id,
        a.Model,
        a.Capacity
    })
    .ToList();
//List all transactions recorded by a specific employee

var transactions = db.Transactions
    .Where(t => t.AirLine.Employees.Any(e => e.Name == "Ahmed Ali"))
    .Select(t => new
    {
        t.Id,
        t.Description,
        t.Amount,
        t.Date
    })
    .ToList();
//Count the number of employees working in each airline
var employeeCounts = db.Employees
    .GroupBy(e => e.AirLine.Name)
    .Select(g => new
    {
        AirLineName = g.Key,
        EmployeeCount = g.Count()
    })
    .ToList();

