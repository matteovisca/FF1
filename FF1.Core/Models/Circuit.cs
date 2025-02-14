using System.Runtime.InteropServices.JavaScript;

namespace FF1.Core.Models;

public class Circuit
{
    public Guid Id { get; set; }
    public string? CircuitShortName { get; set; }
    public string? MeetingOfficialName { get; set; }
    public string? MeetingName { get; set; }
    public string Location { get; set; }
    public string Country { get; set; }
    public string CountryComplete { get; set; }
    public double TrackLength { get; set; }
    public int Curves { get; set; }
}