namespace NistWebApi;

public enum CvssV3Vector
{
    [Description("Network")]
    Network,

    [Description("Adjacent Network")]
    AdjacentNetwork,

    [Description("Local")]
    Local,

    [Description("Physical")]
    Physical
}
