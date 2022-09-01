using ApiIntegation.Application.Commands.ApiIntegration;
using Microsoft.AspNetCore.Mvc;

namespace ApiIntegation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiIntegrationController : Controller
    {
        private readonly ILogger<ApiIntegrationController> _logger;
        private readonly IApiIntegrationCommand apiIntegrationCommand;

        public ApiIntegrationController(ILogger<ApiIntegrationController> logger, IApiIntegrationCommand apiIntegrationCommand)
        {
            _logger = logger;
            this.apiIntegrationCommand = apiIntegrationCommand;
        }

        [HttpPost()]
        [ProducesResponseType(200, Type = typeof(List<ApiIntegrationCommandResponse>))]
        public async Task<IActionResult> Post([FromBody] ApiIntegrationCommandRequest request) =>
            Ok(await apiIntegrationCommand.Execute(request));

    }
}
