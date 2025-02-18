namespace NistWebApi.Service.Model;

internal class WeaknessModel
{
    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("description")]
    public List<LangStringModel>? Description { get; set; }
}
