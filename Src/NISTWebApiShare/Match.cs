namespace NISTWebApi;

public class Match
{
    internal Match(MatchModel model)
    {
        CpeName = model.CpeName;
        CpeNameId = model.CpeNameId;
    }

    public string? CpeName { get; }

    public string? CpeNameId { get; }
}
