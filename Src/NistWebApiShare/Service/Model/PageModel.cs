namespace NistWebApi.Service.Model;

internal abstract class PageModel
{
    [JsonPropertyName("resultsPerPage")]
    public long ResultsPerPage { get; set; }

    [JsonPropertyName("startIndex")]
    public long StartIndex { get; set; }

    [JsonPropertyName("totalResults")]
    public long TotalResults { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonIgnore]
    public abstract List<object>? Results { get; }
}
