namespace NISTWebApi.Service.Model;

internal class MatchStringModel
{

    [JsonPropertyName("matchCriteriaId")]
    public string? MatchCriteriaId { get; set; }

    [JsonPropertyName("criteria")]
    public string? Criteria { get; set; }

    [JsonPropertyName("versionEndExcluding")]
    public string? VersionEndExcluding { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("cpeLastModified")]
    public DateTime? CpeLastModified { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("matches")]
    public List<MatchModel>? Matches { get; set; }
}
