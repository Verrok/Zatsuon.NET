using Zatsuon.NET.Requests;
using Zatsuon.NET.Responses;

namespace Zatsuon.NET.Generators.BlobGenerator;

public interface IBlobGenerator
{
    public Task<GenerateBlobsResponse> GenerateBlobs(GenerateBlobsRequest request);
    public Task<GenerateBlobsStringResponse> GenerateBlobsString(GenerateBlobsRequest request);
}