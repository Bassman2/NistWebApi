namespace NISTWebApi.Service.Model;

internal class MatchPageModel : PageModel
{
    [JsonPropertyName("matchStrings")]
    public IEnumerable<MatchStringModel>? MatchStrings { get; set; }
}
