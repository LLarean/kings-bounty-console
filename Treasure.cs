using KB.WorldMap;

namespace KB;

public record Treasure
{
    private readonly int _gold;

    public Treasure(int gold)
    {
        _gold = gold;
    }
    
    public int Gold => _gold;
}