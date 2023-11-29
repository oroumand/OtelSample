using Microsoft.AspNetCore.Mvc;

namespace WebAPI02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateTimeController : Controller
    {

        [HttpGet(Name = "Get")]
        public IActionResult Index()
        {
            return Ok(new
            {
                Value = DateTime.Now,
            });
        }
    }
}
