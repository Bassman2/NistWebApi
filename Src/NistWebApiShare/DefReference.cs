namespace NISTWebApi;

public class DefReference
{
    internal DefReference(DefReferenceModel model)
    {
        Ref = model.Ref;
        Type = model.Type;
    }

    public string? Ref { get; }

    public string? Type { get; }
}
