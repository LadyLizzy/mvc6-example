using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using MVC6_Example.Models;

namespace MVC6_Example.ViewComponents
{
    public class ExampleViewComponent : ViewComponent
    {
        private readonly IEnumerable<ExampleViewModel> _examples;

        public ExampleViewComponent()
        {
            _examples = new List<ExampleViewModel>
            {
                new ExampleViewModel { Id = 1, FirstName = "Han", LastName = "Solo"},
                new ExampleViewModel { Id = 2, FirstName = "Darth", LastName = "Vader"},
                new ExampleViewModel { Id = 3, FirstName = "Luke", LastName = "Skywalker"}
            };
        }

        public IViewComponentResult Invoke()
        {
            var orderedItems = _examples.OrderBy(x => x.FirstName);
            return View(orderedItems);
        }
    }
}