using Microsoft.AspNetCore.Mvc;

namespace B_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservasController : ControllerBase
    {

        public ReservasController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(new {
               nome = "Reservas"
           });
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
