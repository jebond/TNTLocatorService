using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;
using System.Configuration;

namespace TNTLocatorService
{
    public class WebServer : NancyModule
    {
        public WebServer()
        {
            var Location = ConfigurationManager.AppSettings["Physicalocation"];
            var ComputerName = ConfigurationManager.AppSettings["ComputerName"];
            var Department = ConfigurationManager.AppSettings["Department"];
            var notes = ConfigurationManager.AppSettings["Notes"];

            Get["/"] = _ =>
            {
                return "<ul><li> My Location is :: "+Location+"</li><li>My Department is :: " + Department +"</li><li>My Special Notes are :: "+ notes +"</li><li>My Computer Name is :: " + ComputerName + "</li></ul>";
            };
        }
    }
}
