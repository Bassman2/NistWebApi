namespace NISTWebApi.Service.Model;

internal class CVEPageModel : PageModel
{
    [JsonPropertyName("vulnerabilities")]
    public IEnumerable<VulnerabilitiesModel>? Vulnerabilities { get; set; }
}
