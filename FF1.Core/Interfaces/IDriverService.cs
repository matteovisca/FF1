using FF1.Core.Dto;
using FF1.Core.Models;

namespace FF1.Core.Interfaces;

public interface IDriverService
{
    Task<List<Driver>> GetDriversAsync();
}