namespace Zatsuon.NET.Requests;

public record RequestInfo
{
    public string ApiKey { get; set; } = default!;
    public PregeneratedRandomization? PregeneratedRandomization { get; set; } = default;
}