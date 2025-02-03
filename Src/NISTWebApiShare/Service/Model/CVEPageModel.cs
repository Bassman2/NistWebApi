namespace NISTWebApi.Service.Model;

internal class CVEPageModel : PageModel
{
    [JsonPropertyName("vulnerabilities")]
    public IEnumerable<VulnerabilitiesModel>? Vulnerabilities { get; set; }

    [JsonIgnore]
    public override IEnumerable<object>? Results => Vulnerabilities?.Select(r => r.Value!);
}
