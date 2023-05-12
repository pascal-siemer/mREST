using System.Dynamic;
using FunctionalExtensions;

namespace MinApi;

/*

public class SimulatedDB
{
    private Dictionary<int, Appointment> _appointmentDB;

    public SimulatedDB()
    {
        _appointmentDB = InitDatabase();
    }



    public List<Appointment> Get() =>
        (.._appointmentDB.Count)
            .Collect()
            .Select(identifier => _appointmentDB[identifier])
            .ToList();

    public Appointment Get(int identifier) =>
        _appointmentDB[identifier];

    public List<Appointment> Get(string username) =>
        (.._appointmentDB.Count)
            .Collect()
            .Select(identifier => _appointmentDB[identifier])
            .Where(appointment => appointment.Username == username)
            .ToList();

    public void Update(int identifier, Appointment appointment) =>
        _appointmentDB[identifier] = appointment;

    public void Update(Appointment appointment) =>
        _appointmentDB[_appointmentDB.Count] = appointment;
    
    private static Dictionary<int, Appointment> InitDatabase() => new()
    {
        {0, new ("pascal", DateTime.Today, DateTime.Now)},
        {1, new("phil", DateTime.MinValue, DateTime.MaxValue)},
        {2, new("rachel", DateTime.MinValue, DateTime.Today)},
        {3, new("rachel", DateTime.Today, DateTime.MaxValue)}
    };
    
}

*/