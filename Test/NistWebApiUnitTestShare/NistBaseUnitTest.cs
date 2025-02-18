namespace NistWebApiUnitTest;

public abstract class NistBaseUnitTest
{
    protected const string storeKey = "nist";
    protected const string appName = "UnitTest";


    protected static readonly string testHost = KeyStore.Key(storeKey)!.Host!;
    protected static readonly string testUserKey = KeyStore.Key(storeKey)!.Login!;

    protected const string cpeKeyword = "libjpeg";
    protected const string cpeName = "cpe:2.3:a:jpeg:libjpeg:-:*:*:*:*:*:*:*";
    protected readonly static Guid cpeNameId = new("A50FE15A-D2D7-4D0F-8C7F-F3C4692F430A");

    protected const string cveId = "CVE-2021-39515";

}
