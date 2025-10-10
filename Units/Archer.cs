namespace KB.WorldMap;

public record Archer : Unit
{
    public Archer() : base(new UnitCharacteristics(2, 2, 2), 'A', true)
    {
    }
}