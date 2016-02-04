using Microsoft.AspNet.Mvc;
using MVC6_Example.Models;

namespace MVC6_Example.Controllers
{
    public class MvcExampleController : Controller
    {
        public IActionResult Index()
        {
            return View(new ExampleViewModel { Id = 1337, FirstName = "Foo", LastName = "Bar" });
        }

        [HttpPost]
        public IActionResult Index(ExampleViewModel model)
        {
            return View(model);
        }

        public IActionResult Stuff(int id)
        {
            return Content("Here's some stuff! Id: " + id);
        }

        public IActionResult Json()
        {
            return Json(new ExampleViewModel { Id = 1, FirstName = "Hello", LastName = "World" });
        }

        public IActionResult Error()
        {
            return HttpBadRequest("Nope!");
        }
    }
}