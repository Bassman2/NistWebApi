namespace NISTWebApi.Service.Model;

internal class MatchStringEntryModel
{
    [JsonPropertyName("matchString")]
    public MatchStringModel? MatchString { get; set; }
}
