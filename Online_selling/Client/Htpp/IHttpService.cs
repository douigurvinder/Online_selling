using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_selling.Client.Htpp
{
    public interface IHttpService
    {
        Task<HttpResponsceWrapper<object>> Post<T>(string url, T data);
    }
}
