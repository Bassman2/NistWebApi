namespace NISTWebApi;


public enum CVEScoreVersion
{
    [EnumMember(Value = "2.0")]
    [Description("CVSS Version 2.0")]
    V20,

    [EnumMember(Value = "3.0")]
    [Description("VCSS Version 3.0")]
    V30,

    [EnumMember(Value = "3.1")]
    [Description("CVSS Version 3.1")]
    V31,
}

