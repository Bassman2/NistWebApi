namespace NISTWebApi.Service.Model;

internal class CveItemModel
{
   
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("vulnStatus")]
    public string? VulnStatus { get; set; }

    [JsonPropertyName("published")]
    public DateTime Published { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime LastModified { get; set; }

    [JsonPropertyName("evaluatorComment")]
    public string? EvaluatorComment { get; set; }

    [JsonPropertyName("evaluatorSolution")]
    public string? EvaluatorSolution { get; set; }

    [JsonPropertyName("evaluatorImpact")]
    public string? EvaluatorImpact { get; set; }

    [JsonPropertyName("cisaExploitAdd")]
    public DateTime? CisaExploitAdd { get; set; }

    [JsonPropertyName("cisaActionDue")]
    public DateTime? CisaActionDue { get; set; }

    [JsonPropertyName("cisaRequiredAction")]
    public string? CisaRequiredAction { get; set; }

    [JsonPropertyName("cisaVulnerabilityName")]
    public string? CisaVulnerabilityName { get; set; }

    [JsonPropertyName("cveTags")]
    public List<CveTagModel>? CveTags { get; set; }

    [JsonPropertyName("descriptions")]
    public List<LangStringModel>? Descriptions { get; set; }

    [JsonPropertyName("references")]
    public List<ReferenceModel>? References { get; set; }

    [JsonPropertyName("metrics")]
    public MetricsModel? Metrics { get; set; }

    [JsonPropertyName("weaknesses")]
    public List<WeaknessModel>? Weaknesses { get; set; }

    [JsonPropertyName("configurations")]
    public List<ConfigModel>? Configurations { get; set; }

    [JsonPropertyName("vendorComments")]
    public List<VendorCommentModel>? VendorComments { get; set; }
}
