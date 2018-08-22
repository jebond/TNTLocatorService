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
            var Location = ConfigurationManager.AppSettings["Physicalocation"];
            var ComputerName = ConfigurationManager.AppSettings["ComputerName"];
            var Department = ConfigurationManager.AppSettings["Department"];
            var notes = ConfigurationManager.AppSettings["Notes"];

            var configuration = new HostConfiguration
            {
                UrlReservations = { CreateAutomatically = true }
            };

            var host = new NancyHost(configuration, new Uri("http://localhost:8088"));
            host.Start();

            WebServer Server = new WebServer(Location, Department, notes, ComputerName);
        }

        protected override void OnStop()
        {
            
        }
    }
}
