using System.Text.Json;
using RestSharp;
using Zatsuon.NET.Generators;
using Zatsuon.NET.Generators.BlobGenerator;
using Zatsuon.NET.Generators.NumberGenerator;
using Zatsuon.NET.Generators.StringGenerator;
using Zatsuon.NET.Generators.UsageGenerator;

namespace Zatsuon.NET;

public class RandomOrgClient: IRandomOrgClient
{
    public INumberGenerator Integer { get; }
    public IStringGenerator String { get; } = new StringGenerator();
    public IBlobGenerator Blob { get; } = new BlobGenerator();
    public IUsageGenerator Usage { get; } = new UsageGenerator();

    private readonly string _apiKey;
    private readonly string _requestUrl = "https://api.random.org/json-rpc/4/invoke";
    private readonly Random _rnd;
    private readonly RestClient _restClient;
    public RandomOrgClient(string apiKey, HttpClient? client = null)
    {
        _rnd = new Random();
        _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        _restClient = new RestClient(client ?? new HttpClient(), new RestClientOptions(_requestUrl));

        Integer = new NumberGenerator(_restClient, _apiKey);
    }
    
}