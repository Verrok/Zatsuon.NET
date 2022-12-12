using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.NumberGenerator;

public interface INumberGenerator
{
    public Task<GenerateIntegersResponse> GenerateIntegers(GenerateIntegersRequest request);
    public Task<GenerateIntegerSequencesResponse> GenerateIntegerSequences(GenerateIntegerSequencesRequest request);
    public Task<GenerateDecimalFractionsResponse> GenerateDecimalFractions(GenerateDecimalFractionsRequest request);
}