namespace NistWebApi.Service.Model;

internal class VendorCommentModel
{
    [JsonPropertyName("organization")]
    public string Organization { get; set; } = null!;

    [JsonPropertyName("comment")]
    public string Comment { get; set; } = null!;

    [JsonPropertyName("lastModified")]
    public DateTime LastModified { get; set; }
}
