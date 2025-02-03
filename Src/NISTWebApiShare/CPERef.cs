namespace NISTWebApi;

public class CPERef
{
    internal CPERef(CPERefModel model)
    {
        Ref = model.Ref;
        Type = model.Type;
    }

    public string? Ref { get; }

    public string? Type { get; }
}
