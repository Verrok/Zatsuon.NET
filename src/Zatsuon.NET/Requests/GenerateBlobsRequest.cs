namespace Zatsuon.NET.Requests;

public record GenerateBlobsRequest : RequestInfo
{
    public int Size { get; init; }
    public string Format { get; set; } = "base64";
};