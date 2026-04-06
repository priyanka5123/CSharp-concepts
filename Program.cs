using System.Drawing;
using System.Xml.Schema;
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
        int[] numbers = {};
        double average = MathUtils.CalculateAverage(numbers);
        Console.WriteLine("The average is:" + average);
        double finalPrice = MathUtils.ApplyDiscount(1000,15);
        Console.WriteLine("The final price is :" + finalPrice);
        int[] myNumbers = { -5, -10, -3,-8, -2};
        int maxNumber = MathUtils.FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
        int res = Calculator.Add();
        Console.WriteLine("The sum is: " + res);
        NumberDisplay.DispalyNumbers();
        UserInput.GreetUser();
    }
}