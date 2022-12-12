using System.Text.Json.Serialization;

namespace Zatsuon.NET.Requests;

public class RequestBase
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = default!;
    public string Method { get; set; } = default!;
    public ApiKeyInfo Params { get; set; } = default!;
    
    public int Id { get; set; }
}

public class RequestBase<T> where T: RequestInfo
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = default!;
    public string Method { get; set; } = default!;
    public T Params { get; set; } = default!;
    
    public int Id { get; set; }
}