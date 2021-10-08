using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Online_selling.Client.Htpp
{
    public class HttpResponsceWrapper<T>
    {
        public HttpResponsceWrapper(T response, bool sucess, HttpResponseMessage httpResponsceMessage)
        {
            Success = sucess;
            Response = response;
            HttpResponseMessage = httpResponsceMessage;
        }
        public bool Success { get; set; }

        public T Response { get; set; }

        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task <string> GetBody() 
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
