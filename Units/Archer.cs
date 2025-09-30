namespace kings_bounty_console;

public record Archer : Unit
{
    public Archer() : base(new UnitCharacteristics(2, 2, 2), 'A', true)
    {
    }
}