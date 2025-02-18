namespace NistWebApi;

public sealed class Nist : IDisposable
{
    private NistService? service;

    public Nist(string storeKey, string appName)
        : this(new Uri(KeyStore.Key(storeKey)?.Host!), KeyStore.Key(storeKey)!.Token!, appName)
    { }

    public Nist(Uri host, string token, string appName)
    {
        service = new(host, new ApiKeyAuthenticator("apikey", token), appName);
    }

    public void Dispose()
    {
        if (this.service != null)
        {
            this.service.Dispose();
            this.service = null;
        }
        GC.SuppressFinalize(this);
    }

    #region Products

    public async IAsyncEnumerable<Cpe> GetCPEProductsByNameIdAsync(Guid nameId, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);
        
        var res = service.GetCPEsAsync([("cpeNameId", nameId.ToString().ToUpper())], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<Cpe>()!;
        }
    }

    public async IAsyncEnumerable<Cpe> GetCPEProductsMatchStringAsync(string matchString, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("cpeMatchString", matchString)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<Cpe>()!;
        }
    }

    public async IAsyncEnumerable<Cpe> GetCPEProductsByKeywordExactMatchAsync(string keywordSearch, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("keywordSearch", keywordSearch), ("keywordExactMatch", "")], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<Cpe>()!;
        }
    }

    public async IAsyncEnumerable<Cpe> GetCPEProductsByKeywordSearchAsync(string keywordSearch, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("keywordSearch", keywordSearch)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<Cpe>()!;
        }
    }

    public async IAsyncEnumerable<MatchData> GetCPEMatchByCVEIdAsync(string cveId, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEMatchAsync([("cveId", cveId)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<MatchData>()!;
        }
    }

    #endregion

    #region Vulnerabilities

    public async IAsyncEnumerable<CVEItem> GetCVEsByCPENameAsync(string cpeName, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCVEsAsync([("cpeName", cpeName)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CVEItem>()!;
        }
    }

    public async IAsyncEnumerable<CVEItem> GetCVEByIdAsync(string cveId, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCVEsAsync([("cveId", cveId)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CVEItem>()!;
        }
    }

    #endregion
}
