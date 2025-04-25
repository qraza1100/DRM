using DRM.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DRM.Helpers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiscenseHelper : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public LiscenseHelper(UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpGet("Check")]
        public async Task<IActionResult> CheckExpiry([FromQuery] string Email)
        {
            if (string.IsNullOrWhiteSpace(Email))
                return BadRequest("Username is required.");

            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
                return NotFound("User not found.");

            // Assuming ExpiryDate is a property in your ApplicationUser class
            if (user.LiscenceExpiry.HasValue && user.LiscenceExpiry.Value < DateTime.UtcNow)
                return Ok(1); // Expired
            else
                return Ok(0); // Not expired
        }

    }
}
