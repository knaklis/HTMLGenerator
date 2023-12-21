using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Application.Services.Interfaces;
using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Handlers
{
    public class GetHtmlLinkQueryHandler : IRequestHandler<GetHtmlLinkQuery, HtmlElement>
    {
        private readonly IHtmlGenerator generator;

        public GetHtmlLinkQueryHandler(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        public Task<HtmlElement> Handle(GetHtmlLinkQuery request, CancellationToken cancellationToken)
        {
            var htmlElement = generator.GenerateLink(request.Url, request.Text);

            return Task.FromResult(htmlElement);
        }
    }
}
