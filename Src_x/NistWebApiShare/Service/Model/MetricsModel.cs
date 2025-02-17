namespace NISTWebApi.Service.Model;

internal class MetricsModel
{
    [JsonPropertyName("cvssMetricV40")]
    public List<CvssV40Model>? CvssMetricV40 { get; set; }

    [JsonPropertyName("cvssMetricV31")]
    public List<CvssV31Model>? CvssMetricV31 { get; set; }

    [JsonPropertyName("cvssMetricV30")]
    public List<CvssV30Model>? CvssMetricV30 { get; set; }

    [JsonPropertyName("cvssMetricV2")]
    public List<CvssV2Model>? CvssMetricV2 { get; set; }
}
