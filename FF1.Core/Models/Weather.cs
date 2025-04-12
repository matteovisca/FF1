namespace FF1.Core.Models;

public class Weather
{
    public int AirTemperature { get; set; }
    public int Humidity { get; set; }
    public int Pressure { get; set; }
    public int WindSpeed { get; set; }
    public int WindDirection { get; set; }
    public int TrackTemperature { get; set; }
    public int Rainfall { get; set; }
    public DateTime Date { get; set; }
}