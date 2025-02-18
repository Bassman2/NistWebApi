namespace NistWebApi.Service.Model;

internal class NameModel
{
    [JsonPropertyName("cpeName")]
    public string? CpeName { get; set; }

    [JsonPropertyName("cpeNameId")]
    public Guid? CpeNameId { get; set; }
}
