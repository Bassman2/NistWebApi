namespace NISTWebApi.Service.Model;

internal class BaseMetricV3Model
{
    [JsonPropertyName("cvssV3")]
    public CvssV3Model CvssV3 { get; set; }
}
