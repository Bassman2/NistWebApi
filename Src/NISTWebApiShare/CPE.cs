namespace NISTWebApi;

public class Cpe
{
    internal Cpe(CpeModel model)
    {
        Deprecated = model.Deprecated;
        Name = model.CpeName;
        NameId = model.CpeNameId;
        Created = model.Created;
        LastModified = model.LastModified;
        Titles = model.Titles.CastModel<DevTitle>();
        Refs = model.Refs.CastModel<CPERef>();
    }

    public bool Deprecated { get; }

    public string? Name { get; }

    public Guid NameId { get; }

    public DateTime? Created { get; }

    public DateTime? LastModified { get; }

    public List<DevTitle>? Titles { get; }

    public List<CPERef>? Refs { get; }
}
