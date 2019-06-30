using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApiSelfHost
{
   public class ApiService
   {
      private readonly HttpSelfHostServer _server;
      private readonly HttpSelfHostConfiguration _config;

      public ApiService(string baseAddress)
      {
         _config = new HttpSelfHostConfiguration(baseAddress);
         _config.MaxReceivedMessageSize = 2147483647;

         //*/
         _config.Routes.MapHttpRoute(
            "DefaultApi", "api/{controller}/{id}",
            new { id = RouteParameter.Optional }
         );
         /*/
         _config.Routes.MapHttpRoute(
             "API Default", "api/{controller}/{action}/{id}",
             new { action = "get", id = RouteParameter.Optional });
         //*/

         _server = new HttpSelfHostServer(_config);
      }

      public Task Start() => _server.OpenAsync();

      public void Stop()
      {
         _server.CloseAsync().Wait();
         _server.Dispose();
      }
   }
}
