using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Requests;

namespace Zatsuon.NET.Generators;

public abstract class GeneratorBase
{
    protected readonly RestClient RestClient;
    protected readonly string ApiKey;
    protected readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    private Random _rnd = Random.Shared;

    public GeneratorBase(RestClient client, string apiKey)
    {
        RestClient = client;
        ApiKey = apiKey;
    }
    protected RequestBase<T> InitRequest<T>(string methodName, string apiKey, T req) where T: RequestInfo 
    {
        var request = new RequestBase<T>
        {
            JsonRpc = Consts.JsonRpcVersion,
            Id = _rnd.Next(1, 10000),
            Method = methodName,
            Params = req
        };

        request.Params.ApiKey = apiKey;

        return request;
    }

    protected RestRequest InitRestRequest<T>(T req)
    {
        var restRequest = new RestRequest
        {
            Method = Method.Post
        };
        Console.WriteLine(JsonSerializer.Serialize(req, Options));
        restRequest.AddBody(JsonSerializer.Serialize(req, Options), "application/json");
        return restRequest;
    }
}