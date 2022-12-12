using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.NumberGenerator;

public class NumberGenerator: GeneratorBase, INumberGenerator
{
    public NumberGenerator(RestClient client, string apiKey) : base(client, apiKey)
    {
    }
    public async Task<GenerateIntegersResponse> GenerateIntegers(GenerateIntegersRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateIntegers)), ApiKey, request);

        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateIntegersResponse>(response.Content!, new JsonSerializerOptions()
        {
            PropertyNamingPolicy =JsonNamingPolicy.CamelCase,
            Converters = { new IntConverter(request.Base) }
        })!;
    }

    public async Task<GenerateIntegerSequencesResponse> GenerateIntegerSequences(GenerateIntegerSequencesRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateIntegerSequences)), ApiKey, request);

        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateIntegerSequencesResponse>(response.Content!, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new IntConverter(request.Base) }
        })!;
    }

    public async Task<GenerateDecimalFractionsResponse> GenerateDecimalFractions(GenerateDecimalFractionsRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateDecimalFractions)), ApiKey, request);

        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateDecimalFractionsResponse>(response.Content!, Options)!;
    }

    public async Task<GenerateGaussiansResponse> GenerateGaussians(GenerateGaussiansRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateGaussians)), ApiKey, request);

        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateGaussiansResponse>(response.Content!, Options)!;
    }
}