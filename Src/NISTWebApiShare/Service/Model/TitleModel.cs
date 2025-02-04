namespace NISTWebApi.Service.Model;

internal class TitleModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("lang")]
    public string Lang { get; set; } = null!;
}
