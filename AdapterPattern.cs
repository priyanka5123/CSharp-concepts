//The Adapter pattern allows incompatible interfaces to work together by wrapping an existing class with a new interface.
// Why Use Adapter Pattern?

// 1 When you can’t change existing code (Adaptee)
// 2 When interfaces don’t match
// 3 To reuse old or third-party classes
public interface ITarget
{
    void Request();
}
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request is called.");
    }
}
public class Adapter : ITarget
{
    private Adaptee adaptee;
    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }
    public void Request()
    {
        adaptee.SpecificRequest();
    }

}