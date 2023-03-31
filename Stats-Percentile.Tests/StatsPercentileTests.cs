namespace Stats_Percentile.Tests;

[TestClass]
public class StatsPercentileTests
{
    [TestMethod]
    [DataRow(new[] { 35, 20, 15, 50, 40 })]
    public void IsPercentile_1(int[] data)
    {
        Assert.AreEqual(20, StatsPercentile.Percentile(data, 30));
        Assert.AreEqual(20, StatsPercentile.Percentile(data, 40));
        Assert.AreEqual(35, StatsPercentile.Percentile(data, 50));
        Assert.AreEqual(50, StatsPercentile.Percentile(data, 100));
    }

    [TestMethod]
    [DataRow(new[] { 3, 6, 7, 8, 8, 10, 13, 15, 16, 20 })]
    public void IsPercentile_2(int[] data)
    {
        Assert.AreEqual(7, StatsPercentile.Percentile(data, 25));
        Assert.AreEqual(8, StatsPercentile.Percentile(data, 50));
        Assert.AreEqual(15, StatsPercentile.Percentile(data, 75));
        Assert.AreEqual(20, StatsPercentile.Percentile(data, 100));
    }

    [TestMethod]
    [DataRow(new[] { 3, 6, 7, 8, 8, 9, 10, 13, 15, 16, 20 })]
    public void IsPercentile_3(int[] data)
    {
        Assert.AreEqual(7, StatsPercentile.Percentile(data, 25));
        Assert.AreEqual(9, StatsPercentile.Percentile(data, 50));
        Assert.AreEqual(15, StatsPercentile.Percentile(data, 75));
        Assert.AreEqual(20, StatsPercentile.Percentile(data, 100));
    }

    [TestMethod]
    [DataRow(new[]
    {
        10, 13, 15, 16, 20, 3, 6, 7, 7, 15, 19, 23, 33, 8, 19, 35, 22, 17, 19, 29,
        13, 13, 15, 16, 22, 3, 8, 7, 1, 14, 19, 23, 33, 8, 19, 35, 21, 17, 19, 29,
        17, 13, 19, 16, 20, 3, 9, 7, 25, 15, 18, 13, 23, 7, 11, 35, 22, 1, 9, 9,
        13, 12, 15, 14, 21, 5, 6, 5, 7, 16, 16, 23, 47, 8, 19, 35, 29, 17, 19, 29,
        15, 13, 15, 8, 20, 3, 6, 7, 7, 17, 19, 23, 43, 8, 19, 35, 22, 17, 19, 9,
        10, 19, 14, 16, 26, 9, 5, 7, 17, 18, 12, 25, 63, 8, 19, 35, 22, 17, 15, 16
    })]
    public void IsPercentile_4(int[] data)
    {
        Assert.AreEqual(6, StatsPercentile.Percentile(data, 10));
        Assert.AreEqual(11, StatsPercentile.Percentile(data, 30));
        Assert.AreEqual(14, StatsPercentile.Percentile(data, 40));
        Assert.AreEqual(35, StatsPercentile.Percentile(data, 95));
        Assert.AreEqual(47, StatsPercentile.Percentile(data, 99));
        Assert.AreEqual(63, StatsPercentile.Percentile(data, 100));
    }

    [TestMethod]
    [DataRow(new[] { 3 })]
    public void IsPercentile_5(int[] data)
    {
        Assert.AreEqual(3, StatsPercentile.Percentile(data, 25));
        Assert.AreEqual(3, StatsPercentile.Percentile(data, 50));
        Assert.AreEqual(3, StatsPercentile.Percentile(data, 75));
        Assert.AreEqual(3, StatsPercentile.Percentile(data, 100));
    }

    [TestMethod]
    [DataRow(new[]
    {
        10, 13, 15, 16, 20, 3, 6, 7, 7, 15, 19, 13,
        13, 8, 19, 35, 22, 17, 19, 19, 12, 21, 9, 9, 12
    })]
    public void IsPercentile_6(int[] data)
    {
        Assert.AreEqual(22, StatsPercentile.Percentile(data, 95));
    }
}