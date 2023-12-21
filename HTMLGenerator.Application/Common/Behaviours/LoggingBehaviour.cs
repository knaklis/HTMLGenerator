using HTMLGenerator.Application.Common.Interfaces;
using HTMLGenerator.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HTMLGenerator.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
    {
        private readonly IApplicationDbContext context;

        public LoggingBehaviour(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

            var requestInDB = this.context.Requests.FirstOrDefault(x => x.Name == requestName);

            if (requestInDB is null)
            {
                var newRequest = await this.context.Requests.AddAsync(new Request { Name = requestName, SentRequests = new List<SentRequest>()});
                await this.context.SaveChangesAsync(cancellationToken);
                await this.context.SentRequests.AddAsync(new SentRequest { SentDate = DateTime.UtcNow, RequestId = newRequest.Entity.Id });
                await this.context.RequestStatistics.AddAsync(
                    new RequestStatistic
                    {
                        SentTimes = 1,
                        RequestId = newRequest.Entity.Id
                    });
            }
            else
            {
                await this.context.SentRequests.AddAsync(new SentRequest { SentDate = DateTime.UtcNow, RequestId = requestInDB.Id });
                var stats = await this.context.RequestStatistics.FirstOrDefaultAsync(x => x.RequestId == requestInDB.Id);
                stats.SentTimes++;
                this.context.RequestStatistics.Update(stats);
            }

            await this.context.SaveChangesAsync(cancellationToken);

            return await next();
        }
    }
}
