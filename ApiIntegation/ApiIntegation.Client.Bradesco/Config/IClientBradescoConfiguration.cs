using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Client.Bradesco.Config
{
    public interface IClientBradescoConfiguration
    {
        string UrlBase { get; }
        string ResponseMessage { get; }
    }
}
