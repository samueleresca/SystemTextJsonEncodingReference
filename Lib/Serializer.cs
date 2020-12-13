using System.Text.Encodings.Web;
using System.Text.Json;

namespace SystemTextJsonEncodingReference.Lib
{
    public static class Serializer
    {
        public static SimpleMetricOutput Get()
        {

            JsonSerializerOptions serializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            
           serializeOptions.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            return JsonSerializer
                .Deserialize<SimpleMetricOutput>("{\"instance\":\"test\"}", serializeOptions);
        }
    }
}