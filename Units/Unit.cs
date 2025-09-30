namespace kings_bounty_console;

public record Unit
{
    private readonly UnitCharacteristics _unitCharacteristics;
    private readonly char _symbol;
    private readonly bool _isEnemy;

    public Unit(UnitCharacteristics unitCharacteristics, char symbol, bool canShoot = false, bool isEnemy = false)
    {
        _unitCharacteristics = unitCharacteristics;
        _symbol = symbol;
        _isEnemy = isEnemy;
    }
    
    public int Health => _unitCharacteristics.Health;
    public int Speed => _unitCharacteristics.Speed;
    public int Attack => _unitCharacteristics.Attack;

    public char Symbol => _symbol;
    public bool IsEnemy => _isEnemy;
}