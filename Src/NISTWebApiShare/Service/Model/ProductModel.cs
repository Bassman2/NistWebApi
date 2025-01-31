namespace NISTWebApi.Service.Model;

internal class ProductModel
{
    [JsonPropertyName("cpe")]
    public CPEModel? CPE { get; set; }
}
