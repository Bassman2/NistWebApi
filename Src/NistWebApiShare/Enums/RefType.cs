namespace NistWebApi;

public enum RefType
{
    Advisory,
    [EnumMember(Value = "Change Log")]
    ChangeLog,
    Product,
    Project,
    Vendor,
    Version
}
