namespace NISTWebApi;

public class CPETitle
{
    internal CPETitle(CPETitleModel model)
    {
        Title = model.Title;
        Lang = model.Lang;
    }
    public string? Title { get; }

    public string? Lang { get; }
}
