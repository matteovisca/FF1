using FF1.Core.Interfaces;
namespace FF1.Core.Controllers
{
    
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]

    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet("drivers")]
        public async Task<IActionResult> GetDrivers()
        {
            var drivers = await _driverService.GetDriversAsync();
            return Ok(drivers);
        }
    }
}