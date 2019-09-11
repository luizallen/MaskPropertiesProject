using System.Reflection;

namespace MaskPropertiesProject.Formatters.Abstractions
{
    public interface ILogFormatters
    {
        bool IsThisAttribute(PropertyInfo property);

        void MaskProperty(object source,
            PropertyInfo property);
    }
}