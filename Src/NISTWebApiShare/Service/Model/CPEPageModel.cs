namespace NISTWebApi.Service.Model;

internal class CPEPageModel
{
    [JsonPropertyName("resultsPerPage")]
    public long ResultsPerPage { get; set; }

    [JsonPropertyName("startIndex")]
    public long StartIndex { get; set; }

    [JsonPropertyName("totalResults")]
    public long TotalResults { get; set; }

    [JsonPropertyName("result")]
    public CPEResultModel? Result { get; set; }
}