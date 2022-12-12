using Zatsuon.NET.Generators;
using Zatsuon.NET.Generators.BlobGenerator;
using Zatsuon.NET.Generators.NumberGenerator;
using Zatsuon.NET.Generators.StringGenerator;

namespace Zatsuon.NET;

public interface IRandomOrgClient
{
    public INumberGenerator Integer { get; }
    public IStringGenerator String { get; }
    
    public IBlobGenerator Blob { get; }
    
}