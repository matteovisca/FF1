using System.Text.Json.Serialization;

namespace FF1.Core.Models;

public class Driver
{
	public Guid Id { get; set; }
	public string Status { get; set; }
	public string? Description { get; set; }

	public Boolean IsPrimary { get; set; }
	public string BroadcastName { get; set; } = "";
	public string FirstName { get; set; } = "";
	public string LastName { get; set; } = "";
	public string FullName { get; set; } = "";
	public string NameAcronim { get; set; } = "";
	public string Country { get; set; } = "";
	public string HeadshotURL { get; set; } = "";
	public int DriverNumber { get; set; }

	public Guid? TeamId { get; set; }
	[JsonIgnore] public Team? Team { get; set; }

	public DateTime Birthday { get; set; }

	public int PitCoin { get; set; }
	public int Point { get; set; }
}