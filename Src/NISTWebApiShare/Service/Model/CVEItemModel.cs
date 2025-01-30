namespace NISTWebApi.Service.Model;

internal class CVEItemModel
{
    public CVEModel? cve { get; set; }
    //configurations
    public ImpactModel? impact { get; set; }
    public DateTime? publishedDate { get; set; }
    public DateTime? lastModifiedDate { get; set; }
}
