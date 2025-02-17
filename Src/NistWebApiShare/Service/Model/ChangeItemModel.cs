namespace NISTWebApi.Service.Model;

internal class ChangeItemModel
{
    [JsonPropertyName("cveId")]
    public string? CveId { get; set; }

    [JsonPropertyName("eventName")]
    public string? EventName { get; set; }

    [JsonPropertyName("cveChangeId")]
    public string? CveChangeId { get; set; }

    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    [JsonPropertyName("details")]
    public List<DetailModel>? Details { get; set; }
}