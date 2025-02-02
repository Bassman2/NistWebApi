namespace NISTWebApi;

public sealed class Nist : IDisposable
{
    private NistService? service;

    public Nist(string storeKey, string appName)
        : this(new Uri(KeyStore.Key(storeKey)?.Host!), KeyStore.Key(storeKey)!.Token!, appName)
    { }

    public Nist(Uri host, string token, string appName)
    {
        //service = new(host, token, appName);
        service = new(host, null, appName);
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

    public async IAsyncEnumerable<CPE> GetCPEProductsByNameIdAsync(string nameId, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);
        
        var res = service.GetCPEsAsync([("cpeNameId", nameId)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CPE>()!;
        }
    }

    public async IAsyncEnumerable<CPE> GetCPEProductsMatchStringAsync(string matchString, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("cpeMatchString", matchString)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CPE>()!;
        }
    }

    public async IAsyncEnumerable<CPE> GetCPEProductsByKeywordExactMatchAsync(string keywordSearch, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("keywordSearch", keywordSearch), ("keywordExactMatch", "")], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CPE>()!;
        }
    }

    public async IAsyncEnumerable<CPE> GetCPEProductsByKeywordSearchAsync(string keywordSearch, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        WebServiceException.ThrowIfNullOrNotConnected(this.service);

        var res = service.GetCPEsAsync([("keywordSearch", keywordSearch)], cancellationToken);
        await foreach (var item in res)
        {
            yield return item.CastModel<CPE>()!;
        }
    }
}
