using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Queries
{
    public class GetHtmlImageQuery : IRequest<HtmlElement>
    {
        public string ImageUrl { get; set; }
        public string AlternativeText { get; set; }

        public GetHtmlImageQuery(string imageUrl, string alternativeText)
        {
            ImageUrl = imageUrl;
            AlternativeText = alternativeText;
        }
    }
}
