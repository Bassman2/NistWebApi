namespace NISTWebApi.Service.Model;

internal class DefChangeModel
{
    [JsonPropertyName("change")]
    public ChangeItemModel Change { get; set; } = null!;
}
