using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NancyApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["home"];
            };

            Get["/Employees"] = _ =>
            {
                return View["employees"];
            };

            Get["/Weather"] = _ =>
            {
                return View["weather"];
            };
        }
    }
}