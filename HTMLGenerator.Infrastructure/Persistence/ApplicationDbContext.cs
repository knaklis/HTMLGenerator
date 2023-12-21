using HTMLGenerator.Application.Common.Interfaces;
using HTMLGenerator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HTMLGenerator.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Request> Requests => Set<Request>();

        public DbSet<SentRequest> SentRequests => Set<SentRequest>();

        public DbSet<RequestStatistic> RequestStatistics => Set<RequestStatistic>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
