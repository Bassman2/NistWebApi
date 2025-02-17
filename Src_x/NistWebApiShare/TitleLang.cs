namespace NISTWebApi;

public class TitleLang
{
    internal TitleLang(TitleLangModel model)
    {
        Title = model.Title;
        Lang = model.Lang;
    }
    public string? Title { get; }

    public string? Lang { get; }
}
