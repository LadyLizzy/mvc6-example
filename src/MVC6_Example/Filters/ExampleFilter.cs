using Microsoft.AspNet.Mvc.Filters;
using MVC6_Example.Services;

namespace MVC6_Example.Filters
{
    public class ExampleFilter : ActionFilterAttribute
    {
        private readonly IExampleService _exampleService;

        public ExampleFilter(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            _exampleService.LogRequestStub("The request was: " + actionContext.HttpContext.Request);
        }
    }
}