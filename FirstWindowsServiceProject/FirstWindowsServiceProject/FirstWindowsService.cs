using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsServiceProject
{
    public partial class FirstWindowsService : ServiceBase
    {
        public FirstWindowsService()
        {
            InitializeComponent();

            //now lets set the properties of the eventlog

            //this will be the subcategory of the log on Event Viewer > Windows Log
            eventLog1.Log = "Application";

            //this will be the name that will appear on "Source" column in Event Viewer
            eventLog1.Source = "FirstWindowsService";
        }

        //now lets write on the log once the service is started
        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("The user starts the service.", EventLogEntryType.Information);
        }

        //also once it is stopped
        protected override void OnStop()
        {
            eventLog1.WriteEntry("The user stops the service.", EventLogEntryType.Information);
        }

        //it's now done
        //now lets add an Installer on the designer
    }
}
