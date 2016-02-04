namespace MVC6_Example.Services
{
    //TODO break out of prison (this file) when it grows ^_^
    public interface IExampleService
    {
        string ServiceMessage();
    }

    public class ExampleService : IExampleService
    {
        public string ServiceMessage()
        {
            return "Hello from the example service!";
        }
    }
}