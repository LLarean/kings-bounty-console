namespace KB.WorldMap;

public record Peasant  : Unit
{
    public Peasant() : base(new UnitCharacteristics(1, 1, 1), 'P')
    {
    }
}