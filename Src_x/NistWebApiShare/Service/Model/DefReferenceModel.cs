namespace NISTWebApi.Service.Model;

internal class DefReferenceModel
{
    [JsonPropertyName("ref")]
    public string Ref { get; set; } = null!;

    [JsonPropertyName("type")]
    public RefType Type { get; set; }
}
