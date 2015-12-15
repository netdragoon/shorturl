using Newtonsoft.Json.Linq;
using System;
namespace Canducci.ShortUrl
{    
    internal abstract class Validation
    {

        internal static void IsNullOrEmpty(string Value, string Message)
        {
            if (string.IsNullOrEmpty(Value))
            {
                throw new Exception(Message);
            }
        }

        internal static void IsUrl(string Value, string Message)
        {
            if (!Uri.IsWellFormedUriString(Value, UriKind.RelativeOrAbsolute))
            {
                throw new Exception(Message);
            }
        }

        internal static void IsNotNull<T>(T Value, string Message)
        {
            if (Value == null)
            {
                throw new Exception(Message);
            }
        }

        internal static void IsJson(string Value, string Message)
        {
            JObject o = JObject.Parse(Value);
            IsNotNull(o, Message);
        }

    }
}
