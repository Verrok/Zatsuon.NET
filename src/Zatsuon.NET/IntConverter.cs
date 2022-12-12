using System.Text.Json;
using System.Text.Json.Serialization;
using Zatsuon.NET.Enums;

namespace Zatsuon.NET;

public class BlobConverter : JsonConverter<byte[]>
{
    private BlobFormat _blobFormat;

    public BlobConverter(BlobFormat format = BlobFormat.Base64)
    {
        _blobFormat = format;
    }
    public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();

        if (string.IsNullOrEmpty(value))
            return Array.Empty<byte>();
        
        if (reader.TokenType == JsonTokenType.String && typeToConvert == typeof(byte[]))
        {
            if (_blobFormat == BlobFormat.Base64)
                return Convert.FromBase64String(value);
            
            return Convert.FromHexString(value);
        }
        
        return Array.Empty<byte>();
    }

    public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(string.Join(",", value));
    }


}

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