using Microsoft.AspNetCore.Mvc;

namespace Ex1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisibleController : ControllerBase
    {
        [HttpGet("{number}")]
        public IActionResult IsDivisibleBy2024(int number)
        {
            if (number % 2024 == 0)
            {
                return Ok(new { DivisibleBy2024 = true });
            }
            else
            {
                return Ok(new { DivisibleBy2024 = false });
            }
        }
    }
}
