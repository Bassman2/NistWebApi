namespace NISTWebApi;

public class Title
{
    internal Title(TitleModel model)
    {
        Title_ = model.Title;
        Lang = model.Lang;
    }
    public string? Title_ { get; }

    public string? Lang { get; }
}
