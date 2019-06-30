using System;
using System.Web.Http;

namespace WebApiSelfHost
{
   public class DateTimeController : ApiController
   {
      public DateTime Get() => DateTime.Now.Date;
   }
}
