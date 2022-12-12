using System.Text.Json.Serialization;

namespace Zatsuon.NET.Requests;

public record GenerateIntegerSequencesRequest: RequestInfo
{
    [JsonPropertyName("n")]
    public int Amount { get; init; }
    
    public int[] Length { get; init; }
    public int[] Min { get; init; }
    public int[] Max { get; init; }
    [JsonIgnore]
    public bool Replacement { get; init; } = true;
    [JsonIgnore]
    public int Base { get; init; } = 10;
    
    [JsonPropertyName("replacement")]
    public bool[] Replacements 
    {
        get
        {
            var arr = new bool[Amount];
            Array.Fill(arr, Replacement);
            return arr;
        }
    }
    
    [JsonPropertyName("base")]
    public int[] Bases
    {
        get
        {
            var arr = new int[Amount];
            Array.Fill(arr, Base);
            return arr;
        }
    }
}