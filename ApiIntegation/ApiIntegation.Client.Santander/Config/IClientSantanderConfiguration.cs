using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Client.Santander.Config
{
    public interface IClientSantanderConfiguration
    {
        string UrlBase { get; }
        string ResponseMessage { get; }
    }
}
