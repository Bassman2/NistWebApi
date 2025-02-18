namespace NistWebApiUnitTest;

[TestClass]
public class NistVulnerabilitiesUnitTest : NistBaseUnitTest
{
    [TestMethod]
    public async Task TestMethodGetCVEsByCPENameAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCVEsByCPENameAsync(cpeName);
        var list = await enu.ToListAsync();

    }

    [TestMethod]
    public async Task TestMethodGetCVEByIdAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCVEByIdAsync(cveId);
        var list = await enu.ToListAsync();

    }
}
