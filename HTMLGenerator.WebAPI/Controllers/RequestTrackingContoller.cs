using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Application.RequestTrackings.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HTMLGenerator.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestTrackingContoller : ControllerBase
    {
        private readonly IMediator mediator;

        public RequestTrackingContoller(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("requests/all")]
        public async Task<IActionResult> GetAllRequest()
        {
            var query = new GetAllRequestsQuery();
            var queryResult = await this.mediator.Send(query);

            return Ok(queryResult);
        }
    }
}
