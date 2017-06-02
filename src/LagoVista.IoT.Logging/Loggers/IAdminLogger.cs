﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.IoT.Logging.Loggers
{
    public interface IAdminLogger
    {
        String InstrumentationKey { get; }

        void AddCustomEvent(LagoVista.Core.PlatformSupport.LogLevel level, string tag, string customEvent, params KeyValuePair<string, string>[] args);

        void AddError(string tag, string message, params KeyValuePair<string, string>[] args);

        void AddError(ErrorCode errorCode, params KeyValuePair<string, string>[] args);

        void AddConfigurationError(string tag, string message, params KeyValuePair<string, string>[] args);

        void AddException(string tag, Exception ex, params KeyValuePair<string, string>[] args);


        void AddMetric(string measure, double duration);

        void AddMetric(string measure, int count);
    }
}
