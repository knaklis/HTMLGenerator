using HTMLGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HTMLGenerator.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Request> Requests { get; }
        DbSet<SentRequest> SentRequests { get; }
        DbSet<RequestStatistic> RequestStatistics { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
