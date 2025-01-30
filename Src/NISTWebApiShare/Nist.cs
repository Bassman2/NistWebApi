namespace NISTWebApi;

public sealed class Nist : IDisposable
{
    private NistService? service;

    public Nist(string storeKey, string appName)
        : this(new Uri(KeyStore.Key(storeKey)?.Host!), KeyStore.Key(storeKey)!.Token!, appName)
    { }

    public Nist(Uri host, string token, string appName)
    {
        service = new(host, token, appName);
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
}
