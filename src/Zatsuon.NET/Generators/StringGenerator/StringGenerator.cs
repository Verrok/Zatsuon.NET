using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Enums;
using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.StringGenerator;

public class StringGenerator: GeneratorBase, IStringGenerator
{
    public static string Lower = "abcdefghijklmnopqrstuvwxyz";
    public static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static string Digits = "0123456789";
    public static string Symb = "!@#$%^&*()№;:?*{}[]'/|";
    public static string GetStringFromCharSet(CharSet c)
    {

        string result = String.Empty;

        if (c.HasFlag(CharSet.Lower))
        {
            result += Lower;
        }
        if (c.HasFlag(CharSet.Upper))
        {
            result += Upper;
        }
        if (c.HasFlag(CharSet.Digits))
        {
            result += Digits;
        }
        if (c.HasFlag(CharSet.Symbols))
        {
            result += Symb;
        }

        return result;

    }
    
    public StringGenerator(RestClient client, string apiKey) : base(client, apiKey)
    {
    }

    public async Task<GenerateStringsResponse> GenerateStrings(GenerateStringsRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateStrings)), ApiKey, request);
        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateStringsResponse>(response.Content!, Options)!;
    }

    public async Task<GenerateUUIDsResponse> GenerateUUIDs(GenerateUUIDsRequest request)
    {
        var data = InitRequest(JsonNamingPolicy.CamelCase.ConvertName(nameof(GenerateUUIDs)), ApiKey, request);
        var restRequest = InitRestRequest(data);
        var response = await RestClient.ExecuteAsync(restRequest);
        return JsonSerializer.Deserialize<GenerateUUIDsResponse>(response.Content!, Options)!;
    }
}