namespace NISTWebApi.Service.Model;

internal class CVEPageModel : PageModel
{
    [JsonPropertyName("vulnerabilities")]
    public List<VulnerabilitiesModel>? Vulnerabilities { get; set; }

    [JsonIgnore]
    public override List<object>? Results => Vulnerabilities?.Select(static r => r.Value!).ToList<object>();
}
