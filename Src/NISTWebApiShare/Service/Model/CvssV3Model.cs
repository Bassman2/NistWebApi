namespace NISTWebApi.Service.Model;

internal class CvssV3Model
{
    [JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    [JsonPropertyName("version")]
    public CVEScoreVersion Version { get; set; }

    [JsonPropertyName("vectorString")]
    public string? VectorString { get; set; }

    [JsonPropertyName("attackVector")]
    public CvssV3Vector AttackVector { get; set; }

    [JsonPropertyName("attackComplexity")]
    public CvssV3Complexity AttackComplexity { get; set; }

    [JsonPropertyName("privilegesRequired")]
    public CvssV3Privileges PrivilegesRequired { get; set; }

    [JsonPropertyName("userInteraction")]
    public CvssV3Interaction UserInteraction { get; set; }

    [JsonPropertyName("scope")]
    public CvssV3Scope Scope { get; set; }

    [JsonPropertyName("confidentialityImpact")]
    public CvssV3Impact ConfidentialityImpact { get; set; }

    [JsonPropertyName("integrityImpact")]
    public CvssV3Impact IntegrityImpact { get; set; }

    [JsonPropertyName("availabilityImpact")]
    public CvssV3Impact AvailabilityImpact { get; set; }

    [JsonPropertyName("baseScore")]
    public float BaseScore { get; set; }

    [JsonPropertyName("baseSeverity")]
    public string? BaseSeverity { get; set; }
}
