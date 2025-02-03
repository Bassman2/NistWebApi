namespace NISTWebApi.Service.Model;

internal class CPEResultModel
{
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("feedVersion")]
    public string? FeedVersion { get; set; }

    [JsonPropertyName("cpeCount")]
    public int CPECount { get; set; }

    [JsonPropertyName("feedTimestamp")] 
    public string? FeedTimestamp { get; set; }

    [JsonPropertyName("cpes")] 
    public List<CPEModel>? CPEs { get; set; }
}
