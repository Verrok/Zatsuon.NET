using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.StringGenerator;

public interface IStringGenerator
{
    public Task<GenerateStringsResponse> GenerateStrings(GenerateStringsRequest request);
}