namespace NISTWebApi.Service.Model;

internal class DefTitleModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("lang")]
    public string Lang { get; set; } = null!;
}
