using System.Text.Json;
using AmericanAirlinesFlight.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var systemInfoUrl = app.Configuration["SystemInfoUrl"];

if (systemInfoUrl == null)
{
    return;
}

app.MapGet("/", async () =>
{

    var client = new HttpClient(new HttpClientHandler());

    var response = await client.GetAsync(systemInfoUrl);

    var responseString = await response.Content.ReadAsStreamAsync();

    var modelResponse = await JsonSerializer.DeserializeAsync<SystemInfoModel>(responseString);


    var finalString = $"Flight number {modelResponse.FlightInfoFig2.Flight.FlightNumber} \n Distance to destination: {modelResponse.FlightInfoFig2.Flight.Gps.Calculations.DistanceToArrival} miles \n";

    finalString += $"Speed: {modelResponse.FlightInfoFig2.Flight.Gps.Speed} MPH";
    
    return finalString;

});

app.Run();