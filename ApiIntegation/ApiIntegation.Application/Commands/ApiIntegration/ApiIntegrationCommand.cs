using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Application.Commands.ApiIntegration
{
    public class ApiIntegrationCommand : IApiIntegrationCommand
    {
        public async Task<ApiIntegrationCommandResponse> Execute(ApiIntegrationCommandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
