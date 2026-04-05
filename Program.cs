using System.Drawing;
using Pastel;

public class Program
{
    public static int DivideNumbers(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        int result = (numerator/denominator);
        return result;
    }
    public static void Main()
    {
        int result = DivideNumbers(10, 0);
        Console.WriteLine("The result is: " + result);
        Console.WriteLine("Hello, World!".Pastel(ConsoleColor.Green));

    }
}