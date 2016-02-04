using Microsoft.AspNet.Razor.TagHelpers;

namespace MVC6_Example.TagHelpers
{
    public class ExampleTagHelper : TagHelper
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            output.Attributes["class"] = "example";
            output.PostContent.SetContent("Hello from the tag helper! ");
            output.PostContent.Append("Title sent in was: " + Title + " and Body: " + Body);
        }
    }
}