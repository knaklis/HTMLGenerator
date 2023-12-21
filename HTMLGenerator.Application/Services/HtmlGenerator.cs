using HTMLGenerator.Application.Services.Interfaces;
using HTMLGenerator.Domain.ValueObjects;

namespace HTMLGenerator.Application.Services
{
    public class HtmlGenerator : IHtmlGenerator
    {
        public HtmlElement GenerateHtmlStart(string title)
        {
            return new HtmlElement { Value = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>{title}</title>
            </head>
            <body>
            " };
        }

        public HtmlElement GenerateHtmlEnd()
        {
            return new HtmlElement { Value = @"</body></html>" };
        }

        public HtmlElement GenerateHeading(string text)
        {
            return new HtmlElement { Value = $"<h1>{text}</h1>" };
        }

        public HtmlElement GenerateParagraph(string text)
        {
            return new HtmlElement { Value = $"<p>{text}</p>" };
        }

        public HtmlElement GenerateList(List<string> items)
        {
            var listItems = string.Join("", items.Select(item => $"<li>{item}</li>"));
            return new HtmlElement { Value = $"<ul>{listItems}</ul>" };
        }

        public HtmlElement GenerateLink(string url, string text)
        {
            return new HtmlElement { Value = $"<a href=\"{url}\">{text}</a>" };
        }

        public HtmlElement GenerateImage(string imageUrl, string altText)
        {
            return new HtmlElement { Value = $"<img src=\"{imageUrl}\" alt=\"{altText}\">" };
        }
    }
}
