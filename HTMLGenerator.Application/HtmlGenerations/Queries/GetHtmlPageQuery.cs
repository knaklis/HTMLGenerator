using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Queries
{
    public class GetHtmlPageQuery : IRequest<HtmlElement>
    {
        public string Title { get; }
        public string Content { get; }

        public GetHtmlPageQuery(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
