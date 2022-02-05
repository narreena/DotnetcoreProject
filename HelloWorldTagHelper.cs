namespace MyFirstCoreProject
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Text;
    [HtmlTargetElement("my-first-tag-helper")]
    public class HelloWorldTagHelper : TagHelper
    {
        public String Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            this.Name = "Naresh Custom Tag";
            output.TagName = "CustomTagHelper";
            output.TagMode= TagMode.StartTagAndEndTag;
            var sbstr = new StringBuilder();
            sbstr.AppendFormat("<span>Hello! My Name is {0}</span>", this.Name);
            output.PreContent.SetHtmlContent(sbstr.ToString());
        }
    }
}
