namespace NISTWebApi.Service.Model;

internal class ConfigModel
{
    [JsonPropertyName("operator")]
    public string Operator { get; set; } = null!;

    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonPropertyName("nodes")]
    public List<NodeModel>? Nodes { get; set; }
}
