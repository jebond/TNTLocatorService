using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;

namespace TNTLocatorService
{
    public class WebServer : NancyModule
    {
        public WebServer(string physicallocation,string department, string notes, string computername)
        {
            Get["/"] = _ =>
            {
                return physicallocation + department + notes + computername;
            };
        }
    }
}
