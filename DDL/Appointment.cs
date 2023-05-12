namespace MinApi.DDL;

public class Appointment
{
    public int Id { get; set; }

    public string Username { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public override string ToString() =>
        $"""
        ID = {Id},
        Username = {Username},
        Start = {Start},
        End = {End}
        """;

}