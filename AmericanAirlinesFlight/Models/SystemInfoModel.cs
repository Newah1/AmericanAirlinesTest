using System.Text.Json.Serialization;

namespace AmericanAirlinesFlight.Models;

public class SystemInfoModel
{
    public SystemInformationModel SystemInformationModel { get; set; }
    [JsonPropertyName("flightInfoFIG2")]
    public FlightInfoModel FlightInfoFig2 { get; set; }
}

public class FlightInfoModel {
    [JsonPropertyName("flight")]
    public FlightModel Flight { get; set; }
}

public class FlightModel
{
    [JsonPropertyName("flight_identifier")]
    public string FlightIdentifier { get; set; }
    [JsonPropertyName("flight_number")]
    public string FlightNumber { get; set; }
    [JsonPropertyName("flight_state")]
    public string FlightState { get; set; }
    [JsonPropertyName("gps")]
    public GpsModel Gps { get; set; }
    
}

public class GpsModel
{
    [JsonPropertyName("speed")]
    public int Speed { get; set; }
    [JsonPropertyName("flight_level")]
    public int FlightLevel { get; set; }
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }
    [JsonPropertyName("calculations")]
    public CalculationsModel Calculations { get; set; }
}

public class CalculationsModel
{
    [JsonPropertyName("bearing_from_departure")]
    public double BearingFromDeparture { get; set; }
    [JsonPropertyName("bearing_to_arrival")]
    public double BearingToArrival { get; set; }
    [JsonPropertyName("distance_from_departure")]
    public double DistanceFromDeparture { get; set; }
    [JsonPropertyName("distance_to_arrival")]
    public double DistanceToArrival { get; set; }
}

public class SystemInformationModel
{
    
}