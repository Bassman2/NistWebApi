namespace NISTWebApi;

public class CPE
{
    internal CPE(CPEModel model)
    {
        Cpe23Uri = model.Cpe23Uri;
    }

    public string? Cpe23Uri { get; }
}
