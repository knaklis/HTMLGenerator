using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Application.Services.Interfaces;
using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Handlers
{
    public class GetHtmlPageQueryHandler : IRequestHandler<GetHtmlPageQuery, HtmlElement>
    {
        private readonly IHtmlGenerator generator;

        public GetHtmlPageQueryHandler(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        public Task<HtmlElement> Handle(GetHtmlPageQuery request, CancellationToken cancellationToken)
        {
            var htmlElement = generator.GenerateHtmlStart(request.Title);
            htmlElement.Value += generator.GenerateHeading(request.Content);
            htmlElement.Value += generator.GenerateHtmlEnd();

            return Task.FromResult(htmlElement);
        }
    }
}
