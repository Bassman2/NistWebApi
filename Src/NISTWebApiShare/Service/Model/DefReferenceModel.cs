namespace NISTWebApi.Service.Model;

internal class DefReferenceModel
{
    [JsonPropertyName("ref")]
    public string Ref { get; set; } = null!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
}
