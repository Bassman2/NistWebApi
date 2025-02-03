namespace NISTWebApi.Service;


// https://nvd.nist.gov/developers/products
// https://nvd.nist.gov/developers/vulnerabilities

internal class NistService(Uri host, IAuthenticator? authenticator, string appName)
    : JsonService(host, authenticator, appName, SourceGenerationContext.Default)
{
    //private const int resultsPerPage = 200;

    //protected override string? AuthenticationTestUrl => ""; 

    protected override async Task ErrorHandlingAsync(HttpResponseMessage response, string memberName, CancellationToken cancellationToken)
    {
        if (!response.IsSuccessStatusCode)
        {
            var error = "";
            if (response.Headers.TryGetValues("message", out var values))
            {
                error = values.FirstOrDefault();
            }
            throw new WebServiceException(error?.ToString(), response.RequestMessage?.RequestUri, response.StatusCode, response.ReasonPhrase, memberName);
        }
        await Task.Delay(0, cancellationToken);
    }

    #region Products

    public IAsyncEnumerable<CPEModel> GetCPEsAsync((string Name, object? Value)[] values, CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cpes/2.0", values);
        return GetPagesAsync<CPEModel, CPEPageModel>(requestUri, cancellationToken, memberName);
    }

    public IAsyncEnumerable<CPEModel> GetCPEMatchAsync((string Name, object? Value)[] values, CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cpematch/2.0", values);
        return GetPagesAsync<CPEModel, MatchPageModel>(requestUri, cancellationToken, memberName);
    }

    #endregion

    #region Vulnerabilities

    public IAsyncEnumerable<CVEItemModel> GetCVEsAsync((string Name, object? Value)[] values, CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cves/2.0", values);
        return GetPagesAsync<CVEItemModel, CVEPageModel>(requestUri, cancellationToken, memberName);
    }

    public IAsyncEnumerable<CVEItemModel> GetCVEHistoryAsync((string Name, object? Value)[] values, CancellationToken cancellationToken, [CallerMemberName] string memberName = "")
    {
        string requestUri = CombineUrl("rest/json/cvehistory/2.0", values);
        return GetPagesAsync<CVEItemModel, HistoryPageModel>(requestUri, cancellationToken, memberName);
    }

    #endregion


    public async IAsyncEnumerable<T> GetPagesAsync<T, P>(string requestUri, [EnumeratorCancellation] CancellationToken cancellationToken, [CallerMemberName] string memberName = "") where P : PageModel
    {
        string reqUri = requestUri;
        long startIndex = 0;
        long totalResults = 1;
        while (startIndex < totalResults) 
        {
            var page = await GetFromJsonAsync<P>(reqUri, cancellationToken, memberName);
            if (page == null || cancellationToken.IsCancellationRequested)
            {
                yield break;
            }

            foreach (var item in page.Results!)
            {
                yield return (T)item;
            }

            startIndex += page.ResultsPerPage;
            totalResults = page.TotalResults;
            reqUri = CombineUrl(requestUri, ("startIndex", startIndex));
        } 
    }
}

