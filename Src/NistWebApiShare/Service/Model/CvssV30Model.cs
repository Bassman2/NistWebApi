namespace NistWebApi.Service.Model;

internal class CvssV30Model
{
    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("cvssData")]
    public CvssV30DataModel CvssData { get; set; } = null!;



    //[JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    //[JsonPropertyName("version")]
    //public CVEScoreVersion Version { get; set; }

    //[JsonPropertyName("vectorString")]
    //public string? VectorString { get; set; }

    //[JsonPropertyName("attackVector")]
    //public CvssV3Vector AttackVector { get; set; }

    //[JsonPropertyName("attackComplexity")]
    //public CvssV3Complexity AttackComplexity { get; set; }

    //[JsonPropertyName("privilegesRequired")]
    //public CvssV3Privileges PrivilegesRequired { get; set; }

    //[JsonPropertyName("userInteraction")]
    //public CvssV3Interaction UserInteraction { get; set; }

    //[JsonPropertyName("scope")]
    //public CvssV3Scope Scope { get; set; }

    //[JsonPropertyName("confidentialityImpact")]
    //public CvssV3Impact ConfidentialityImpact { get; set; }

    //[JsonPropertyName("integrityImpact")]
    //public CvssV3Impact IntegrityImpact { get; set; }

    //[JsonPropertyName("availabilityImpact")]
    //public CvssV3Impact AvailabilityImpact { get; set; }

    //[JsonPropertyName("baseScore")]
    //public float BaseScore { get; set; }

    //[JsonPropertyName("baseSeverity")]
    //public string? BaseSeverity { get; set; }
}
