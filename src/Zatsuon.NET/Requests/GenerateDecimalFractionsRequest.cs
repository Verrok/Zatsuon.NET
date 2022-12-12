namespace Zatsuon.NET.Requests;

public record GenerateDecimalFractionsRequest: RequestInfo
{
    public int DecimalPlaces { get; init; }
    public bool Replacement { get; set; } = true;
}