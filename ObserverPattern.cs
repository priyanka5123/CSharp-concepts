public interface IObservers
{
    void Update(string message);
}
public class ConcreteObserver : IObservers
{
    private string name;
    public ConcreteObserver(string name)
    {
        this.name = name;
    }
    public void Update(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}
public class Subject
{
    private List<IObservers> observers = new List<IObservers>();
    public void Attatch(IObservers observer)
    {
        observers.Add(observer);
    }
    public void Detach(IObservers observer)
    {
        observers.Remove(observer);
    }
    public void Notify(string message)
    {
        foreach(var observer in observers)
        {
            observer.Update(message);
        }
    }
}