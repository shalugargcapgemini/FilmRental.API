using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FilmRental.API.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        [HttpGet]
        [HttpPost]
        public IActionResult HandleError()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return StatusCode(500, new
            {
                StatusCode = 500,
                Message = "An unexpected error occurred. Please try again later."
            });
        }
    }
}