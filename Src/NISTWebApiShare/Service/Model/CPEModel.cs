namespace NISTWebApi.Service.Model;

internal class CPEModel
{
    [JsonPropertyName("deprecated")]
    public bool Deprecated { get; set; }

    [JsonPropertyName("cpeName")]
    public string? Name { get; set; }

    [JsonPropertyName("cpeNameId")]
    public string? NameId { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }
    
    [JsonPropertyName("titles")]
    public IEnumerable<CPETitleModel>? Titles { get; set; }

    [JsonPropertyName("refs")]
    public IEnumerable<CPERefModel>? Refs { get; set; }
}
