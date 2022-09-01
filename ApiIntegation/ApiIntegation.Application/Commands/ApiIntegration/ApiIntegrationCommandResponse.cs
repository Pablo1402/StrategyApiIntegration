using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Application.Commands.ApiIntegration
{
    public class ApiIntegrationCommandResponse
    {
        public ApiIntegrationTypeEnum TypeIntegration { get; set; }
        public string? Message { get; set; }
        public bool IntegrationSuccess { get; set; }
    }
}
