namespace NISTWebApi.Service.Model;

internal class CvssV2Model
{
    [JsonPropertyName("source")]
    public string Source { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;

    [JsonPropertyName("cvssData")]
    public object CvssData { get; set; } = null!;

    [JsonPropertyName("baseSeverity")]
    public string? BaseSeverity { get; set; }

    [JsonPropertyName("exploitabilityScore")]
    public double? ExploitabilityScore { get; set; }

    [JsonPropertyName("impactScore")]
    public double? ImpactScore { get; set; }

    [JsonPropertyName("acInsufInfo")]
    public bool? AcInsufInfo { get; set; }

    [JsonPropertyName("obtainAllPrivilege")]
    public bool? ObtainAllPrivilege { get; set; }

    [JsonPropertyName("obtainUserPrivilege")]
    public bool? ObtainUserPrivilege { get; set; }

    [JsonPropertyName("obtainOtherPrivilege")]
    public bool? ObtainOtherPrivilege { get; set; }

    [JsonPropertyName("userInteractionRequired")]
    public bool? UserInteractionRequired { get; set; }



    //[JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    //[JsonPropertyName("version")]
    //public CVEScoreVersion Version { get; set; }

    //[JsonPropertyName("vectorString")]
    //public string? VectorString { get; set; }

    //[JsonPropertyName("accessVector")]
    //public CvssV2Vector AccessVector { get; set; }

    //[JsonPropertyName("accessComplexity")]
    //public CvssV2Complexity AccessComplexity { get; set; }

    //[JsonPropertyName("authentication")]
    //public CvssV2Authentication Authentication { get; set; }

    //[JsonPropertyName("confidentialityImpact")]
    //public CvssV2Impact ConfidentialityImpact { get; set; }

    //[JsonPropertyName("integrityImpact")]
    //public CvssV2Impact IntegrityImpact { get; set; }

    //[JsonPropertyName("availabilityImpact")]
    //public CvssV2Impact AvailabilityImpact { get; set; }

    //[JsonPropertyName("baseScore")]
    //public float BaseScore { get; set; }
}
