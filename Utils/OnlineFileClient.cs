using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DistroListTool.Utils
{
    public class OnlineFileClient
    {
        protected readonly HttpClient _client;
        public OnlineFileClient()
        {
            _client = new HttpClient();
            //specify to use TLS 1.2 as default connection
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }
    }
}
