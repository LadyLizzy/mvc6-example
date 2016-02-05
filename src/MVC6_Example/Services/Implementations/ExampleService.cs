using System.Diagnostics;

namespace MVC6_Example.Services.Implementations
{
    public class ExampleService : IExampleService
    {
        public string ServiceMessage()
        {
            return "Hello from the example service!";
        }

        public void LogRequestStub(object something)
        {
            Debug.Write(something);
        }
    }
}