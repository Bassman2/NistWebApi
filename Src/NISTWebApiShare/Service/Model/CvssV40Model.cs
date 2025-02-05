namespace NISTWebApi.Service.Model;

internal class CvssV40Model
{
    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("cvssData")]
    public CvssV40DataModel CvssData { get; set; } = null!;
}
