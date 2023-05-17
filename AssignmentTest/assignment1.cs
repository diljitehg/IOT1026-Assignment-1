using System;

public class Program
{
    public static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        int number;
        do
        {
            number = AskForNumber(text);
        } while (number < min || number > max);

        return number;
    }

    public static int[] ReplicateArray(int[] original)
    {
        int[] copiedArray = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            copiedArray[i] = original[i];
        }

        return copiedArray;
    }

    public static void Main()
    {
        int rangeMin = 0;
        int rangeMax = 5;

        int numberOfIntegers = AskForNumberInRange("Enter the number of integers (0-5): ", rangeMin, rangeMax);

        int[] originalArray = new int[numberOfIntegers];
        for (int i = 0; i < numberOfIntegers; i++)
        {
            originalArray[i] = AskForNumber($"Enter integer {i + 1}: ");
        }

        int[] copiedArray = ReplicateArray(originalArray);

        Console.WriteLine("Copied array:");
        foreach (int num in copiedArray)
        {
            Console.WriteLine(num);
        }
    }
}
