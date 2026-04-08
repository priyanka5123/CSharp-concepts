using System;
public class NewPerson
{
    public string Name{get; set;}
    public int Age{get; set;}
    
    public void Greet()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");   
    }
}