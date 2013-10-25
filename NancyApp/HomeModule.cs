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
                return View["home.html"];
            };

            Get["/unit"] = _ => "Test";

            Get["/Employees"] = _ =>
            {
                return View["employees.html"];
            };

            Get["/Weather"] = _ =>
            {
                return View["weather.html"];
            };
        }
    }
}