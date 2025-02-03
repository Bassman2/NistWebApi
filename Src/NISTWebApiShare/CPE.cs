namespace NISTWebApi;

public class CPE
{
    internal CPE(CPEModel model)
    {
        Deprecated = model.Deprecated;
        Name = model.Name;
        NameId = model.NameId;
        LastModified = model.LastModified;
        Created = model.Created;
        Titles = model.Titles.CastModel<CPETitle>();
        Refs = model.Refs.CastModel<CPERef>();
    }

    public bool Deprecated { get; }

    public string? Name { get; }

    public string? NameId { get; }

    public DateTime? LastModified { get; }

    public DateTime? Created { get; }

    public List<CPETitle>? Titles { get; }

    public List<CPERef>? Refs { get; }
}
