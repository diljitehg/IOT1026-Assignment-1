
using System;

public class Program
{
    public static void Main()
    {
        // Task 1 - AskForNumberInRange
        int number = AskForNumberInRange("Enter a number between 10 and 20: ", 10, 20);
        Console.WriteLine("Number entered: " + number);
        
        // Task 2 - ReplicateArray
        int size = AskForNumberInRange("Enter the size of the array (0-5): ", 0, 5);
        int[] originalArray = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            int num = AskForNumber("Enter an integer: ");
            originalArray[i] = num;
        }
        
        int[] copiedArray = ReplicateArray(originalArray);
        Console.WriteLine("Copied array: ");
        for (int i = 0; i < copiedArray.Length; i++)
        {
            Console.Write(copiedArray[i] + " ");
        }
    }

    public static int AskForNumber(string text)
    {
        Console.WriteLine(text);
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        while (true)
        {
            int number = AskForNumber(text);
            if (number >= min && number <= max)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Number out of range. Try again.");
            }
        }
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
}


