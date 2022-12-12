using System.Text.Json.Serialization;

namespace Zatsuon.NET.Responses;

public record ResponseBase<T>
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = default!;
    public ResponseInfo<T> Result { get; set; } = default!;
    public int Id { get; set; }
}