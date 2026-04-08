using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(int temperature);
}

public class PhoneDisplay : IObserver
{
    public void Update(int temperature)
    {
        Console.WriteLine("Phone display: " + temperature);
    }
}

public class DesktopDisplay : IObserver
{
    public void Update(int temperature)
    {
        Console.WriteLine("Desktop display: " + temperature);
    }
}

public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private int temperature;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObserver()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(int newTemperature)
    {
        temperature = newTemperature;
        NotifyObserver();
    }
}
