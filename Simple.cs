public class Calculator
{
    public static int number1 = 5;
    public static int number2 = 10;
    public static int Add()
    {
        return number1 + number2;
    }
}
public class NumberDisplay
{
    public static void DispalyNumbers()
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
public class UserInput
{
    public static void GreetUser()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello , " + name + "!");

    }
}