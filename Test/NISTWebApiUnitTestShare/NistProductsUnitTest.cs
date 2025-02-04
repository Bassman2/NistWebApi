namespace NISTWebApiUnitTest;

[TestClass]
public class NistProductsUnitTest : NistBaseUnitTest
{

    [TestMethod]
    public async Task TestMethodCPEProductsByNameIdAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCPEProductsByNameIdAsync(cpeNameId);
        var cpe = await enu.SingleOrDefaultAsync();

        Assert.IsNotNull(cpe, nameof(cpe));
        Assert.AreEqual(false, cpe.Deprecated, nameof(cpe.Deprecated));
        Assert.AreEqual(cpeName, cpe.Name, nameof(cpe.Name));
        Assert.AreEqual(cpeNameId, cpe.NameId, nameof(cpe.NameId));

        Assert.IsNotNull(cpe.LastModified, nameof(cpe.LastModified));
        Assert.AreEqual(new DateOnly(2023, 02, 21), DateOnly.FromDateTime(cpe.LastModified.Value), nameof(cpe.LastModified));

        Assert.IsNotNull(cpe.Created, nameof(cpe.Created));
        Assert.AreEqual(new DateOnly(2022, 08, 19), DateOnly.FromDateTime(cpe.Created.Value), nameof(cpe.Created));

        Assert.IsNotNull(cpe.Titles, nameof(cpe.Titles));
        var titles = cpe.Titles.ToList();
        Assert.IsNotNull(titles, nameof(titles));
        Assert.AreEqual(1, titles.Count, nameof(titles.Count));
        Assert.AreEqual("JPEG libjpeg", titles[0].Title);
        Assert.AreEqual("en", titles[0].Lang);

        Assert.IsNotNull(cpe.Refs, nameof(cpe.Refs));
        var refs = cpe.Refs.ToList();
        Assert.IsNotNull(refs, nameof(refs));
        Assert.AreEqual(2, refs.Count, nameof(refs.Count));
        Assert.AreEqual("https://github.com/thorfdbg/libjpeg/issues/79", refs[0].Ref);
        Assert.AreEqual("Advisory", refs[0].Type);
        Assert.AreEqual("https://github.com/thorfdbg/libjpeg", refs[1].Ref);
        Assert.AreEqual("Product", refs[1].Type);
    }

    [TestMethod]
    public async Task TestMethodGetCPEProductsMatchStringAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCPEProductsMatchStringAsync(cpeName);
        var list = await enu.ToListAsync();
    }

    [TestMethod]
    public async Task TestMethodGetCPEProductsByKeywordSearchAsync()
    {
        using var nist = new Nist(storeKey, appName);

        var enu = nist.GetCPEProductsByKeywordSearchAsync(cpeKeyword);
        var list = await enu.ToListAsync();
    }
}
