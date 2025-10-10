namespace KB.General;

public record UnitCharacteristics
{
    private readonly int _health;
    private readonly int _speed;
    private readonly int _attack;

    public UnitCharacteristics(int health, int speed, int attack)
    {
        _health = health;
        _speed = speed;
        _attack = attack;
    }
    
    public int Health => _health;
    public int Speed => _speed;
    public int Attack => _attack;
}