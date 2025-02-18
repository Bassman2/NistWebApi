namespace NistWebApi.Service.Model;

internal class CveTagModel
{
    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }
}
