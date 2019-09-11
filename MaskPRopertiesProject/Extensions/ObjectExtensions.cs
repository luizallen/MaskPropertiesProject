using Newtonsoft.Json;

namespace MaskPropertiesProject.Extensions
{
    public static class ObjectExtensions
    {
        public static object Clone(this object source)
        {
            var objectInJson = JsonConvert.SerializeObject(source);

            return JsonConvert.DeserializeObject(objectInJson, source.GetType());
        }
    }
}
