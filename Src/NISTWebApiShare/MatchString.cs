namespace NISTWebApi;

public class MatchString
{
    internal MatchString(MatchStringModel model)
    {
        MatchCriteriaId = model.MatchCriteriaId;
        Criteria = model.Criteria;
        VersionEndExcluding = model.VersionEndExcluding;
        LastModified = model.LastModified;
        CpeLastModified = model.CpeLastModified;
        Created = model.Created;
        Status = model.Status;
        Matches = model.Matches.CastModel<Match>();
    }

    public string? MatchCriteriaId { get; }

    public string? Criteria { get; }

    public string? VersionEndExcluding { get; }

    public DateTime? LastModified { get; }

    public DateTime? CpeLastModified { get; }

    public DateTime? Created { get; }

    public string? Status { get; }

    public List<Match>? Matches { get; }
}
