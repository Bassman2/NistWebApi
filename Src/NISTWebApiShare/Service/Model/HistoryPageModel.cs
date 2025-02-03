namespace NISTWebApi.Service.Model;

internal class HistoryPageModel : PageModel
{
    [JsonPropertyName("cveChanges")]
    public IEnumerable<CVEChangModel>? CVEChanges { get; set; }

    [JsonIgnore]
    public override IEnumerable<object>? Results => CVEChanges?.Select(r => r.Value!);
}
