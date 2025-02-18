namespace NistWebApi.Service.Model;

internal class DefChangeModel
{
    [JsonPropertyName("change")]
    public ChangeItemModel Change { get; set; } = null!;
}
