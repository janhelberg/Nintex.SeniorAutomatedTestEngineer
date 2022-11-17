using Xunit;

namespace XUnit.Tests;

public class UnitTest1
{

    [SetUp]
    public void Setup()
    {

    }

    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
}