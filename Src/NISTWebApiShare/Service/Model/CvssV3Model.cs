namespace NISTWebApi.Service.Model;

internal class CvssV3Model
{
    [JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    public CVEScoreVersion version { get; set; }
    public string? vectorString { get; set; }
    public CvssV3Vector attackVector { get; set; }
    public CvssV3Complexity attackComplexity { get; set; }
    public CvssV3Privileges privilegesRequired { get; set; }
    public CvssV3Interaction userInteraction { get; set; }
    public CvssV3Scope scope { get; set; }
    public CvssV3Impact confidentialityImpact { get; set; }
    public CvssV3Impact integrityImpact { get; set; }
    public CvssV3Impact availabilityImpact { get; set; }
    public float baseScore { get; set; }
    public string? baseSeverity { get; set; }
}
