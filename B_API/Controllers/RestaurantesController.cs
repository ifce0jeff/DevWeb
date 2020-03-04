using Microsoft.AspNetCore.Mvc;

namespace B_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantesController : ControllerBase
    {

        public RestaurantesController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(new {
               nome = "Restaurantes"
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
