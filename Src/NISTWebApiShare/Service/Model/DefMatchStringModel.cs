namespace NISTWebApi.Service.Model;

internal class DefMatchStringModel
{
    [JsonPropertyName("matchString")]
    public DefMatchDataModel MatchString { get; set; } = null!;
}
