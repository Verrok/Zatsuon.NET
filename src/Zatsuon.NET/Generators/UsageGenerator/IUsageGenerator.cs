using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.UsageGenerator;

public interface IUsageGenerator
{
    public Task<GetUsageResponse> GetUsage();
}