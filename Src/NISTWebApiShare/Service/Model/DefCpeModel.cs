namespace NISTWebApi.Service.Model;

internal class DefCpeModel
{
    [JsonPropertyName("cpe")]
    public CpeModel Cpe { get; set; } = null!;
}
