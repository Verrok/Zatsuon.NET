using System.Text.Json.Serialization;

namespace Zatsuon.NET.Responses;

public record GetUsageResponseResult
{
    public string Status { get; set; } = default!;
    public string CreationTime { get; set; } = default!;
    public int BitsUsed { get; set; }
    public int BitsLeft { get; set; }
    public int TotalBits { get; set; }
    public int TotalRequests { get; set; }
}

public record GetUsageResponse
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = default!;
    public GetUsageResponseResult Result { get; set; } = default!;
    public int Id { get; set; }
}