namespace NISTWebApi.Service.Model;

internal class CPEPageModel : PageModel
{
    [JsonPropertyName("products")]
    public List<ProductModel>? Products { get; set; }

    [JsonIgnore]
    public override List<object>? Results => Products?.Select(static r => r.CPE!).ToList<object>();
}