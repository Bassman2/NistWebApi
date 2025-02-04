namespace NISTWebApi.Service.Model;

internal class DeprecateModel
{
    [JsonPropertyName("cpeName")]
    public string? CpeName { get; set; }

    [JsonPropertyName("cpeNameId")]
    public Guid? CpeNameId { get; set; }
}
