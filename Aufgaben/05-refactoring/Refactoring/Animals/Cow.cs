namespace Refactoring.Animals;

public class Cow : Animal
{
    public Cow(string name) : base(name) { }

    public override string Noise => base.Name+" says 'mooh'";
}