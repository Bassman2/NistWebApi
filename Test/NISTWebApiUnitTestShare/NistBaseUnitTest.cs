namespace NISTWebApiUnitTest;

public abstract class NistBaseUnitTest
{
    protected const string storeKey = "nist";
    protected const string appName = "UnitTest";


    protected static readonly string testHost = KeyStore.Key(storeKey)!.Host!;
    protected static readonly string testUserKey = KeyStore.Key(storeKey)!.Login!;
}
