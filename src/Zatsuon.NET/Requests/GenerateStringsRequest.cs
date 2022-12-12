using Zatsuon.NET.Enums;
using Zatsuon.NET.Generators.StringGenerator;

namespace Zatsuon.NET.Requests;

public record GenerateStringsRequest: RequestInfo
{
    public int Length { get; init; }
    public string? Characters { get; init; } = StringGenerator.GetStringFromCharSet(CharSet.All);
}