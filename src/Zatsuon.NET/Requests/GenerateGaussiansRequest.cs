using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Requests;

public record GenerateGaussiansRequest : RequestInfo
{
    public decimal Mean { get; init; }
    public decimal StandardDeviation { get; init; }
    public int SignificantDigits { get; init; }
}