using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Application.Commands.ApiIntegration
{
    public class ApiIntegrationCommandRequest
    {
        public ApiIntegrationTypeEnum typeIntegration { get; set; }
        public decimal Amount { get; set; }
        public string? Bank { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountDigit { get; set; }
    }
}
