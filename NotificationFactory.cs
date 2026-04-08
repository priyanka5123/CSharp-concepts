using System;

public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email notification: " + message);
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS notification: " + message);
    }
}

public class NotificationFactory
{
    public INotification CreateNotification(string channel)
    {
        if (channel == "email")
        {
            return new EmailNotification();
        }
        else
        {
            return new SmsNotification();
        }
    }
}

