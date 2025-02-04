namespace NISTWebApi;

public class DevTitle
{
    internal DevTitle(DefTitleModel model)
    {
        Title = model.Title;
        Lang = model.Lang;
    }
    public string? Title { get; }

    public string? Lang { get; }
}
