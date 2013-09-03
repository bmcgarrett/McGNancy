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
            Get["/"] = _ => "Hello World from Nancy";

            Get["/tools"] = x =>
                            {
                                string toolName = Request.Query["ToolName"];
                                int toolID = Request.Query["ToolID"];
                                
                                var tool = new Tool();
                                tool.ToolId = toolID;
                                tool.ToolName = toolName;

                                return View["Tool.html", tool];
                            };
        }
    }
}