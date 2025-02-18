namespace NistWebApi.Service.Model;

internal class CpePageModel : PageModel
{
    [JsonPropertyName("products")]
    public List<DefCpeModel>? Products { get; set; }

    [JsonIgnore]
    public override List<object>? Results => Products?.Select(static r => r.Cpe!).ToList<object>();
}