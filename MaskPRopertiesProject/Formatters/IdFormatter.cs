using System;
using System.Reflection;
using MaskPropertiesProject.Attributes;
using MaskPropertiesProject.Formatters.Abstractions;

namespace MaskPropertiesProject.Formatters
{
    public class IdFormatter : ILogFormatters
    {
        public bool IsThisAttribute(PropertyInfo property) => Attribute.IsDefined(property, typeof(IdAtt));

        public void MaskProperty(
            object source,
            PropertyInfo property)
        {
            property.SetValue(source, 15, null);
        }
    }
}