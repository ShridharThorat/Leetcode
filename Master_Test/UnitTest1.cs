namespace Master_Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual("Example 1", Solution1.ex1());
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreEqual("Example 2", Solution2.ex2());
    }
}