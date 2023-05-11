using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APISecurity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecuredController : ControllerBase
    {
        [HttpGet("userTest")]
        public IActionResult GetUser()
        {
            return Ok("Secured endpoint access as user");
        }

        [HttpGet("adminTest")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdmin()
        {
            return Ok("Secured endpoint access as admin");
        }

    }
}