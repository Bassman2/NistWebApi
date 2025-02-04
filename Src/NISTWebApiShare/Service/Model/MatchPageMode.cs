namespace NISTWebApi.Service.Model;

internal class MatchPageModel : PageModel
{
    [JsonPropertyName("matchStrings")]
    public List<DefMatchStringModel> MatchStrings { get; set; } = null!;

    [JsonIgnore]
    public override List<object>? Results => MatchStrings.Select(static r => r.MatchString).ToList<object>();
}
