﻿using System;
using System.Collections.Generic;
using System.Text;
using IoTHs.Core.Queing;
using Microsoft.Practices.ServiceLocation;
using Newtonsoft.Json;
using NLog.Targets;
using NLog;

namespace W10Home.App.Shared.Logging
{
    internal class IotHubTarget : TargetWithLayout
    {
        public IotHubTarget()
        {
        }

        protected override void Write(LogEventInfo logEvent)
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                ServiceLocator.Current.GetInstance<IMessageQueue>().Enqueue("iothublog", logEvent.Level.Name, this.RenderLogEvent(this.Layout, logEvent)
                    , "json");
            }
        }
    }
}
