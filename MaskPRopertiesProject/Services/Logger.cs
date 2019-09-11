using System;
using MaskPropertiesProject.Services.Abstractions;
using Newtonsoft.Json;

namespace MaskPropertiesProject.Services
{
    public class Logger : ILogger
    {
        public ILoggerHandler LoggerHandler { get; }

        public Serilog.ILogger SeriLogger { get; }

        public Logger(
            ILoggerHandler loggerHandler,
            Serilog.ILogger seriLogger)
        {
            LoggerHandler = loggerHandler ?? throw new ArgumentNullException(nameof(loggerHandler));
            SeriLogger = seriLogger ?? throw new ArgumentNullException(nameof(seriLogger));
        }

        public void Log(object request)
        {
            var loggeHandled = LoggerHandler.HandleLog(request);

            SeriLogger.Information(JsonConvert.SerializeObject(loggeHandled));
        }
    }
}
