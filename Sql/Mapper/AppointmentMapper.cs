using System.Data;
using MinApi.DDL;

namespace MinApi.Sql.Mapper;

public class AppointmentMapper : IDataMapper<Appointment>
{
    public Appointment Map(IDataRecord dataRecord) => new()
    {
        Id = dataRecord.GetInt32(0),
        Username = dataRecord.GetString(1),
        Start = dataRecord.GetDateTime(2),
        End = dataRecord.GetDateTime(3)
    };
}