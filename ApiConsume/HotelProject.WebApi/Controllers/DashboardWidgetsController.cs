using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;

        public DashboardWidgetsController(IStaffService staffService, IAppUserService appUserService, IBookingService bookingService)
        {
            _staffService = staffService;
            _appUserService = appUserService;
            _bookingService = bookingService;
        }
        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }
        [HttpGet("AppUserCount")]
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TAppuserCount();
            return Ok(value);
        }
    }
}
