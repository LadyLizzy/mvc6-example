using Microsoft.AspNet.Mvc;

namespace MVC6_Example.Controllers
{
    [Route("api/example")]
    public class ApiExampleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("WOOHOO!");
        }

        [HttpGet("{id:int}")]
        public IActionResult Index(int id)
        {
            return Ok("WOOHOO! " + id);
        }
    }
}