namespace NISTWebApi.Service.Model;

internal class DetailModel
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("oldValue")]
    public string? OldValue { get; set; }

    [JsonPropertyName("newValue")]
    public string? NewValue { get; set; }
}
