namespace NistWebApi.Service.Model;

internal class DefCveItemModel
{
    [JsonPropertyName("cve")]
    public CveItemModel Cve { get; set; } = null!;
}
