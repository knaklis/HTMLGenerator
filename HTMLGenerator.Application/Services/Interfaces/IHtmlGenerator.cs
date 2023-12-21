using HTMLGenerator.Domain.ValueObjects;

namespace HTMLGenerator.Application.Services.Interfaces
{
    public interface IHtmlGenerator
    {
        HtmlElement GenerateHeading(string text);
        HtmlElement GenerateHtmlEnd();
        HtmlElement GenerateHtmlStart(string title);
        HtmlElement GenerateImage(string imageUrl, string altText);
        HtmlElement GenerateLink(string url, string text);
        HtmlElement GenerateList(List<string> items);
        HtmlElement GenerateParagraph(string text);
    }
}