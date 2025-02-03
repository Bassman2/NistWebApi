namespace NISTWebApi.Service.Model;

internal class MatchModel
{
    [JsonPropertyName("cpeName")]
    public string? CpeName { get; set; }

    [JsonPropertyName("cpeNameId")]
    public string? CpeNameId { get; set; }
}
