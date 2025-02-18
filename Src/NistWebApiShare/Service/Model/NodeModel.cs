namespace NistWebApi.Service.Model;

internal class NodeModel
{
    [JsonPropertyName("operator")]
    public string Operator { get; set; } = null!;

    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonPropertyName("cpeMatch")]
    public List<CpeMatchModel>? CpeMatch { get; set; }
}
