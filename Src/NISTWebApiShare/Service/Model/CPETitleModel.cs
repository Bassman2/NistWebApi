namespace NISTWebApi.Service.Model;

internal class CPETitleModel
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}
