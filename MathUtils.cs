using System;
public class MathUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            Console.WriteLine("Error: Cannot calculate the average of an empty array.");
            return 0;
        }
        int sum = 0;
        for(int i=0; i<numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
    public static double ApplyDiscount(double price, double discountPercentage)
    {
        double discount = price * (discountPercentage / 100);
        return price - discount;
    }
    public static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }
        int max = numbers[0];
        for (int i=1; i<numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}

    
