namespace NISTWebApi.Service.Model;

internal class MatchPageModel : PageModel
{
    [JsonPropertyName("matchStrings")]
    public IEnumerable<MatchStringModel>? MatchStrings { get; set; }

    [JsonIgnore]
    public override IEnumerable<object>? Results => MatchStrings?.Select(r => r.Value!);
}
