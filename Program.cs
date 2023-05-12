using Microsoft.AspNetCore.Mvc;
using MinApi.Endpoints;

string getHello() => "Hello!!";
string getOtherwise() => "NotHello!!";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<AppointmentEndpoint>();


var app = builder.Build();
app.MapGet("/", (AppointmentEndpoint endpoint) => endpoint.Get());
app.Run();
