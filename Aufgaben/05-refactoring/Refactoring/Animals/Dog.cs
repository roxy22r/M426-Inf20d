namespace Refactoring.Animals;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }


    public override string Noise=> base.Name + " says 'woof'";
}

