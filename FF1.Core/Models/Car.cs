using System.Text.Json.Serialization;

namespace FF1.Core.Models;

public class Car
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string Status {get; set;}

    
  
}