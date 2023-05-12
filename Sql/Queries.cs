namespace MinApi.Sql;

public static class Queries
{
    public const string ReadAppointments = """
        select 
            [ID],
            [Username],
            [Start],
            [End]
        from [dbo].[AppointmentsOfUsers];
        """;
}