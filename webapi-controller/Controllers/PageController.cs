using Microsoft.AspNetCore.Mvc;

namespace webapi_controller.Controllers
{
    [ApiController]
    [Route("/pages")]
    public class PageController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetPages()
        {
            return Ok("page controller ok.");
        }
    }
}