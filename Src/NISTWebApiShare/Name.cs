namespace NISTWebApi;

public class Name
{
    internal Name(NameModel model)
    {
        CpeName = model.CpeName;
        CpeNameId = model.CpeNameId;
    }

    public string? CpeName { get; }

    public Guid? CpeNameId { get; }
}
