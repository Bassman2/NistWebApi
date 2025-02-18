namespace NistWebApi.Service.Model;

internal class ReferenceModel
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }
}
