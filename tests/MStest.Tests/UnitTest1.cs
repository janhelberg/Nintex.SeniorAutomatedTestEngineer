using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStest.Tests;

[TestClass]
public class UnitTest1
{

    [SetUp]
    public void Setup()
    {

    }
    
    [TestMethod]
    public void TestMethod1()
    {
        Assert.IsTrue(true);
    }
}