using System.Reflection.Metadata;

namespace NISTWebApiUnitTest;

[TestClass]
public class NistMatchUnitTest : NistBaseUnitTest
{

    private const string cve = "CVE-2023-37837";

    [TestMethod]
    public async Task TestMethodGetCPEProductsMatchStringAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCPEMatchByCVEIdAsync(cve);
        var matchString = await enu.SingleOrDefaultAsync();

        Assert.IsNotNull(matchString, nameof(matchString));
        Assert.AreEqual("545CB955-BDCF-49BB-A90B-66615E83283B", matchString.MatchCriteriaId, nameof(matchString.MatchCriteriaId));
        Assert.AreEqual("cpe:2.3:a:jpeg:libjpeg:*:*:*:*:*:*:*:*", matchString.Criteria, nameof(matchString.Criteria));
        Assert.AreEqual("1.66", matchString.VersionEndExcluding, nameof(matchString.VersionEndExcluding));

        Assert.IsNotNull(matchString.LastModified, nameof(matchString.LastModified));
        Assert.AreEqual(new DateOnly(2023, 09, 28), DateOnly.FromDateTime(matchString.LastModified.Value), nameof(matchString.LastModified));

        Assert.IsNotNull(matchString.CpeLastModified, nameof(matchString.CpeLastModified));
        Assert.AreEqual(new DateOnly(2023, 07, 24), DateOnly.FromDateTime(matchString.CpeLastModified.Value), nameof(matchString.Created));

        Assert.IsNotNull(matchString.Created, nameof(matchString.Created));
        Assert.AreEqual(new DateOnly(2023, 07, 24), DateOnly.FromDateTime(matchString.Created.Value), nameof(matchString.Created));

        Assert.AreEqual("Active", matchString.Status, nameof(matchString.Status));



        Assert.IsNotNull(matchString.Matches, nameof(matchString.Matches));
       
        Assert.AreEqual(2, matchString.Matches.Count, nameof(matchString.Matches.Count));
        Assert.AreEqual("cpe:2.3:a:jpeg:libjpeg:-:*:*:*:*:*:*:*", matchString.Matches[0].CpeName);
        Assert.AreEqual("A50FE15A-D2D7-4D0F-8C7F-F3C4692F430A", matchString.Matches[0].CpeNameId);
        Assert.AreEqual("cpe:2.3:a:jpeg:libjpeg:1.63:*:*:*:*:*:*:*", matchString.Matches[1].CpeName);
        Assert.AreEqual("4ECB946E-DF9E-401A-8A10-29ACFECE7322", matchString.Matches[1].CpeNameId);
    }

}

