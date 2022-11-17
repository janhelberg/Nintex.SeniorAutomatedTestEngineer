using NUnit.Framework;

namespace NUnit.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
      Validate()  val = new Validate();
    }

    [Test]
    public void HappyTest()
    {
        var result = val.validate(1);

        Assert.Pass(result);
    }


   [Test]
    public void Negativetest1()
    {
        var result = val.validate(0);

        Assert.Fail(result);
    }

       [Test]
    public void Negativetest2()
    {
        var result = val.validate(2);

        Assert.Fail(result);
    }

     [Test]
    public void Negativetest2()
    {
        var result = val.validate("1");

        Assert.Fail(result);
    }

}
