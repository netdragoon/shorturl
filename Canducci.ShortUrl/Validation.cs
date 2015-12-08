using Newtonsoft.Json.Linq;
using System;
namespace Canducci.ShortUrl
{
    public abstract class Validation
    {
        public static void IsNullOrEmpty(string Value, string Message)
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new Exception(Message);
            }
        }
        public static void IsUrl(string Value, string Message)
        {
            if (!Uri.IsWellFormedUriString(Value, UriKind.RelativeOrAbsolute))
            {
                throw new Exception(Message);
            }
        }
        public static void IsNotNull<T>(T Value, string Message)
        {
            if (Value == null)
            {
                throw new Exception(Message);
            }
        }
        public static void IsJson(string Value, string Message)
        {
            JObject o = JObject.Parse(Value);
            IsNotNull(o, Message);
        }
    }
}
