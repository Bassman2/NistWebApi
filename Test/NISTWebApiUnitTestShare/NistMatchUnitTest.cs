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
        Assert.AreEqual(false, matchString.MatchCriteriaId, nameof(matchString.m.matchCriteriaId));
        Assert.AreEqual(cpeName, matchString.Name, nameof(matchString.Name));
        Assert.AreEqual(cpeNameId, matchString.NameId, nameof(matchString.NameId));

        Assert.IsNotNull(matchString.LastModified, nameof(matchString.LastModified));
        Assert.AreEqual(new DateOnly(2023, 02, 21), DateOnly.FromDateTime(matchString.LastModified.Value), nameof(matchString.LastModified));

        Assert.IsNotNull(matchString.Created, nameof(matchString.Created));
        Assert.AreEqual(new DateOnly(2022, 08, 19), DateOnly.FromDateTime(matchString.Created.Value), nameof(matchString.Created));

        Assert.IsNotNull(matchString.Titles, nameof(matchString.Titles));
        var titles = matchString.Titles.ToList();
        Assert.IsNotNull(titles, nameof(titles));
        Assert.AreEqual(1, titles.Count, nameof(titles.Count));
        Assert.AreEqual("JPEG libjpeg", titles[0].Title);
        Assert.AreEqual("en", titles[0].Lang);

        Assert.IsNotNull(matchString.Refs, nameof(matchString.Refs));
        var refs = matchString.Refs.ToList();
        Assert.IsNotNull(refs, nameof(refs));
        Assert.AreEqual(2, refs.Count, nameof(refs.Count));
        Assert.AreEqual("https://github.com/thorfdbg/libjpeg/issues/79", refs[0].Ref);
        Assert.AreEqual("Advisory", refs[0].Type);
        Assert.AreEqual("https://github.com/thorfdbg/libjpeg", refs[1].Ref);
        Assert.AreEqual("Product", refs[1].Type);
    }

}

