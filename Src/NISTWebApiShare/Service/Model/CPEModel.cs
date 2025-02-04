namespace NISTWebApi.Service.Model;

internal class CpeModel
{
    [JsonPropertyName("deprecated")]
    public bool Deprecated { get; set; }

    [JsonPropertyName("cpeName")]
    public string CpeName { get; set; } = null!;

    [JsonPropertyName("cpeNameId")]
    public Guid CpeNameId { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime LastModified { get; set; }

    [JsonPropertyName("titles")]
    public List<TitleModel>? Titles { get; set; }

    [JsonPropertyName("refs")]
    public List<DefReferenceModel>? Refs { get; set; }

    [JsonPropertyName("deprecatedBy")]
    public List<NameModel>? DeprecatedBy { get; set; }

    [JsonPropertyName("deprecates")]
    public List<NameModel>? Deprecates { get; set; }
}
