public interface IAnimal
{
    void Eat();
}

public class Animal: IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Eating food");
    }
}
public class Dog: Animal
{
    public override void Eat()
    {
        Console.WriteLine("Kibble");
    }
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
public class Cat: Animal
{
    public override void Eat()
    {
        Console.WriteLine("Tuna");
    }
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}