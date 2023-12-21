using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Queries
{
    public class GetHtmlLinkQuery : IRequest<HtmlElement>
    {
        public string Url { get; set; }
        public string Text { get; set; }

        public GetHtmlLinkQuery(string url, string text)
        {
            Url = url;
            Text = text;
        }
    }
}
