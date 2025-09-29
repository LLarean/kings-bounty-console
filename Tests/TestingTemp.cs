using NUnit.Framework.Legacy;

namespace Tests;

[TestFixture]
public class TestingTemp
{
    [Test]
    public void Test()
    {
        var temp = 1 + 1;
        ClassicAssert.True(temp == 2);
    }
}