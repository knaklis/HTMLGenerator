using HTMLGenerator.Application.HtmlGenerations.Queries;
using HTMLGenerator.Domain.ValueObjects;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTMLGenerator.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CHtmlController : ControllerBase
    {
        private readonly IMediator mediator;

        public CHtmlController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("page")]
        public async Task<IActionResult> GetPage(string pageTitle, string headerContent)
        {
            var query = new GetHtmlPageQuery(pageTitle, headerContent);
            var queryResult = await this.mediator.Send(query);

            return Ok(queryResult.Value);
        }

        [HttpGet("link")]
        public async Task<IActionResult> GetLink(string url, string text)
        {
            var query = new GetHtmlLinkQuery(url, text);
            var queryResult = await this.mediator.Send(query);

            return Ok(queryResult.Value);
        }

        [HttpGet("image")]
        public async Task<IActionResult> GetImage(string imageUrl, string alternativeText)
        {
            var query = new GetHtmlImageQuery(imageUrl, alternativeText);
            var queryResult = await this.mediator.Send(query);

            return Ok(queryResult.Value);
        }

        [HttpGet("table")]
        public async Task<IActionResult> GetTable([FromQuery] List<string> elements)
        {
            var query = new GetHtmlTableQuery(elements);
            var queryResult = await this.mediator.Send(query);

            return Ok(queryResult.Value);
        }
    }
}
