using HTMLGenerator.Domain.Entities;
using MediatR;

namespace HTMLGenerator.Application.RequestTrackings.Queries
{
    public class GetAllRequestsQuery : IRequest<List<Request>>
    {
    }
}
