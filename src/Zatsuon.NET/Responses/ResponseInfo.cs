using System.Text.Json.Serialization;

namespace Zatsuon.NET.Responses;

public record ResponseInfo<T>
{
    public ResponseData<T> Random { get; set; }
    public int BitsUsed { get; set; }
    public int BitsLeft { get; set; }
    public int RequestsLeft { get; set; }
    public int AdvisoryDelay { get; set; }
}