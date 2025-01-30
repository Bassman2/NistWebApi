namespace NISTWebApi.Service.Model;

internal class CPEModel
{
    [JsonPropertyName("deprecated")]
    public bool Deprecated { get; set; }
    
    [JsonPropertyName("cpe23Uri")]
    public string? Cpe23Uri { get; set; }

    [JsonPropertyName("lastModifiedDate")]
    public string? LastModifiedDate { get; set; }

    [JsonPropertyName("titles")]
    public IEnumerable<CPETitleModel>? Titles { get; set; }

    [JsonPropertyName("refs")]
    public IEnumerable<CPERefModel>? Refs { get; set; }
}
