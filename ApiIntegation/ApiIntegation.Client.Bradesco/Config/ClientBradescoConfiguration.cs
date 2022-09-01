using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Client.Bradesco.Config
{
    public class ClientBradescoConfiguration : IClientBradescoConfiguration
    {
        public string UrlBase { get; set; } = null!;
        public string ResponseMessage { get; set; } = null!;

    }
}
