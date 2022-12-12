using System.Text.Json.Serialization;

namespace Zatsuon.NET.Requests;

public record RequestInfo
{
    [JsonPropertyName("n")]
    public int Amount { get; init; }
    public string ApiKey { get; set; } = default!;
    public PregeneratedRandomization? PregeneratedRandomization { get; set; } = default;
}