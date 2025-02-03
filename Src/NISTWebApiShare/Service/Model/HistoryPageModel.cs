namespace NISTWebApi.Service.Model;

internal class HistoryPageModel : PageModel
{
    [JsonPropertyName("cveChanges")]
    public List<CVEChangModel>? CVEChanges { get; set; }

    [JsonIgnore]
    public override List<object>? Results => CVEChanges?.Select(static r => r.Value!).ToList<object>();
}
