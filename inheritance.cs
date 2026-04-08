using System;

public class Pool
{
    public int chlorineLevel;
    public int waterLevel;
    public Pool (int chlorine, int water)
    {
        chlorineLevel = chlorine;
        waterLevel = water;
    }
    public void PoolInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel}, {waterLevel}");
    }
}
public class Spa : Pool
{
    public int heatLevel;
    public Spa (int chlorine, int water, int heat): base(chlorine, water)
    {
        heatLevel = heat;
    }
    public void SpaInfo()
    {
        Console.WriteLine($"Spa: {chlorineLevel}, {waterLevel}, {heatLevel}");
    }
}