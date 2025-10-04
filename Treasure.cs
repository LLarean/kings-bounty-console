namespace KB;

public record Treasure
{
    private readonly int _value;

    public Treasure(int value)
    {
        _value = value;
    }
    
    public int Value => _value;
}