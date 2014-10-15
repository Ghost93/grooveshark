using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace GrooveSharp.Parser
{
    public class JsonParser : IParser
    {
        public T GetObjectFromString<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }

        public string GetStringFromObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, typeof(T), Formatting.None, null);
        }
    }
}
