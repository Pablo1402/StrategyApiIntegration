using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Application.Commands.ApiIntegration.Strategy
{
    public interface IApiIntegrationStrategy
    {
        Task<ApiIntegrationCommandResponse> Execute(string? Amount, string? Bank,string? AccountNumber, string? AccountDigit);
    }
}
