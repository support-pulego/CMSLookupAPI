using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CMSLookupApi.Utils
{
    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
       => DateTime.ParseExact(reader.GetString(),
                    "MMM dd, yyyy", CultureInfo.InvariantCulture);


        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(
                    "MMM dd, yyyy", CultureInfo.InvariantCulture));
    }
}
