namespace kings_bounty_console;

public class Unit
{
    private int _health;
    private int _speed;
    private int _attack;
    private char _symbol;

    public Unit(int health, int speed, int attack, char symbol, bool canShoot = false)
    {
        _health = health;
        _speed = speed;
        _attack = attack;
        _symbol = symbol;
    }
    
    public int Health => _health;
    public int Speed => _speed;
    public int Attack => _attack;
    public char Symbol => _symbol;
}