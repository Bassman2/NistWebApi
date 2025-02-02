namespace NISTWebApi.Service.Model;

internal class HistoryPageModel : PageModel
{
    [JsonPropertyName("cveChanges")]
    public IEnumerable<CVEChangModel>? CVEChanges { get; set; }
}
