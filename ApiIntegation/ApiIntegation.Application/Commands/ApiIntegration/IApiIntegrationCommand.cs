using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Application.Commands.ApiIntegration
{
    public interface IApiIntegrationCommand
    {
        Task<ApiIntegrationCommandResponse> Execute(ApiIntegrationCommandRequest request);
    }
}
