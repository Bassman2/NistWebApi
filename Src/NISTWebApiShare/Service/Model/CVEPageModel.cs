namespace NISTWebApi.Service.Model;

internal class CvePageModel : PageModel
{
    [JsonPropertyName("vulnerabilities")]
    public List<DefCveItemModel>? Vulnerabilities { get; set; }

    [JsonIgnore]
    public override List<object>? Results => Vulnerabilities?.Select(static r => r.Cve!).ToList<object>();
}
