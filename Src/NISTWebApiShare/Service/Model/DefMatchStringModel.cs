namespace NISTWebApi.Service.Model;

internal class DefMatchStringModel
{
    [JsonPropertyName("matchString")]
    public MatchDataModel MatchString { get; set; } = null!;
}
