using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.BlobGenerator;

public class BlobGenerator: GeneratorBase, IBlobGenerator
{
    public BlobGenerator(RestClient client, string apiKey) : base(client, apiKey)
    {
    }


    public async Task<GenerateBlobsResponse> GenerateBlobs(GenerateBlobsRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateBlobs)), ApiKey, request);
        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateBlobsResponse>(response.Content!, new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new BlobConverter() }
        })!;
    }

    public async Task<GenerateBlobsStringResponse> GenerateBlobsString(GenerateBlobsRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateBlobs)), ApiKey, request);
        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateBlobsStringResponse>(response.Content!, Options)!;
    }
}