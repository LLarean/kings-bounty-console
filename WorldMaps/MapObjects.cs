using KB.General;

namespace KB.WorldMaps;

public class MapObjects
{
    private readonly int _mapCount;
    
    private Dictionary<object, Position> _mapContent;
    private bool _isLoaded;

    public MapObjects(int mapCount)
    {
        _mapCount = mapCount;
    }

    public bool IsLoaded() => _isLoaded;
    
    public Dictionary<object, Position> Content => _mapContent;

    public void Load()
    {
        _mapContent = new Dictionary<object, Position>();
        
        var hero = new Hero(new Position(4, 5));
        _mapContent.Add(hero, new Position(4, 4));

        Treasure treasure = new Treasure(100);
        _mapContent.Add(treasure, new Position(7, 2));
        
        _isLoaded = true;
    }
}