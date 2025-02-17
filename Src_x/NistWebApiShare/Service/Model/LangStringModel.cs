namespace NISTWebApi.Service.Model;

internal class LangStringModel
{
    [JsonPropertyName("lang")]
    public string Lang { get; set; } = null!;

    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}
