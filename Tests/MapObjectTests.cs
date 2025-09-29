using kings_bounty_console.Maps;

namespace Tests;

[TestFixture]
public class MapObjectTests
{
    [Test]
    public void Ctor_PassArray_DoesNotThrow()
    {
        char[,] map =
        {
            { '1', '@', '/' },
            { 's', '-', '"' }
        };
        
        Assert.DoesNotThrow(() =>
        {
            new MapObject(map);
        });
    }
    
    [Test]
    public void Ctor_PassEmptyArray_DoesNotThrow()
    {
        char[,] map = new char[,]{};
        
        Assert.DoesNotThrow(() =>
        {
            new MapObject(map);
        });
    }
    
    [Test]
    public void Ctor_PassNull_DoesNotThrow()
    {
        char[,] map = null;

        Assert.DoesNotThrow(() =>
        {
            new MapObject(map);
        });
    }
}