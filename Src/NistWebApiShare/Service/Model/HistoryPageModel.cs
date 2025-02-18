namespace NistWebApi.Service.Model;

internal class HistoryPageModel : PageModel
{
    [JsonPropertyName("cveChanges")]
    public List<DefChangeModel>? CveChanges { get; set; }

    [JsonIgnore]
    public override List<object>? Results => CveChanges?.Select(static r => r.Change).ToList<object>();
}
