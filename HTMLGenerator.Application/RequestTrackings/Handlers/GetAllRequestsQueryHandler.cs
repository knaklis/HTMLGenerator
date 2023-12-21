using HTMLGenerator.Application.Common.Interfaces;
using HTMLGenerator.Application.RequestTrackings.Queries;
using HTMLGenerator.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HTMLGenerator.Application.RequestTrackings.Handlers
{
    public class GetAllRequestsQueryHandler : IRequestHandler<GetAllRequestsQuery, List<Request>>
    {
        private readonly IApplicationDbContext context;

        public GetAllRequestsQueryHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Request>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
        {
            return await this.context.Requests.ToListAsync();
        }
    }
}
