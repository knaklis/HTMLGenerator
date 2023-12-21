using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Application.Services.Interfaces;
using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Handlers
{
    public class GetHtmlTableQueryHandler : IRequestHandler<GetHtmlTableQuery, HtmlElement>
    {
        private readonly IHtmlGenerator generator;

        public GetHtmlTableQueryHandler(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        public Task<HtmlElement> Handle(GetHtmlTableQuery request, CancellationToken cancellationToken)
        {
            var htmlElement = generator.GenerateList(request.Elements);

            return Task.FromResult(htmlElement);
        }
    }
}
