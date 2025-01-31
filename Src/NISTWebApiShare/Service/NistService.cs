using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace NISTWebApi.Service;


// https://nvd.nist.gov/developers/products
// https://nvd.nist.gov/developers/vulnerabilities

internal class NistService(Uri host, string? token, string appName)
    : JsonService(host, null, appName, SourceGenerationContext.Default)
{

    private const int resultsPerPage = 200;

    private const string apiPath = "rest/json/cpes/2.0";

    //protected override string? AuthenticationTestUrl => ""; 

    //protected override async Task ErrorHandlingAsync(HttpResponseMessage response, string memberName, CancellationToken cancellationToken)
    //{
    //    var error = await ReadFromJsonAsync<ErrorsModel>(response, cancellationToken);
    //    throw new WebServiceException(error?.ToString(), response.RequestMessage?.RequestUri, response.StatusCode, response.ReasonPhrase, memberName);
    //}

    #region Products

    public IAsyncEnumerable<CPEModel> GetCPEProductsByNameIdAsync(string match, CancellationToken cancellationToken)
    {
        string requestUri = CombineUrl(apiPath, ("apiKey", token), ("cpeNameId", match));
        return GetProductsAsync(requestUri, cancellationToken);
    }
    
    public IAsyncEnumerable<CPEModel> GetCPEProductsMatchStringAsync(string match, CancellationToken cancellationToken)
    {
        string requestUri = CombineUrl(apiPath, ("apiKey", token), ("cpeMatchString", match));
        return GetProductsAsync(requestUri, cancellationToken);
    }

    public IAsyncEnumerable<CPEModel> GetCPEProductsByKeywordExactMatchAsync(string match, CancellationToken cancellationToken)
    {
        string requestUri = CombineUrl(apiPath, ("apiKey", token), ("keywordSearch", match), ("keywordExactMatch" , ""));
        return GetProductsAsync(requestUri, cancellationToken);
    }

    public IAsyncEnumerable<CPEModel> GetCPEProductsByKeywordSearchAsync(string match, CancellationToken cancellationToken)
    {
        string requestUri = CombineUrl(apiPath, ("apiKey", token), ("keywordSearch", match));
        return GetProductsAsync(requestUri, cancellationToken);
    }

    private async IAsyncEnumerable<CPEModel> GetProductsAsync(string requestUri, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "") 
    {
        long startIndex = 0;
        while (true)
        {
            string reqUri = $"{requestUri}&resultsPerPage={resultsPerPage}&startIndex={startIndex}";
            var page = await GetFromJsonAsync<CPEPageModel>(reqUri, cancellationToken, memberName);
            if (cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            if (page != null)
            {
                foreach (var item in page.Products!)
                {
                    yield return item.CPE!;
                }
                startIndex += page.ResultsPerPage;
            }
            if (page == null || startIndex >= page.TotalResults)
            {
                yield break;
            }
        }
    }

    #endregion

    #region Vulnerabilities

    public async IAsyncEnumerable<CVEItemModel> GetCVEsAsync(string match, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        long startIndex = 0;
        while (true)
        {
            string url = $"rest/json/cves/1.0?apiKey={token}&resultsPerPage={resultsPerPage}&startIndex={startIndex}&cpeMatchString={match}";
            var page = await GetFromJsonAsync<CVEPageModel>(url, cancellationToken, memberName);
            if (page?.Result?.CVEItems != null)
            {
                foreach (var item in page.Result.CVEItems)
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

    #endregion

    public static string ReduceCPE(string cpe)
    {
        string[] items = cpe.Split(':');
        return items.Take(6).Aggregate((a, b) => $"{a}:{b}");
    }
}

