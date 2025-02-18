namespace NistWebApi.Service.Model;

internal class TitleLangModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("lang")]
    public string Lang { get; set; } = null!;
}
