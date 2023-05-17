int AskForNumber(string text)
{
    Console.WriteLine(text);
    string response = GetResponse1();
    int number = int.Parse(response);
    return number;

    static string? GetResponse1()
    {
        return GetResponse();
    }
}

static string? GetResponse()
{
    return Console.ReadLine();
}

int AskForNumberInRange(string text, int min, int max)
{
    int number;
    do
    {
        number = AskForNumber(text);
    } while (number < min || number > max);
    
    return number;
}
int[] ReplicateArray(int[] original)
{
    int[] copiedArray = new int[original.Length];
    
    for (int i = 0; i < original.Length; i++)
    {
        copiedArray[i] = original[i];
    }
    
    return copiedArray;
}

// Example usage
int[] originalArray = new int[5];
int[] copiedArray;

int numberOfIntegers = AskForNumberInRange("Enter the number of integers (0-5): ", 0, 5);
for (int i = 0; i < numberOfIntegers; i++)
{
    originalArray[i] = AskForNumber($"Enter integer {i + 1}: ");
}

copiedArray = ReplicateArray(originalArray);
