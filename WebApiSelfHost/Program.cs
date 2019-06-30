using System;

namespace WebApiSelfHost
{
   class Program
   {
      static void Main(string[] args)
      {
         var apiService = new ApiService("http://localhost:8331");
         apiService.Start().Wait();

         Console.WriteLine("Server started, press Enter to quit.");
         Console.WriteLine("Ex: 1) localhost:8331/api/products");
         Console.WriteLine("Ex: 2) localhost:8331/api/products/1");
         Console.ReadLine();

         apiService.Stop();
      }
   }
}
