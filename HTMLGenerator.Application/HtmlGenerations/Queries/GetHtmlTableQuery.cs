using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Queries
{
    public class GetHtmlTableQuery : IRequest<HtmlElement>
    {
        public List<string> Elements { get; }

        public GetHtmlTableQuery(List<string> elements)
        {
            Elements = elements;
        }
    }
}
