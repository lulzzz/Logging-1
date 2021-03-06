﻿using LagoVista.Core.PlatformSupport;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.IoT.Logging.Loggers
{
    public interface IHostLogger : ILogger
    {
        String InstrumentationKey { get; }

        String InstanceInstrumentationKey { get;  }

        String DeviceInstrumentationKey { get; }

        String HostId { get; }

   
        void AddError(string tag, string message, params KeyValuePair<string, string>[] args);
        void AddError(ErrorCode errorCode, params KeyValuePair<string, string>[] args);

        void AddConfigurationError(string configurationSetting, string error, params KeyValuePair<string, string>[] args);
        
        void AddMetric(string measure, double duration);

        void AddMetric(string measure, TimeSpan duration);

        void AddMetric(string measure, int count = 1);

        void Start();
        void Stop();
    }
}
