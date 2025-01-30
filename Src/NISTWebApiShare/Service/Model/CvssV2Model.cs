namespace NISTWebApi.Service.Model;

internal class CvssV2Model
{
    [JsonConverter(typeof(JsonStringEnumConverter<CVEScoreVersion>))]
    public CVEScoreVersion version { get; set; }
    public string? vectorString { get; set; }
    public CvssV2Vector accessVector { get; set; }
    public CvssV2Complexity accessComplexity { get; set; }
    public CvssV2Authentication authentication { get; set; }
    public CvssV2Impact confidentialityImpact { get; set; }
    public CvssV2Impact integrityImpact { get; set; }
    public CvssV2Impact availabilityImpact { get; set; }
    public float baseScore { get; set; }
}
