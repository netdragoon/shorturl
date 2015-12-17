using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Canducci.ShortUrl
{
    internal class JsonData
    {
        public static string ToJson<T>(T Value)
        {
            return JsonConvert.SerializeObject(Value);
        }

        public static T ToObject<T>(string Content)
        {
            return JsonConvert.DeserializeObject<T>(Content);            
        }

        public static dynamic ToObject(string Content)
        {
            return JsonConvert.DeserializeObject<dynamic>(Content);
        }

        public static string Normalize(string url, string keyword)
        {            
            JObject ob = new JObject();
            ob.Add("url", url);
            ob.Add("keyword", keyword);
            return ob.ToString();
        }

        //public static string ToJson<T>(T Value)
        //{
        //    DataContractJsonSerializer data =
        //        new DataContractJsonSerializer(typeof(T));
        //    MemoryStream stream = new MemoryStream();
        //    data.WriteObject(stream, Value);
        //    string jsonFormatted = Encoding.UTF8.GetString(stream.ToArray());
        //    data = null;
        //    stream.Dispose();
        //    return jsonFormatted;
        //}
        //public static T ToObject<T>(string Content)
        //{
        //    DataContractJsonSerializer data =
        //        new DataContractJsonSerializer(typeof(T));
        //    MemoryStream reader = new MemoryStream(Encoding.UTF8.GetBytes(Content));
        //    T obj = (T)data.ReadObject(reader);
        //    reader.Close();
        //    data = null;
        //    return obj;
        //}
    }

    //internal class ShortUrlReceiveUri : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {            
    //        return new Uri((string)reader.Value);
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        Uri obj = value as Uri;
    //        writer.WriteStartObject();
    //        writer.WritePropertyName("address");                     
    //        serializer.Serialize(writer, obj.AbsoluteUri);            
    //        writer.WriteEndObject();
    //    }
    //}
}
