namespace NISTWebApi.Service.Model;

internal class CVEItemModel
{
    [JsonPropertyName("cve")]
    public CVEModel? Cve { get; set; }

    //configurations
    [JsonPropertyName("impact")]
    public ImpactModel? Impact { get; set; }

    [JsonPropertyName("publishedDate")]
    public DateTime? PublishedDate { get; set; }

    [JsonPropertyName("lastModifiedDate")]
    public DateTime? LastModifiedDate { get; set; }
}
