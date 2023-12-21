using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Application.Services.Interfaces;
using HTMLGenerator.Domain.ValueObjects;
using MediatR;

namespace HTMLGenerator.Application.HtmlGenerations.Handlers
{
    public class GetAllRequestsQueryHandler : IRequestHandler<GetHtmlImageQuery, HtmlElement>
    {
        private readonly IHtmlGenerator generator;

        public GetAllRequestsQueryHandler(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        public Task<HtmlElement> Handle(GetHtmlImageQuery request, CancellationToken cancellationToken)
        {
            var htmlElement = generator.GenerateImage(request.ImageUrl, request.AlternativeText);

            return Task.FromResult(htmlElement);
        }
    }
}
