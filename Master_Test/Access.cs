namespace Master_Test;

/// <summary>
/// Used for testing access
/// </summary>
[TestClass]
public class Access
{
    [TestMethod]
    public void TestAccessEasy()
    {
        Assert.AreEqual("Easy", EasyProgram.GetClass());
    }

    [TestMethod]
    public void TestMediumAccess()
    {
        Assert.AreEqual("Medium", MediumProgram.GetClass());
    }

    [TestMethod]
    public void TestHardAccess()
    {
        Assert.AreEqual("Hard", HardProgram.GetClass());
    }
}
