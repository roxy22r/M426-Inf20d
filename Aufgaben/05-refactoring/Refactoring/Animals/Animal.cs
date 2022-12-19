namespace Refactoring.Animals;

public abstract class Animal
{
    public string Name { get; }
    public virtual string Noise { get;}
    
    public Animal(string name)
    {
        this.Name = name;
    }
}