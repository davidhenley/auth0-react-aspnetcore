using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth0Sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        [HttpGet("public-message")]
        public IActionResult GetPublicMessage()
        {
            return Ok(new
            {
                Message = "The API doesn't require an access token to share this message."
            });
        }
        
        [HttpGet("protected-message")]
        [Authorize]
        public IActionResult GetProtectedMessage()
        {
            return Ok(new
            {
                Message = "The API successfully validated your access token."
            });
        }
    }
}