namespace NISTWebApi.Service.Model;

internal class CVEResultModel
{
    public string? CVE_data_type { get; set; }
    public string? CVE_data_format { get; set; }
    public string? CVE_data_version { get; set; }
    public string? CVE_data_timestamp { get; set; }
    public IEnumerable<CVEItemModel>? CVE_Items { get; set; }
}
