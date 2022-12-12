using System.Text.Json.Serialization;

namespace Zatsuon.NET.Requests;

public record GenerateIntegersRequest: RequestInfo
{
    /// <summary>
    /// The lower boundary for the range from which the random numbers will be picked. Must be within the <b>[-1e9,1e9]</b> range.
    /// </summary>
    public int Min { get; init; }
    
    /// <summary>
    /// The upper boundary for the range from which the random numbers will be picked. Must be within the <b>[-1e9,1e9]</b> range.
    /// </summary>
    public int Max { get; init; }

    /// <summary>
    /// Specifies whether the random numbers should be picked with replacement. The default (<b>true</b>) will cause the numbers to be picked with replacement, i.e., the resulting numbers may contain duplicate values (like a series of dice rolls). If you want the numbers picked to be unique (like raffle tickets drawn from a container), set this value to <b>false</b>.
    /// </summary>
    public bool Replacement { get; set; } = true;

    /// <summary>
    /// Specifies the base that will be used to display the numbers. Values allowed are <b>2</b>, <b>8</b>, <b>10</b> and <b>16</b>. This affects the JSON types and formatting of the resulting data as discussed below.
    /// </summary>
    public int Base { get; set; } = 10;
    
};