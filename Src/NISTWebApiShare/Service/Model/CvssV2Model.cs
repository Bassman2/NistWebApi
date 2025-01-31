namespace NISTWebApi.Service.Model;

internal class CvssV2Model
{
    [JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    [JsonPropertyName("version")]
    public CVEScoreVersion Version { get; set; }

    [JsonPropertyName("vectorString")]
    public string? VectorString { get; set; }

    [JsonPropertyName("accessVector")]
    public CvssV2Vector AccessVector { get; set; }

    [JsonPropertyName("accessComplexity")]
    public CvssV2Complexity AccessComplexity { get; set; }

    [JsonPropertyName("authentication")]
    public CvssV2Authentication Authentication { get; set; }

    [JsonPropertyName("confidentialityImpact")]
    public CvssV2Impact ConfidentialityImpact { get; set; }

    [JsonPropertyName("integrityImpact")]
    public CvssV2Impact IntegrityImpact { get; set; }

    [JsonPropertyName("availabilityImpact")]
    public CvssV2Impact AvailabilityImpact { get; set; }

    [JsonPropertyName("baseScore")]
    public float BaseScore { get; set; }
}
