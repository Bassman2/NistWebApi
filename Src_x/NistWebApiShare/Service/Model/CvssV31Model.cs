namespace NISTWebApi.Service.Model;

internal class CvssV31Model
{
    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("cvssData")]
    public CvssV31DataModel CvssData { get; set; } = null!;
}
