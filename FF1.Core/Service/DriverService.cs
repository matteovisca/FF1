using System.Text.Json;
using FF1.Core.Interfaces;
using FF1.Core.Models;

namespace FF1.Core.Service;

public class DriverService : IDriverService
{
    private readonly HttpClient _httpClient;

    public DriverService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Driver>> GetDriversAsync()
    {
        var response = await _httpClient.GetAsync("https://api.openf1.io/v1/drivers");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var drivers = JsonSerializer.Deserialize<List<Driver>>(json);

        return drivers ?? new List<Driver>();
    }
}