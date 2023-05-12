using MinApi.DDL;
using MinApi.Sql;
using MinApi.Sql.Driver;
using MinApi.Sql.Mapper;

namespace MinApi.Endpoints;

public class AppointmentEndpoint : IEndpoint<Appointment>
{
    private IEndpoint<Appointment> _endpoint;

    public AppointmentEndpoint()
    {
        var sqlSettings = new SqlSettings<Appointment>(
            driver: new SqlDriver(SqlConstants.CalendarDatabaseConnection),
            query: Queries.ReadAppointments,
            mapper: new AppointmentMapper());

        _endpoint = new Endpoint<Appointment>(sqlSettings);
    }


    public List<Appointment> Get() => _endpoint.Get();

}