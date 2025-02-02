namespace NISTWebApi.Service;


// https://nvd.nist.gov/developers/products
// https://nvd.nist.gov/developers/vulnerabilities

internal class NistService(Uri host, string? token, string appName)
    : JsonService(host, null, appName, SourceGenerationContext.Default)
{
    private const int resultsPerPage = 200;

    //protected override string? AuthenticationTestUrl => ""; 

    //protected override async Task ErrorHandlingAsync(HttpResponseMessage response, string memberName, CancellationToken cancellationToken)
    //{
    //    var error = await ReadFromJsonAsync<ErrorsModel>(response, cancellationToken);
    //    throw new WebServiceException(error?.ToString(), response.RequestMessage?.RequestUri, response.StatusCode, response.ReasonPhrase, memberName);
    //}

    #region Products

    public async IAsyncEnumerable<CPEModel> GetCPEsAsync((string Name, object? Value)[] values, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cpes/2.0", values);
        
        long startIndex = 0;
        while (true)
        {
            string reqUri = CombineUrl(requestUri, ("resultsPerPage", resultsPerPage), ("startIndex" , startIndex), ("apikey" , token));
            var page = await GetFromJsonAsync<CPEPageModel>(reqUri, cancellationToken, memberName);
            if (page == null || startIndex >= page.TotalResults || cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            foreach (var item in page.Products!)
            {
                yield return item.CPE!;
            }
            startIndex += page.ResultsPerPage;
        }
    }

    public async IAsyncEnumerable<CPEModel> GetCPEMatchAsync((string Name, object? Value)[] values, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cpematch/2.0", values);

        long startIndex = 0;
        while (true)
        {
            string reqUri = CombineUrl(requestUri, ("resultsPerPage", resultsPerPage), ("startIndex", startIndex), ("apikey", token));
            var page = await GetFromJsonAsync<MatchPageModel>(reqUri, cancellationToken, memberName);
            if (page == null || startIndex >= page.TotalResults || cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            foreach (var item in page.MatchStrings!)
            {
                yield return item.Value!;
            }
            startIndex += page.ResultsPerPage;
        }
    }

    #endregion

    #region Vulnerabilities

    public async IAsyncEnumerable<CVEItemModel> GetCVEsAsync((string Name, object? Value)[] values, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cves/2.0", values);

        long startIndex = 0;
        while (true)
        {
            string reqUri = CombineUrl(requestUri, ("resultsPerPage", resultsPerPage), ("startIndex", startIndex), ("apikey", token));
            var page = await GetFromJsonAsync<CVEPageModel>(reqUri, cancellationToken, memberName);
            if (page == null || startIndex >= page.TotalResults || cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            foreach (var item in page.Vulnerabilities!)
            {
                yield return item.Value!;
            }
            startIndex += page.ResultsPerPage;
        }
    }

    public async IAsyncEnumerable<CVEItemModel> GetCVEHistoryAsync((string Name, object? Value)[] values, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cvehistory/2.0", values);

        long startIndex = 0;
        while (true)
        {
            string reqUri = CombineUrl(requestUri, ("resultsPerPage", resultsPerPage), ("startIndex", startIndex), ("apikey", token));
            var page = await GetFromJsonAsync<HistoryPageModel>(reqUri, cancellationToken, memberName);
            if (page == null || startIndex >= page.TotalResults || cancellationToken.IsCancellationRequested)
            {
                yield break;
            }
            foreach (var item in page.CVEChanges!)
            {
                yield return item.Value!;
            }
            startIndex += page.ResultsPerPage;
        }

    }

    #endregion
}

