using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Client.Santander.Config
{
    public class ClientSantanderConfiguration : IClientSantanderConfiguration
    {
        public string UrlBase { get; set; } = null!;
        public string ResponseMessage { get; set; } = null!;
    }
}
