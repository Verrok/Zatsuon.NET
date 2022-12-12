using System.Globalization;

namespace Zatsuon.NET.Responses;

public record ResponseData<T>
{
    public T Data { get; set; }
    public string CompletionTime { get; set; }

    public DateTime GetCompletionTime => DateTime.Parse(CompletionTime, null, DateTimeStyles.RoundtripKind);
}