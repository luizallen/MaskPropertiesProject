using System;
using System.Reflection;
using MaskPropertiesProject.Attributes;
using MaskPropertiesProject.Formatters.Abstractions;

namespace MaskPropertiesProject.Formatters
{
    public class NameFormatter : ILogFormatters
    {
        public bool IsThisAttribute(PropertyInfo property) => Attribute.IsDefined(property, typeof(NameAtt));
        
        public void MaskProperty(
            object source,
            PropertyInfo property)
        {
            property.SetValue(source, "Teste", null);
        }
    }
}