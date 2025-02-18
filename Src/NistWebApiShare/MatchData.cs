namespace NistWebApi;

public class MatchData
{
    internal MatchData(MatchDataModel model)
    {
        MatchCriteriaId = model.MatchCriteriaId;
        Criteria = model.Criteria;
        VersionEndExcluding = model.VersionEndExcluding;
        LastModified = model.LastModified;
        CpeLastModified = model.CpeLastModified;
        Created = model.Created;
        Status = model.Status;
        Matches = model.Matches.CastModel<Name>();
    }

    public string? MatchCriteriaId { get; }

    public string? Criteria { get; }

    public string? VersionEndExcluding { get; }

    public DateTime? LastModified { get; }

    public DateTime? CpeLastModified { get; }

    public DateTime? Created { get; }

    public string? Status { get; }

    public List<Name>? Matches { get; }
}
