using System;
using Nancy;

namespace Chat
{
   public class HomeModule : NancyModule
   {
      public HomeModule()
      {
         var model = new { UtcNow = DateTime.UtcNow };
         Get["/"] = x => View["Index", model];
      }
   }
}