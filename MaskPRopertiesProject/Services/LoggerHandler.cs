using System.Collections.Generic;
using System.Linq;
using MaskPropertiesProject.Extensions;
using MaskPropertiesProject.Formatters;
using MaskPropertiesProject.Formatters.Abstractions;
using MaskPropertiesProject.Services.Abstractions;

namespace MaskPropertiesProject.Services
{
    public class LoggerHandler : ILoggerHandler
    {
        private List<ILogFormatters> LogFormatters { get; }

        public LoggerHandler()
        {
            LogFormatters = new List<ILogFormatters>
            {
                new IdFormatter(),
                new DateFormatter(),
                new NameFormatter()
            };
        }

        public object HandleLog(object request)
        {  //LOg.information(object);
            var clonedRequest = request.Clone();

            var cloneRequestProperties = clonedRequest.GetType().GetProperties();

            foreach (var item in cloneRequestProperties)
            {
                LogFormatters
                    .First(x => x.IsThisAttribute(item))
                    .MaskProperty(clonedRequest, item);
            }

            return clonedRequest;
        }
    }
}
