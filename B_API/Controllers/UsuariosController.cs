using Microsoft.AspNetCore.Mvc;

namespace B_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {

        public UsuariosController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(new {
               nome = "Usuarios"
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
    }
}
