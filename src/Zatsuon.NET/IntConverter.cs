using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zatsuon.NET;

public class IntConverter : JsonConverter<int>
{
    private readonly int _base;

    public IntConverter(int @base)
    {
        _base = @base;
    }

    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
            return Convert.ToInt32(reader.GetString(), _base);
        return reader.GetInt32();
    }

    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value);
    }
}