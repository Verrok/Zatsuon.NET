using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.UsageGenerator;

public class UsageGenerator: GeneratorBase, IUsageGenerator
{
    public UsageGenerator(RestClient client, string apiKey) : base(client, apiKey)
    {
    }

    public async Task<GetUsageResponse> GetUsage()
    {
        var data = InitOnlyKeyRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GetUsage)), ApiKey);
        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GetUsageResponse>(response.Content!, Options)!;
    }
}