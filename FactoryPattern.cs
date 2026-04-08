using System;
public abstract class Animals
{
    public abstract void Speak();
}

public class Dogs : Animals
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}
public class Cats : Animals
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalFactory
{
    public static Animals CreateAnimal(string type)
    {
        if (type == "Dog")
        {
            return new Dogs();
        }
        else if (type == "Cat")
        {
            return new Cats();
        }
        else
        {
            throw new ArgumentException("Invalid animal type");
        }
    }
}