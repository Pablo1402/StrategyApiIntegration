using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegation.Client.Itau.Config
{
    public interface IClientItauConfiguration
    {
        string UrlBase { get; }
        string ResponseMessage { get; }
    }
}
