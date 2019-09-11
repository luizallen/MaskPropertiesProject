using System;
using System.Reflection;
using MaskPropertiesProject.Attributes;
using MaskPropertiesProject.Formatters.Abstractions;

namespace MaskPropertiesProject.Formatters
{
    public class DateFormatter : ILogFormatters
    {
        public bool IsThisAttribute(PropertyInfo property)
            => Attribute.IsDefined(property, typeof(DateAtt));

        public void MaskProperty(
            object source,
            PropertyInfo property)
        {
            property.SetValue(source, DateTime.Now.AddDays(2), null);
        }
    }
}