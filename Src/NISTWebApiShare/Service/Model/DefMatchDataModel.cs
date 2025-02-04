namespace NISTWebApi.Service.Model;

internal class DefMatchDataModel
{

    [JsonPropertyName("criteria")]
    public string? Criteria { get; set; }

    [JsonPropertyName("matchCriteriaId")]
    public string MatchCriteriaId { get; set; } = null!;

    [JsonPropertyName("versionStartExcluding")]
    public string? VersionStartExcluding { get; set; }

    [JsonPropertyName("versionStartIncluding")]
    public string? VersionStartIncluding { get; set; }

    [JsonPropertyName("versionEndExcluding")]
    public string? VersionEndExcluding { get; set; }

    [JsonPropertyName("versionEndIncluding")]
    public string? VersionEndIncluding { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime LastModified { get; set; }

    [JsonPropertyName("cpeLastModified")]
    public DateTime? CpeLastModified { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    [JsonPropertyName("matches")]
    public List<NameModel>? Matches { get; set; }
}
