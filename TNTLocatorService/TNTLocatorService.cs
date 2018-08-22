using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Nancy;
using Nancy.Hosting.Self;

namespace TNTLocatorService
{
    public partial class TNTLocatorService : ServiceBase
    {

        public TNTLocatorService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            var configuration = new HostConfiguration
            {
                UrlReservations = { CreateAutomatically = true }
            };

            var port = ConfigurationManager.AppSettings["Port"];

            var host = new NancyHost(configuration, new Uri("http://localhost:"+port));
            //WebServer Server = new WebServer(Location, Department, notes, ComputerName);
            host.Start();
        }

        protected override void OnStop()
        {
            
        }
    }
}
