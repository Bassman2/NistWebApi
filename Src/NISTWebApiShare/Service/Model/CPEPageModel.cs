namespace NISTWebApi.Service.Model;

internal class CPEPageModel : PageModel
{
    [JsonPropertyName("products")]
    public IEnumerable<ProductModel>? Products { get; set; }
}