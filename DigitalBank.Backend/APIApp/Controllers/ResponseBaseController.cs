using Infrastructure.Http.Response;
using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ResponseBaseController : ControllerBase
    {
        public IActionResult BaseResponse<T>(BaseResponse<T> response)
        {
            return StatusCode((int)response.GetStatusCode(), response);
        }
    }
}
