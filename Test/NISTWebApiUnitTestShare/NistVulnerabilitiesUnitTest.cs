namespace NISTWebApiUnitTest;

[TestClass]
public class NistVulnerabilitiesUnitTest : NistBaseUnitTest
{
    [TestMethod]
    public async Task TestMethodCopyMoveDeleteFileAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCPEProductsByNameIdAsync("");
        var list = await enu.ToListAsync();

    }
}
