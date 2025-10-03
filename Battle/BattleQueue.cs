using kings_bounty_console;

namespace KB.Battle;

public record BattleQueue
{
    private readonly Unit[] _units;
    private int _count;

    public BattleQueue(Unit[] units)
    {
        _units = units;
    }

    public Unit[] SortedUnits()
    {
        return _units.OrderByDescending(x => x.Speed).ToArray();
    }

    public Unit CurrentUnit()
    {
        var unit = _units[_count];
        _count++;
        
        if (_count >= _units.Length)
        {
            _count = 0;
        }
        
        return unit;
    }
}