namespace Refactoring.Animals;

public class Zoo
{
    public static string MakeNoise(Animal animal)
    {
        try{
            return animal.Noise;
        }catch (Exception e) { 
        throw new ArgumentException("unknown animal, unknown sound");
        }
    }
}