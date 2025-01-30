using System.Net.Http.Json;

namespace NISTWebApi.Service;


// https://nvd.nist.gov/developers/products
// https://nvd.nist.gov/developers/vulnerabilities

internal class NistService(Uri host, string token, string appName)
    : JsonService(host, null, appName, SourceGenerationContext.Default)
{

    private const int resultsPerPage = 200;

    //protected override string? AuthenticationTestUrl => ""; 

    //protected override async Task ErrorHandlingAsync(HttpResponseMessage response, string memberName, CancellationToken cancellationToken)
    //{
    //    var error = await ReadFromJsonAsync<ErrorsModel>(response, cancellationToken);
    //    throw new WebServiceException(error?.ToString(), response.RequestMessage?.RequestUri, response.StatusCode, response.ReasonPhrase, memberName);
    //}

    public async IAsyncEnumerable<CPEModel> GetCPEProductsAsync(string keyword, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        long startIndex = 0;
        while (true)
        {
            // string url = $"rest/json/cpes/1.0?resultsPerPage={resultsPerPage}&startIndex={startIndex}&cpeMatchString={match}&keyword={keyword}";
            string url = $"rest/json/cpes/1.0?apiKey={token}&resultsPerPage={resultsPerPage}&startIndex={startIndex}&keyword={keyword}";
            var page = await GetFromJsonAsync<CPEPageModel>(url, cancellationToken, memberName);
            if (page?.Result.CPEs != null)
            {
                foreach (var item in page.Result.CPEs)
                {
                    yield return item;
                }
                startIndex += page.ResultsPerPage;
            }
            if (page == null || startIndex >= page.TotalResults)
            {
                yield break;
            }

        } 
    }

    public async IAsyncEnumerable<CPEModel> GetCPEVersionsAsync(string match, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        long startIndex = 0;
        while(true)
        {
            string url = $"rest/json/cpes/1.0?apiKey={token}&resultsPerPage={resultsPerPage}&startIndex={startIndex}&cpeMatchString={match}";
            var page = await GetFromJsonAsync<CPEPageModel>(url, cancellationToken, memberName);
            if (page?.Result.CPEs != null)
            {
                foreach (var item in page.Result.CPEs)
                {
                    yield return item;
                }
                startIndex += page.ResultsPerPage;
            }
            if (page == null|| startIndex >=  page.TotalResults)
            {
                yield break;
            }
        }
    }

    public async IAsyncEnumerable<CVEItemModel> GetCVEsAsync(string match, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        long startIndex = 0;
        while (true)
        {
            string url = $"rest/json/cves/1.0?apiKey={token}&resultsPerPage={resultsPerPage}&startIndex={startIndex}&cpeMatchString={match}";
            var page = await GetFromJsonAsync<CVEPageModel>(url, cancellationToken, memberName);
            if (page?.Result?.CVE_Items != null)
            {
                foreach (var item in page.Result.CVE_Items)
                {
                    yield return item;
                }
                startIndex += page.ResultsPerPage;
            }
            if (page == null || startIndex >= page.TotalResults)
            {
                yield break;
            }
        } 
    }

    public static string ReduceCPE(string cpe)
    {
        string[] items = cpe.Split(':');
        return items.Take(6).Aggregate((a, b) => $"{a}:{b}");
    }
}

