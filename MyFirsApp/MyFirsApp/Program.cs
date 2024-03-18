// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] numbers)
{
    double sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };

    double average = GetAverage(numbers);
    Console.WriteLine(average);

    static int MaxValue(int[] numbers)
    {
        int maxValue = Int32.MinValue;
        
        foreach (int i in numbers)
        {
            if (i > maxValue)
            {
                maxValue = i;   
            }
        }

        return maxValue;
    }