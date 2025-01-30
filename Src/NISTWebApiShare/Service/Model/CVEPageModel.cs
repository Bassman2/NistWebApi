namespace NISTWebApi.Service.Model;

internal class CVEPageModel
{
    [JsonPropertyName("resultsPerPage")]
    public long ResultsPerPage { get; set; }

    [JsonPropertyName("startIndex")]
    public long StartIndex { get; set; }

    [JsonPropertyName("totalResults")]
    public long TotalResults { get; set; }

    [JsonPropertyName("result")]
    public CVEResultModel? Result { get; set; }
}
