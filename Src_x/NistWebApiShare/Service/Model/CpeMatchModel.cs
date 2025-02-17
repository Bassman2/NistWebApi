namespace NISTWebApi.Service.Model;

internal class CpeMatchModel
{
    [JsonPropertyName("vulnerable")]
    public bool Vulnerable { get; set; }

    [JsonPropertyName("criteria")]
    public string Criteria { get; set; } = null!;

    [JsonPropertyName("matchCriteriaId")]
    public Guid MatchCriteriaId { get; set; }

    [JsonPropertyName("versionStartExcluding")]
    public string? VersionStartExcluding { get; set; }

    [JsonPropertyName("versionStartIncluding")]
    public string? VersionStartIncluding { get; set; }

    [JsonPropertyName("versionEndExcluding")]
    public string? VersionEndExcluding { get; set; }

    [JsonPropertyName("versionEndIncluding")]
    public string? VersionEndIncluding { get; set; }
}
