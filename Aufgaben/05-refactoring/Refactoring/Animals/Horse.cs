namespace Refactoring.Animals;

public class Horse : Animal
{
    public Horse(string name) : base(name) { }

    public override string Noise  => base.Name+ " says 'neigh'"; 
}