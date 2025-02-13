namespace FF1.Core.Models;

public class Team
{

	public Guid Id
	{
		get;
		set;
	}
	public string Status
	{
		get;
		set;
	}
	public string? Description
	{
		get;
		set;
	}

	public string Name { get; set; } = "";
	public List<Driver> Drivers { get; set; }
	public string Color { get; set; }

}
